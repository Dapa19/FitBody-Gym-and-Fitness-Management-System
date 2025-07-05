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
    public partial class frmBrowseProduct : Form
    {
        public frmBrowseProduct()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        Master.frmProduct masterProduct;
        public frmBrowseProduct(Master.frmProduct masterProduct)
        {
            InitializeComponent();

            this.masterProduct = masterProduct;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        Transaction.frmInventory transactionInventory;
        public frmBrowseProduct(Transaction.frmInventory transactionInventory)
        {
            InitializeComponent();

            this.transactionInventory = transactionInventory;

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
            if (this.Tag == masterProduct)
            {
                query = "SELECT * FROM Product";
            }
            if (this.Tag == transactionInventory)
            {
                query = "SELECT * FROM Product";
            }
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Product");
            dc[0] = ds.Tables["Product"].Columns[0];
            ds.Tables["Product"].PrimaryKey = dc;
        }

        private void SearchData()
        {
            ds = new DataSet();
            if (rdoProductID.Checked)
            {
                query = "SELECT * FROM Product WHERE ProductID LIKE '%" + txtSearch.Text + "%'";
            }
            else if (rdoProductName.Checked)
            {
                query = "SELECT * FROM Product WHERE ProductName LIKE '%" + txtSearch.Text + "%'";
            }
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Product");
            dc[0] = ds.Tables["Product"].Columns[0];
            ds.Tables["Product"].PrimaryKey = dc;
        }

        private void ShowData()
        {
            if (this.Tag == masterProduct)
            {
                dgvData.DataSource = ds.Tables["Product"];
                dgvData.Columns[0].HeaderText = "Product ID";
                dgvData.Columns[1].HeaderText = "Product Name";
                dgvData.Columns[2].HeaderText = "Category";
                dgvData.Columns[3].HeaderText = "Purchasing Price (Rp)";
                dgvData.Columns[3].DefaultCellStyle.Format = "#,##0";
                dgvData.AllowUserToAddRows = false;
                dgvData.ReadOnly = true;
                dgvData.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                lblCount.Text = dgvData.RowCount.ToString();
            }

            if (this.Tag == transactionInventory)
            {
                dgvData.DataSource = ds.Tables["Product"];
                dgvData.Columns[0].HeaderText = "Product ID";
                dgvData.Columns[1].HeaderText = "Product Name";
                dgvData.Columns[2].HeaderText = "Category";
                dgvData.Columns[3].HeaderText = "Purchasing Price (Rp)";
                dgvData.Columns[3].DefaultCellStyle.Format = "#,##0";
                dgvData.AllowUserToAddRows = false;
                dgvData.ReadOnly = true;
                dgvData.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                lblCount.Text = dgvData.RowCount.ToString();
            }

        }

        private void frmBrowseProduct_Load(object sender, EventArgs e)
        {
            Connection();
            LoadData();
            ShowData();

            rdoProductID.Checked = true;
            rdoProductName.Checked = false;

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
            rdoProductID.Checked = true;
            rdoProductName.Checked = false;
            txtSearch.Text = string.Empty;

            txtSearch.Focus();
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Tag == masterProduct)
            {
                // Pastikan row yang di-double-click adalah valid (tidak di header atau di luar data)
                if (e.RowIndex >= 0 && e.RowIndex < dgvData.Rows.Count)
                {
                    // Ambil row yang di-double-click
                    DataGridViewRow selectedRow = dgvData.Rows[e.RowIndex];

                    // Ambil nilai dari setiap cell berdasarkan kolom dan set ke kontrol yang sesuai
                    masterProduct.lblProductID.Text = selectedRow.Cells[0].Value?.ToString() ?? string.Empty;
                    masterProduct.txtProductName.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
                    string kategori = selectedRow.Cells[2].Value?.ToString() ?? string.Empty;

                    masterProduct.SelectedCategory = kategori;


                    // Set harga beli ke NumericUpDown
                    masterProduct.nudPurchasingPrice.Value = Convert.ToDecimal(selectedRow.Cells[3].Value ?? 0);
                }
                this.Close();
            }
            else if (this.Tag == transactionInventory)
            {
                // Pastikan row yang di-double-click adalah valid (tidak di header atau di luar data)
                if (e.RowIndex >= 0 && e.RowIndex < dgvData.Rows.Count)
                {
                    // Ambil row yang di-double-click
                    DataGridViewRow selectedRow = dgvData.Rows[e.RowIndex];

                    // Ambil nilai dari setiap cell berdasarkan kolom dan set ke kontrol yang sesuai
                    transactionInventory.lblProductID.Text = selectedRow.Cells[0].Value?.ToString() ?? string.Empty;
                    transactionInventory.lblProductName.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
                    transactionInventory.lblCategory.Text = selectedRow.Cells[2].Value?.ToString() ?? string.Empty;
                    transactionInventory.lblPurchasingPrice.Text = selectedRow.Cells[3].Value?.ToString() ?? string.Empty;
                }
                this.Close();
            }

        }
    }
}
