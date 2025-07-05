using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FitBody.Master
{
    public partial class frmStaff : Form
    {
        public frmStaff()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        frmMain mainMenu;
        public frmStaff(frmMain mainMenu)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
        }

        public string SelectedPosition
        {
            get { return cboPosition.SelectedItem?.ToString() ?? string.Empty; }
            set
            {
                if (cboPosition.Items.Contains(value))
                {
                    cboPosition.SelectedItem = value;
                }
                else
                {
                    cboPosition.SelectedItem = "Others"; // Default jika tidak ditemukan
                }
            }
        }

        SqlConnection con;
        string constr;
        SqlDataAdapter da;
        SqlCommand cmd;
        string query;
        DataSet ds;
        DataRow dr;
        DataColumn[] dc = new DataColumn[1];
        SqlCommandBuilder cb;
        SqlDataReader dl;

        private void Connection()
        {
            try
            {
                constr = "Data Source = MSI\\SQLEXPRESS; Initial Catalog = FitBody; Integrated Security = true";
                con = new SqlConnection(constr);
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AutoID()
        {
            long hitung;
            string urut;

            ds = new DataSet();
            query = "SELECT * FROM Staff WHERE staffID IN (SELECT MAX(staffID) FROM Staff) ORDER BY staffID DESC";
            cmd = new SqlCommand(query, con);
            dl = cmd.ExecuteReader();
            dl.Read();

            if (dl.HasRows)
            {
                hitung = Convert.ToInt64(dl[0].ToString().Substring(dl["staffID"].ToString().Length - 2, 2)) + 1; //2
                string joinstr = "00" + hitung; // 002
                urut = "STF00000" + joinstr.Substring(joinstr.Length - 2, 2); //PRO0000002
            }
            else
            {
                urut = "STF0000001";
            }
            dl.Close();
            lblStaffID.Text = urut;
        }

        private void LoadData()
        {
            ds = new DataSet();
            query = "SELECT * FROM Staff";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Staff");
            dc[0] = ds.Tables["Staff"].Columns[0];
            ds.Tables["Staff"].PrimaryKey = dc;
        }

        private void UpdateData()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds.Tables["Staff"]);
        }

        private void Empty()
        {
            AutoID();

            txtStaffName.Text = string.Empty;
            cboPosition.SelectedIndex = -1;
            txtStaffEmail.Text = string.Empty;
            txtStaffPhone.Text = string.Empty;
            dtpHireDate.Value = DateTime.Now;

            txtStaffName.Focus();
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            Connection();
            AutoID();

            dtpHireDate.CustomFormat = "dd MMMM yyyy";
            dtpHireDate.Format = DateTimePickerFormat.Custom;

            cboPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPosition.Items.Add("Admin");
            cboPosition.Items.Add("Instructor");
            cboPosition.Items.Add("Medical Team");
            cboPosition.Items.Add("Maintenance Team");
            cboPosition.Items.Add("Marketing Team");

            dtpHireDate.Value = DateTime.Now;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblStaffID.Text) || string.IsNullOrWhiteSpace(txtStaffName.Text) || cboPosition.SelectedItem == null || string.IsNullOrWhiteSpace(txtStaffEmail.Text) || string.IsNullOrWhiteSpace(txtStaffPhone.Text))
            {
                MessageBox.Show("Please fill in all fields before adding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadData();

            dr = ds.Tables["Staff"].Rows.Find(lblStaffID.Text);
            if (dr == null)
            {
                dr = ds.Tables["Staff"].NewRow();
                dr[0] = lblStaffID.Text;
                dr[1] = txtStaffName.Text;
                dr[2] = cboPosition.SelectedItem.ToString();
                dr[3] = txtStaffEmail.Text;
                dr[4] = txtStaffPhone.Text;
                dr[5] = dtpHireDate.Value;
                ds.Tables["Staff"].Rows.Add(dr);
                UpdateData();
                MessageBox.Show("Staff ID " + lblStaffID.Text + " has been added.", "Add Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Empty();
            }
            else
            {
                MessageBox.Show("Staff ID " + lblStaffID.Text + " exists in database.", "Add Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Empty();
            }
        }

        private string connectionString = "Data Source = MSI\\SQLEXPRESS; Initial Catalog = FitBody; Integrated Security = true";

        private bool IsStaffReferenced(string staffId)
        {
            bool isReferenced = false;

            string query = @"
        SELECT COUNT(*) FROM MaintenanceEquipment WHERE staffID = @StaffID
        UNION ALL
        SELECT COUNT(*) FROM ClassHeader WHERE staffID = @StaffID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StaffID", staffId);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader.GetInt32(0) > 0)
                            {
                                isReferenced = true;
                                break;
                            }
                        }
                    }
                }
            }

            return isReferenced;
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblStaffID.Text) ||
        string.IsNullOrWhiteSpace(txtStaffName.Text) ||
        cboPosition.SelectedItem == null ||
        string.IsNullOrWhiteSpace(txtStaffEmail.Text) ||
        string.IsNullOrWhiteSpace(txtStaffPhone.Text))
            {
                MessageBox.Show("Please fill in all fields before editing.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string staffId = lblStaffID.Text;

            if (IsStaffReferenced(staffId))
            {
                MessageBox.Show("Staff ID " + staffId + " cannot be edited because it is referenced in MaintenanceEquipment or ClassHeader.", "Edit Staff", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadData();

            dr = ds.Tables["Staff"].Rows.Find(staffId);
            if (dr != null)
            {
                dr[1] = txtStaffName.Text;
                dr[2] = cboPosition.SelectedItem.ToString();
                dr[3] = txtStaffEmail.Text;
                dr[4] = txtStaffPhone.Text;
                dr[5] = dtpHireDate.Value;
                UpdateData();
                MessageBox.Show("Staff ID " + staffId + " has been edited.", "Edit Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Empty();
            }
            else
            {
                MessageBox.Show("Staff ID " + staffId + " does not exist in the database.", "Edit Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Empty();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblStaffID.Text))
            {
                MessageBox.Show("Please enter Staff ID before deleting.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string staffId = lblStaffID.Text;

            if (IsStaffReferenced(staffId))
            {
                MessageBox.Show("Staff ID " + staffId + " cannot be deleted because it is referenced in MaintenanceEquipment or ClassHeader.", "Delete Staff", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadData();

            dr = ds.Tables["Staff"].Rows.Find(staffId);
            if (dr != null)
            {
                dr.Delete();
                UpdateData();
                MessageBox.Show("Staff ID " + staffId + " has been deleted.", "Delete Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Empty();
            }
            else
            {
                MessageBox.Show("Staff ID " + staffId + " does not exist in the database.", "Delete Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Empty();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Empty();
        }

        private void btnBrowseStaff_Click(object sender, EventArgs e)
        {
            Master.frmBrowseStaff masterBrowseStaff = new Master.frmBrowseStaff(this);
            masterBrowseStaff.Tag = this;
            masterBrowseStaff.ShowDialog();
        }
    }
}
