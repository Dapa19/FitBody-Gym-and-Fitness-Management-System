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
    public partial class frmBrowseMember : Form
    {

        Master.frmMember masterMember;
        public frmBrowseMember(Master.frmMember masterMember)
        {
            InitializeComponent();

            this.masterMember = masterMember;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        Transaction.frmMembershipPayment transactionPayment;
        public frmBrowseMember(Transaction.frmMembershipPayment transactionPayment)
        {
            InitializeComponent();

            this.transactionPayment = transactionPayment;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        Transaction.frmClasses transactionClasses;
        public frmBrowseMember(Transaction.frmClasses transactionClasses)
        {
            InitializeComponent();

            this.transactionClasses = transactionClasses;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        SqlConnection con;
        string constr;
        SqlDataAdapter da;
        SqlCommand cmd;
        string query;
        DataSet ds;
        DataColumn[] dc = new DataColumn[1];

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

        private void LoadData()
        {
            ds = new DataSet();
            if (this.Tag == masterMember)
            {
                query = "SELECT * FROM Members";
            }
            if (this.Tag == transactionPayment)
            {
                query = "SELECT * FROM Members";
            }
            if (this.Tag == transactionClasses)
            {
                query = "SELECT * FROM Members";
            }
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Members");
            dc[0] = ds.Tables["Members"].Columns[0];
            ds.Tables["Members"].PrimaryKey = dc;
        }

        private void SearchData()
        {
            ds = new DataSet();
            if (rdoMemberID.Checked)
            {
                query = "SELECT * FROM Members WHERE memberID LIKE '%" + txtSearch.Text + "%'";
            }
            else if (rdoMemberName.Checked)
            {
                query = "SELECT * FROM Members WHERE fullName LIKE '%" + txtSearch.Text + "%'";
            }
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Members");
            dc[0] = ds.Tables["Members"].Columns[0];
            ds.Tables["Members"].PrimaryKey = dc;
        }

        private void ShowData()
        {
            dgvData.DataSource = ds.Tables["Members"];
            dgvData.Columns[0].HeaderText = "Member ID";
            dgvData.Columns[1].HeaderText = "Member Name";
            dgvData.Columns[2].HeaderText = "Date of Birth";
            dgvData.Columns[3].HeaderText = "Gender";
            dgvData.Columns[4].HeaderText = "Email";
            dgvData.Columns[5].HeaderText = "Phone";
            dgvData.Columns[6].HeaderText = "Membership Type";
            dgvData.Columns[7].HeaderText = "Join Date";
            dgvData.Columns[8].HeaderText = "Expiry Date";
            dgvData.AllowUserToAddRows = false;
            dgvData.ReadOnly = true;
            dgvData.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            lblCount.Text = dgvData.RowCount.ToString();
        }

        private void frmBrowseMember_Load(object sender, EventArgs e)
        {
            Connection();
            LoadData();
            ShowData();

            rdoMemberID.Checked = true;
            rdoMemberName.Checked = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchData();
            ShowData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            ShowData();
            rdoMemberID.Checked = true;
            rdoMemberName.Checked = false;
            txtSearch.Text = string.Empty;

            txtSearch.Focus();
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Tag == masterMember)
            {
                // Pastikan row yang di-double-click adalah valid (tidak di header atau di luar data)
                if (e.RowIndex >= 0 && e.RowIndex < dgvData.Rows.Count)
                {
                    // Ambil row yang di-double-click
                    DataGridViewRow selectedRow = dgvData.Rows[e.RowIndex];

                    // Ambil nilai dari setiap cell berdasarkan kolom dan set ke kontrol yang sesuai
                    masterMember.lblMemberID.Text = selectedRow.Cells[0].Value?.ToString() ?? string.Empty;
                    masterMember.txtMemberName.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
                    DateTime birthDate = Convert.ToDateTime(dgvData.Rows[e.RowIndex].Cells[2].Value);
                    masterMember.dtpBirthDate.Value = birthDate;
                    if (selectedRow.Cells[3].Value.ToString() == "Male")
                    {
                        masterMember.rdoMale.Checked = true;
                        masterMember.rdoFemale.Checked = false;
                    }
                    else if (selectedRow.Cells[3].Value.ToString() == "Female")
                    {
                        masterMember.rdoMale.Checked = false;
                        masterMember.rdoFemale.Checked = true;
                    }
                    masterMember.txtMemberEmail.Text = selectedRow.Cells[4].Value?.ToString() ?? string.Empty;
                    masterMember.txtMemberPhone.Text = selectedRow.Cells[5].Value?.ToString() ?? string.Empty;

                    string membershipType = selectedRow.Cells[6].Value?.ToString() ?? string.Empty;
                    masterMember.SelectedMembership = membershipType;

                    DateTime joinDate = Convert.ToDateTime(dgvData.Rows[e.RowIndex].Cells[7].Value);
                    masterMember.dtpJoinDate.Value = joinDate;

                    DateTime expiryDate = Convert.ToDateTime(dgvData.Rows[e.RowIndex].Cells[8].Value);
                    masterMember.dtpExpiryDate.Value = expiryDate;
                }
                this.Close();
            }
            else if (this.Tag == transactionPayment)
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvData.Rows.Count)
                {
                    // Ambil row yang di-double-click
                    DataGridViewRow selectedRow = dgvData.Rows[e.RowIndex];

                    transactionPayment.lblMemberID.Text = selectedRow.Cells[0].Value?.ToString() ?? string.Empty;
                    transactionPayment.lblMemberDescription.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;

                    DateTime expiryDate = Convert.ToDateTime(dgvData.Rows[e.RowIndex].Cells[8].Value);
                    transactionPayment.lblCurrentExpiry.Text = expiryDate.ToString("D");

                    transactionPayment.dtpExpiryDate.Value = expiryDate;
                }
                this.Close();
            }
            else if (this.Tag == transactionClasses)
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvData.Rows.Count)
                {
                    // Ambil row yang di-double-click
                    DataGridViewRow selectedRow = dgvData.Rows[e.RowIndex];

                    transactionClasses.lblMemberID.Text = selectedRow.Cells[0].Value?.ToString() ?? string.Empty;
                    transactionClasses.lblMemberName.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;

                }
                this.Close();
            }
        }
    }
}
