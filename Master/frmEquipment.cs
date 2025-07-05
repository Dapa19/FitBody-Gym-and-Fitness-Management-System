using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace FitBody.Master
{
    public partial class frmEquipment : Form
    {
        public frmEquipment()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public string SelectedCategory
        {
            get { return cboCategory.SelectedItem?.ToString() ?? string.Empty; }
            set
            {
                if (cboCategory.Items.Contains(value))
                {
                    cboCategory.SelectedItem = value;
                }
                else
                {
                    cboCategory.SelectedItem = "Others"; // Default jika tidak ditemukan
                }
            }
        }

        public string SelectedCondition
        {
            get { return cboCondition.SelectedItem?.ToString() ?? string.Empty; }
            set
            {
                if (cboCondition.Items.Contains(value))
                {
                    cboCondition.SelectedItem = value;
                }
            }
        }

        frmMain mainMenu;
        public frmEquipment(frmMain mainMenu)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
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
            query = "SELECT * FROM Equipment WHERE equipmentID IN (SELECT MAX(equipmentID) FROM Equipment) ORDER BY equipmentID DESC";
            cmd = new SqlCommand(query, con);
            dl = cmd.ExecuteReader();
            dl.Read();

            if (dl.HasRows)
            {
                hitung = Convert.ToInt64(dl[0].ToString().Substring(dl["equipmentID"].ToString().Length - 2, 2)) + 1; //2
                string joinstr = "00" + hitung; // 002
                urut = "EQU00000" + joinstr.Substring(joinstr.Length - 2, 2); //PRO0000002
            }
            else
            {
                urut = "EQU0000001";
            }
            dl.Close();
            lblEquipmentID.Text = urut;
        }

        private void LoadData()
        {
            ds = new DataSet();
            query = "SELECT * FROM Equipment";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Equipment");
            dc[0] = ds.Tables["Equipment"].Columns[0];
            ds.Tables["Equipment"].PrimaryKey = dc;
        }

        private void UpdateData()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds.Tables["Equipment"]);
        }

        private void Empty()
        {
            AutoID();

            txtEquipmentName.Text = string.Empty;
            cboCategory.SelectedIndex = -1;
            cboCondition.SelectedIndex = -1;
            dtpPurchaseDate.Value = DateTime.Now;

            txtEquipmentName.Focus();
        }

        private void frmEquipment_Load(object sender, EventArgs e)
        {
            Connection();
            AutoID();

            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.Items.Add("Strength Training");
            cboCategory.Items.Add("Cardio");
            cboCategory.Items.Add("Functional Training");
            cboCategory.Items.Add("Flexibility and Recovery");
            cboCategory.Items.Add("Others");

            cboCondition.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCondition.Items.Add("Good");
            cboCondition.Items.Add("Need Repairs");
            cboCondition.Items.Add("Defective");

            dtpPurchaseDate.CustomFormat = "dd MMMM yyyy";
            dtpPurchaseDate.Format = DateTimePickerFormat.Custom;
            dtpPurchaseDate.Value = DateTime.Now;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblEquipmentID.Text) ||
        string.IsNullOrWhiteSpace(txtEquipmentName.Text) ||
        cboCategory.SelectedItem == null ||
        cboCondition.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields before adding equipment.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadData();

            dr = ds.Tables["Equipment"].Rows.Find(lblEquipmentID.Text);
            if (dr == null)
            {
                dr = ds.Tables["Equipment"].NewRow();
                dr[0] = lblEquipmentID.Text;
                dr[1] = txtEquipmentName.Text;
                dr[2] = cboCategory.SelectedItem.ToString();
                dr[3] = dtpPurchaseDate.Value;
                dr[4] = cboCondition.SelectedItem.ToString();
                ds.Tables["Equipment"].Rows.Add(dr);
                UpdateData();
                MessageBox.Show("Equipment ID " + lblEquipmentID.Text + " has been added.", "Add Equipment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Empty();
            }
            else
            {
                MessageBox.Show("Equipment ID " + lblEquipmentID.Text + " exists in database.", "Add Equipment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Empty();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblEquipmentID.Text) ||
        string.IsNullOrWhiteSpace(txtEquipmentName.Text) ||
        cboCategory.SelectedItem == null ||
        cboCondition.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields before editing equipment.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadData();

            dr = ds.Tables["Equipment"].Rows.Find(lblEquipmentID.Text);
            if (dr != null)
            {
                dr[1] = txtEquipmentName.Text;
                dr[2] = cboCategory.SelectedItem.ToString();
                dr[3] = dtpPurchaseDate.Value;
                dr[4] = cboCondition.SelectedItem.ToString();
                UpdateData();
                MessageBox.Show("Equipment ID " + lblEquipmentID.Text + " has been edited.", "Edit Equipment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Empty();
            }
            else
            {
                MessageBox.Show("Equipment ID " + lblEquipmentID.Text + " does not exist in database.", "Edit Equipment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Empty();
            }
        }

        private string connectionString = "Data Source = MSI\\SQLEXPRESS; Initial Catalog = FitBody; Integrated Security = true";

        private bool IsEquipmentReferenced(string equipmentId)
        {
            bool isReferenced = false;

            string query = "SELECT COUNT(*) FROM MaintenanceEquipment WHERE equipmentID = @EquipmentID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EquipmentID", equipmentId);
                    conn.Open();

                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        isReferenced = true;
                    }
                }
            }

            return isReferenced;
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblEquipmentID.Text))
            {
                MessageBox.Show("Please enter an Equipment ID before deleting.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string equipmentId = lblEquipmentID.Text;

            if (IsEquipmentReferenced(equipmentId))
            {
                MessageBox.Show("Equipment ID " + equipmentId + " cannot be deleted because it is referenced in MaintenanceEquipment.", "Delete Equipment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadData();

            dr = ds.Tables["Equipment"].Rows.Find(equipmentId);
            if (dr != null)
            {
                dr.Delete();
                UpdateData();
                MessageBox.Show("Equipment ID " + equipmentId + " has been deleted.", "Delete Equipment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Empty();
            }
            else
            {
                MessageBox.Show("Equipment ID " + equipmentId + " does not exist in the database.", "Delete Equipment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Empty();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Empty();
        }

        private void btnBrowseEquipment_Click(object sender, EventArgs e)
        {
            Master.frmBrowseEquipment masterBrowseEquipment = new Master.frmBrowseEquipment(this);
            masterBrowseEquipment.Tag = this;
            masterBrowseEquipment.ShowDialog();
        }
    }


}
