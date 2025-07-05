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
    public partial class frmBrowseEquipment : Form
    {
        public frmBrowseEquipment()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        Master.frmEquipment masterEquipment;
        public frmBrowseEquipment(Master.frmEquipment masterEquipment)
        {
            InitializeComponent();

            this.masterEquipment = masterEquipment;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        Transaction.frmEquipmentMaintenance transactionMaintenance;
        public frmBrowseEquipment(Transaction.frmEquipmentMaintenance transactionMaintenance)
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
            query = "SELECT * FROM Equipment";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Equipment");
            dc[0] = ds.Tables["Equipment"].Columns[0];
            ds.Tables["Equipment"].PrimaryKey = dc;
        }

        private void SearchData()
        {
            ds = new DataSet();
            if (rdoEquipmentID.Checked)
            {
                query = "SELECT * FROM Equipment WHERE equipmentID LIKE '%" + txtSearch.Text + "%'";
            }
            else if (rdoEquipmentName.Checked)
            {
                query = "SELECT * FROM Equipment WHERE equipmentName LIKE '%" + txtSearch.Text + "%'";
            }
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Equipment");
            dc[0] = ds.Tables["Equipment"].Columns[0];
            ds.Tables["Equipment"].PrimaryKey = dc;
        }

        private void ShowData()
        {
            dgvData.DataSource = ds.Tables["Equipment"];
            dgvData.Columns[0].HeaderText = "Equipment ID";
            dgvData.Columns[1].HeaderText = "Equipment Name";
            dgvData.Columns[2].HeaderText = "Category";
            dgvData.Columns[3].HeaderText = "Purchase Date";
            dgvData.Columns[4].HeaderText = "Condition";
            dgvData.AllowUserToAddRows = false;
            dgvData.ReadOnly = true;
            dgvData.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            lblCount.Text = dgvData.RowCount.ToString();
        }

        private void frmBrowseEquipment_Load(object sender, EventArgs e)
        {
            Connection();
            LoadData();
            ShowData();

            rdoEquipmentID.Checked = true;
            rdoEquipmentName.Checked = false;
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
            rdoEquipmentID.Checked = true;
            rdoEquipmentName.Checked = false;
            txtSearch.Text = string.Empty;

            txtSearch.Focus();
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Tag == masterEquipment)
            {
                // Pastikan row yang di-double-click adalah valid (tidak di header atau di luar data)
                if (e.RowIndex >= 0 && e.RowIndex < dgvData.Rows.Count)
                {
                    // Ambil row yang di-double-click
                    DataGridViewRow selectedRow = dgvData.Rows[e.RowIndex];

                    // Ambil nilai dari setiap cell berdasarkan kolom dan set ke kontrol yang sesuai
                    masterEquipment.lblEquipmentID.Text = selectedRow.Cells[0].Value?.ToString() ?? string.Empty;
                    masterEquipment.txtEquipmentName.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;

                    string kategori = selectedRow.Cells[2].Value?.ToString() ?? string.Empty;
                    masterEquipment.SelectedCategory = kategori;

                    DateTime purchaseDate = Convert.ToDateTime(dgvData.Rows[e.RowIndex].Cells[3].Value);
                    masterEquipment.dtpPurchaseDate.Value = purchaseDate;

                    string kondisi = selectedRow.Cells[4].Value?.ToString() ?? string.Empty;
                    masterEquipment.SelectedCondition = kondisi;
                }
                this.Close();
            }
            else if (this.Tag == transactionMaintenance)
            {
                // Pastikan row yang di-double-click adalah valid (tidak di header atau di luar data)
                if (e.RowIndex >= 0 && e.RowIndex < dgvData.Rows.Count)
                {
                    // Ambil row yang di-double-click
                    DataGridViewRow selectedRow = dgvData.Rows[e.RowIndex];

                    // Ambil nilai dari setiap cell berdasarkan kolom dan set ke kontrol yang sesuai
                    transactionMaintenance.lblEquipmentID.Text = selectedRow.Cells[0].Value?.ToString() ?? string.Empty;
                    transactionMaintenance.lblEquipmentName.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;

                    string kategori = selectedRow.Cells[2].Value?.ToString() ?? string.Empty;
                    transactionMaintenance.lblCategory.Text = kategori;

                    string kondisi = selectedRow.Cells[4].Value?.ToString() ?? string.Empty;
                    transactionMaintenance.lblCurrentCondition.Text = kondisi;
                }
                this.Close();
            }
        }
    }
}
