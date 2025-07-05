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

namespace FitBody.Transaction
{
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }

        frmMain mainMenu;
        public frmInventory(frmMain mainMenu)
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

        private void LoadData()
        {
            ds = new DataSet();
            query = "SELECT p.productID, p.productName, p.productCategory, p.purchasingPrice, i.qty FROM Product p INNER JOIN Inventory i ON p.productID = i.productID";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);

            // Define the INSERT, UPDATE, and DELETE commands
            da.InsertCommand = new SqlCommand("INSERT INTO Inventory (productID, qty) VALUES (@productID, @qty)", con);
            da.InsertCommand.Parameters.Add("@productID", SqlDbType.NVarChar, 50, "productID");
            da.InsertCommand.Parameters.Add("@qty", SqlDbType.Int, 0, "qty");

            da.UpdateCommand = new SqlCommand("UPDATE Inventory SET qty = @qty WHERE productID = @productID", con);
            da.UpdateCommand.Parameters.Add("@qty", SqlDbType.Int, 0, "qty");
            da.UpdateCommand.Parameters.Add("@productID", SqlDbType.NVarChar, 50, "productID");

            da.DeleteCommand = new SqlCommand("DELETE FROM Inventory WHERE productID = @productID", con);
            da.DeleteCommand.Parameters.Add("@productID", SqlDbType.NVarChar, 50, "productID");

            da.Fill(ds, "Inventory");
            dc[0] = ds.Tables["Inventory"].Columns[0];
            ds.Tables["Inventory"].PrimaryKey = dc;
        }

        private void UpdateData()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            try
            {
                da.Update(ds.Tables["Inventory"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Empty()
        {

            lblProductID.Text = string.Empty;
            lblProductName.Text = string.Empty;
            lblCategory.Text = string.Empty;
            lblPurchasingPrice.Text = string.Empty;

            nudStock.Value = 0;

            nudStock.Focus();
        }

        private void ShowData()
        {
            dgvData.DataSource = ds.Tables["Inventory"];
            dgvData.Columns[0].HeaderText = "Product ID";
            dgvData.Columns[1].HeaderText = "Product Name";
            dgvData.Columns[2].HeaderText = "Category";
            dgvData.Columns[3].HeaderText = "Purchasing Price (Rp)";
            dgvData.Columns[3].DefaultCellStyle.Format = "#,##0";
            dgvData.Columns[4].HeaderText = "Stock";
            dgvData.AllowUserToAddRows = false;
            dgvData.ReadOnly = true;
            dgvData.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Ensure the column has valid numeric values before summing
            decimal total = dgvData.Rows.Cast<DataGridViewRow>()
                             .Where(row => !row.IsNewRow && row.Cells[4].Value != null) // Skip new row and null values
                             .Sum(row => Convert.ToDecimal(row.Cells[4].Value)); // Convert values to decimal and sum them

            lblTotal.Text = total.ToString(); // Display the sum in the label, formatted to 2 decimal places
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            Connection();
            LoadData();
            ShowData();

            nudStock.Maximum = 99999;
            nudStock.Increment = 10;
            nudStock.Minimum = 0; 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblProductID.Text) ||
         string.IsNullOrWhiteSpace(lblProductName.Text) ||
         string.IsNullOrWhiteSpace(lblCategory.Text) ||
         string.IsNullOrWhiteSpace(lblPurchasingPrice.Text))
            {
                MessageBox.Show("All fields must be filled before adding stock.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadData();
            dr = ds.Tables["Inventory"].Rows.Find(lblProductID.Text);
            if (dr == null)
            {
                dr = ds.Tables["Inventory"].NewRow();
                dr[0] = lblProductID.Text;
                dr[1] = lblProductName.Text;
                dr[2] = lblCategory.Text;
                dr[3] = lblPurchasingPrice.Text;
                dr[4] = nudStock.Value;
                ds.Tables["Inventory"].Rows.Add(dr);
                UpdateData();
                MessageBox.Show("Product ID Stock " + lblProductID.Text + " has been added.", "Add Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Empty();
            }
            else
            {
                MessageBox.Show("Product ID Stock " + lblProductID.Text + " exists in database.", "Add Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Empty();
            }
            LoadData();
            ShowData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblProductID.Text) ||
        string.IsNullOrWhiteSpace(lblProductName.Text) ||
        string.IsNullOrWhiteSpace(lblCategory.Text) ||
        string.IsNullOrWhiteSpace(lblPurchasingPrice.Text))
            {
                MessageBox.Show("All fields must be filled before editing stock.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadData();
            dr = ds.Tables["Inventory"].Rows.Find(lblProductID.Text);
            if (dr != null)
            {
                dr[1] = lblProductName.Text;
                dr[2] = lblCategory.Text;
                dr[3] = lblPurchasingPrice.Text;
                dr[4] = nudStock.Value;
                UpdateData();
                MessageBox.Show("Product ID Stock " + lblProductID.Text + " has been edited.", "Edit Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Empty();
            }
            else
            {
                MessageBox.Show("Product ID Stock " + lblProductID.Text + " does not exist in database.", "Edit Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Empty();
            }
            LoadData();
            ShowData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblProductID.Text))
            {
                MessageBox.Show("Product ID must be filled before deleting stock.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadData();
            dr = ds.Tables["Inventory"].Rows.Find(lblProductID.Text);
            if (dr != null)
            {
                dr.Delete();
                UpdateData();
                MessageBox.Show("Product ID Stock " + lblProductID.Text + " has been deleted.", "Delete Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Empty();
            }
            else
            {
                MessageBox.Show("Product ID Stock " + lblProductID.Text + " does not exist in database.", "Delete Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Empty();
            }
            LoadData();
            ShowData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Empty();
        }

        private void btnBrowseProduct_Click(object sender, EventArgs e)
        {
            Master.frmBrowseProduct masterBrowseProduct = new Master.frmBrowseProduct(this);
            masterBrowseProduct.Tag = this;
            masterBrowseProduct.ShowDialog();
        }
    }
}
