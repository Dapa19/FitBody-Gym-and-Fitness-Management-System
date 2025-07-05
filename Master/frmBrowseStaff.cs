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
    public partial class frmBrowseStaff : Form
    {
        public frmBrowseStaff()
        {
            InitializeComponent();
        }

        Master.frmStaff masterStaff;
        public frmBrowseStaff(Master.frmStaff masterStaff)
        {
            InitializeComponent();

            this.masterStaff = masterStaff;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        Transaction.frmClasses transactionClasses;
        public frmBrowseStaff(Transaction.frmClasses transactionClasses)
        {
            InitializeComponent();

            this.transactionClasses = transactionClasses;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        Transaction.frmEquipmentMaintenance transactionMaintenance;
        public frmBrowseStaff(Transaction.frmEquipmentMaintenance transactionMaintenance)
        {
            InitializeComponent();

            this.transactionMaintenance = transactionMaintenance;

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


            query = "SELECT * FROM Staff";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Staff");
            dc[0] = ds.Tables["Staff"].Columns[0];
            ds.Tables["Staff"].PrimaryKey = dc;
        }

        private void SearchData()
        {
            ds = new DataSet();
            //Jika tag milik masterProduct
            if (rdoStaffID.Checked)
            {
                query = "SELECT * FROM Staff WHERE staffID LIKE '%" + txtSearch.Text + "%'";
            }
            else if (rdoStaffName.Checked)
            {
                query = "SELECT * FROM Staff WHERE staffName LIKE '%" + txtSearch.Text + "%'";
            }
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Staff");
            dc[0] = ds.Tables["Staff"].Columns[0];
            ds.Tables["Staff"].PrimaryKey = dc;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchData();
            ShowData();
        }

        private void ShowData()
        {
            dgvData.DataSource = ds.Tables["Staff"];
            dgvData.Columns[0].HeaderText = "Staff ID";
            dgvData.Columns[1].HeaderText = "Staff Name";
            dgvData.Columns[2].HeaderText = "Position";
            dgvData.Columns[3].HeaderText = "Email";
            dgvData.Columns[4].HeaderText = "Phone";
            dgvData.Columns[5].HeaderText = "Hire Date";
            dgvData.AllowUserToAddRows = false;
            dgvData.ReadOnly = true;
            dgvData.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            lblCount.Text = dgvData.RowCount.ToString();
        }

        private void frmBrowseStaff_Load(object sender, EventArgs e)
        {
            Connection();
            LoadData();
            ShowData();

            rdoStaffID.Checked = true;
            rdoStaffName.Checked = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            ShowData();
            rdoStaffID.Checked = true;
            rdoStaffName.Checked = false;
            txtSearch.Text = string.Empty;

            txtSearch.Focus();
        }

        private void dgvData_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Tag == masterStaff)
            {
                // Pastikan row yang di-double-click adalah valid (tidak di header atau di luar data)
                if (e.RowIndex >= 0 && e.RowIndex < dgvData.Rows.Count)
                {
                    // Ambil row yang di-double-click
                    DataGridViewRow selectedRow = dgvData.Rows[e.RowIndex];

                    // Ambil nilai dari setiap cell berdasarkan kolom dan set ke kontrol yang sesuai
                    masterStaff.lblStaffID.Text = selectedRow.Cells[0].Value?.ToString() ?? string.Empty;
                    masterStaff.txtStaffName.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
                    string position = selectedRow.Cells[2].Value?.ToString() ?? string.Empty;
                    masterStaff.SelectedPosition = position;
                    masterStaff.txtStaffEmail.Text = selectedRow.Cells[3].Value?.ToString() ?? string.Empty;
                    masterStaff.txtStaffPhone.Text = selectedRow.Cells[4].Value?.ToString() ?? string.Empty;
                    // Ambil nilai dari kolom Hire Date
                    DateTime hireDate = Convert.ToDateTime(dgvData.Rows[e.RowIndex].Cells[5].Value);
                    masterStaff.dtpHireDate.Value = hireDate;



                }
                this.Close();
            }
            else if (this.Tag == transactionClasses)
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvData.Rows.Count)
                {
                    // Ambil row yang di-double-click
                    DataGridViewRow selectedRow = dgvData.Rows[e.RowIndex];

                    // Ambil nilai dari setiap cell berdasarkan kolom dan set ke kontrol yang sesuai
                    transactionClasses.lblStaffID.Text = selectedRow.Cells[0].Value?.ToString() ?? string.Empty;
                    transactionClasses.lblStaffName.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
                }
                this.Close();
            }
            else if (this.Tag == transactionMaintenance)
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvData.Rows.Count)
                {
                    // Ambil row yang di-double-click
                    DataGridViewRow selectedRow = dgvData.Rows[e.RowIndex];

                    // Ambil nilai dari setiap cell berdasarkan kolom dan set ke kontrol yang sesuai
                    transactionMaintenance.lblStaffID.Text = selectedRow.Cells[0].Value?.ToString() ?? string.Empty;
                    transactionMaintenance.lblStaffName.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
                }
                this.Close();
            }
        }
    }
}
