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

namespace FitBody.Master
{
    public partial class frmMember : Form
    {
        public frmMember()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        frmMain mainMenu;
        public frmMember(frmMain mainMenu)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
        }

        public string SelectedMembership
        {
            get { return cboMembershipType.SelectedItem?.ToString() ?? string.Empty; }
            set
            {
                if (cboMembershipType.Items.Contains(value))
                {
                    cboMembershipType.SelectedItem = value;
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

        private string connectionString = "Data Source = MSI\\SQLEXPRESS; Initial Catalog = FitBody; Integrated Security = true";

        private void AutoID()
        {
            long hitung;
            string urut;

            ds = new DataSet();
            query = "SELECT * FROM Members WHERE memberID IN (SELECT MAX(memberID) FROM Members) ORDER BY memberID DESC";
            cmd = new SqlCommand(query, con);
            dl = cmd.ExecuteReader();
            dl.Read();

            if (dl.HasRows)
            {
                hitung = Convert.ToInt64(dl[0].ToString().Substring(dl["memberID"].ToString().Length - 2, 2)) + 1; //2
                string joinstr = "00" + hitung; // 002
                urut = "MEM00000" + joinstr.Substring(joinstr.Length - 2, 2); //PRO0000002
            }
            else
            {
                urut = "MEM0000001";
            }
            dl.Close();
            lblMemberID.Text = urut;
        }

        private void LoadData()
        {
            ds = new DataSet();
            query = "SELECT * FROM Members";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Members");
            dc[0] = ds.Tables["Members"].Columns[0];
            ds.Tables["Members"].PrimaryKey = dc;
        }

        private void UpdateData()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds.Tables["Members"]);
        }

        private void Empty()
        {
            AutoID();

            txtMemberName.Text = string.Empty;
            dtpBirthDate.Value = DateTime.Now;
            rdoMale.Checked = true;
            rdoFemale.Checked = false;
            txtMemberEmail.Text = string.Empty;
            txtMemberPhone.Text = string.Empty;
            cboMembershipType.SelectedIndex = -1;
            dtpJoinDate.Value = DateTime.Now;
            dtpExpiryDate.Value = DateTime.Now;

            txtMemberName.Focus();
        }

        private void frmMember_Load(object sender, EventArgs e)
        {
            Connection();
            AutoID();

            cboMembershipType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMembershipType.Items.Add("Monthly");
            cboMembershipType.Items.Add("Yearly");

            dtpBirthDate.CustomFormat = "dd MMMM yyyy";
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.Value = DateTime.Now;

            dtpJoinDate.CustomFormat = "dd MMMM yyyy";
            dtpJoinDate.Format = DateTimePickerFormat.Custom;
            dtpJoinDate.Value = DateTime.Now;

            dtpExpiryDate.CustomFormat = "dd MMMM yyyy";
            dtpExpiryDate.Format = DateTimePickerFormat.Custom;
            dtpExpiryDate.Value = DateTime.Now;

            rdoMale.Checked = true;
            rdoFemale.Checked = false;
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMemberName.Text) ||
                string.IsNullOrWhiteSpace(txtMemberEmail.Text) ||
                string.IsNullOrWhiteSpace(txtMemberPhone.Text) ||
                cboMembershipType.SelectedItem == null ||
                (!rdoMale.Checked && !rdoFemale.Checked))
            {
                MessageBox.Show("Please fill in all fields before proceeding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool IsMemberReferenced(string memberId)
        {
            bool isReferenced = false;

            string query = @"
        SELECT COUNT(*) FROM MembershipPayments WHERE memberID = @MemberID
        UNION ALL
        SELECT COUNT(*) FROM ClassDetail WHERE memberID = @MemberID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MemberID", memberId);
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


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            LoadData();

            dr = ds.Tables["Members"].Rows.Find(lblMemberID.Text);
            if (dr == null) // Jika baris yang dicari berdasarkan lblProductID belum ada
            {
                dr = ds.Tables["Members"].NewRow();
                dr[0] = lblMemberID.Text;
                dr[1] = txtMemberName.Text;
                dr[2] = dtpBirthDate.Value;
                if (rdoMale.Checked)
                {
                    dr[3] = rdoMale.Text;
                }
                if (rdoFemale.Checked)
                {
                    dr[3] = rdoFemale.Text;
                }
                dr[4] = txtMemberEmail.Text;
                dr[5] = txtMemberPhone.Text;
                dr[6] = cboMembershipType.SelectedItem.ToString();
                dr[7] = dtpJoinDate.Value;
                dr[8] = dtpExpiryDate.Value;
                ds.Tables["Members"].Rows.Add(dr);
                UpdateData();
                MessageBox.Show("Member ID " + lblMemberID.Text + " has been added.", "Add Member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Empty();
            }
            else // Jika baris yang dicari berdasarkan lblProductID sudah ada
            {
                MessageBox.Show("Member ID " + lblMemberID.Text + " exists in database.", "Add Member", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Empty();
            }
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (!ValidateInput()) return;

            LoadData();

            dr = ds.Tables["Members"].Rows.Find(lblMemberID.Text);
            if (dr != null) // Jika baris yang dicari berdasarkan lblProductID sudah ada
            {
                dr[1] = txtMemberName.Text;
                dr[2] = dtpBirthDate.Value;
                if (rdoMale.Checked)
                {
                    dr[3] = rdoMale.Text;
                }
                if (rdoFemale.Checked)
                {
                    dr[3] = rdoFemale.Text;
                }
                dr[4] = txtMemberEmail.Text;
                dr[5] = txtMemberPhone.Text;
                dr[6] = cboMembershipType.SelectedItem.ToString();
                dr[7] = dtpJoinDate.Value;
                dr[8] = dtpExpiryDate.Value;
                UpdateData();
                MessageBox.Show("Member ID " + lblMemberID.Text + " has been edited.", "Edit Member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Empty();
            }
            else // Jika baris yang dicari berdasarkan lblProductID belum ada
            {
                MessageBox.Show("Member ID " + lblMemberID.Text + " does not exists in database.", "Edit Member", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Empty();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (!ValidateInput()) return;

            LoadData();

            string memberId = lblMemberID.Text;

            if (IsMemberReferenced(memberId))
            {
                MessageBox.Show("Member ID " + memberId + " cannot be deleted because it is referenced in MembershipPayments or ClassDetail.", "Delete Member", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dr = ds.Tables["Members"].Rows.Find(memberId);
            if (dr != null)
            {
                dr.Delete();
                UpdateData();
                MessageBox.Show("Member ID " + memberId + " has been deleted.", "Delete Member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Empty();
            }
            else
            {
                MessageBox.Show("Member ID " + memberId + " does not exist in the database.", "Delete Member", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Empty();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Empty();
        }

        private void btnBrowseMember_Click(object sender, EventArgs e)
        {
            Master.frmBrowseMember masterBrowseMember = new Master.frmBrowseMember(this);
            masterBrowseMember.Tag = this;
            masterBrowseMember.ShowDialog();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            Additional.frmMembershipCalculator additionCalculator = new Additional.frmMembershipCalculator(this);
            additionCalculator.Tag = this;
            additionCalculator.ShowDialog();
        }
    }
}
