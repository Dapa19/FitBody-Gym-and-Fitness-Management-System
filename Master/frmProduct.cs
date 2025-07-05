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
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //Untuk Selected Category Dari Double Click Dgv Row browse Product
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




        frmMain mainMenu;
        public frmProduct(frmMain mainMenu)
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
            query = "SELECT * FROM Product WHERE productID IN (SELECT MAX(productID) FROM Product) ORDER BY productID DESC";
            cmd = new SqlCommand(query, con);
            dl = cmd.ExecuteReader();
            dl.Read();

            if (dl.HasRows)
            {
                hitung = Convert.ToInt64(dl[0].ToString().Substring(dl["productID"].ToString().Length - 2, 2)) + 1; //2
                string joinstr = "00" + hitung; // 002
                urut = "PRO00000" + joinstr.Substring(joinstr.Length - 2, 2); //PRO0000002
            }
            else
            {
                urut = "PRO0000001";
            }
            dl.Close();
            lblProductID.Text = urut;
        }

        private void LoadData()
        {
            ds = new DataSet();
            query = "SELECT * FROM Product";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Product");
            dc[0] = ds.Tables["Product"].Columns[0];
            ds.Tables["Product"].PrimaryKey = dc;
        }

        private void UpdateData()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds.Tables["Product"]);
        }

        private void Empty()
        {
            AutoID();

            txtProductName.Text = string.Empty;
            cboCategory.SelectedIndex = -1;
            nudPurchasingPrice.Value = 0;

            txtProductName.Focus();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            Connection();
            AutoID();

            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.Items.Add("Supplement");
            cboCategory.Items.Add("Fitness Equipment");
            cboCategory.Items.Add("Food & Beverages");
            cboCategory.Items.Add("Gym Accessories");
            cboCategory.Items.Add("Others");

            nudPurchasingPrice.Maximum = 9999999999;
            nudPurchasingPrice.Increment = 500;
            nudPurchasingPrice.Minimum = 0;

            nudPurchasingPrice.ThousandsSeparator = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                LoadData();

                // Validasi input tidak boleh kosong
                if (string.IsNullOrWhiteSpace(lblProductID.Text) ||
                    string.IsNullOrWhiteSpace(txtProductName.Text) ||
                    cboCategory.SelectedItem == null ||
                    nudPurchasingPrice.Value <= 0)
                {
                    MessageBox.Show("Please fill all fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dr = ds.Tables["Product"].Rows.Find(lblProductID.Text);
                if (dr == null)
                {
                    dr = ds.Tables["Product"].NewRow();
                    dr[0] = lblProductID.Text;
                    dr[1] = txtProductName.Text;
                    dr[2] = cboCategory.SelectedItem.ToString();
                    dr[3] = nudPurchasingPrice.Value;
                    ds.Tables["Product"].Rows.Add(dr);

                    UpdateData();
                    MessageBox.Show($"Product ID {lblProductID.Text} has been added.", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Empty();
                }
                else
                {
                    MessageBox.Show($"Product ID {lblProductID.Text} already exists.", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Empty();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string connectionString = "Data Source = MSI\\SQLEXPRESS; Initial Catalog = FitBody; Integrated Security = true";

        private bool IsProductReferenced(string productId)
        {
            bool isReferenced = false;

            string query = "SELECT COUNT(*) FROM Inventory WHERE productID = @ProductID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductID", productId);
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                LoadData();

                if (string.IsNullOrWhiteSpace(txtProductName.Text) ||
                    cboCategory.SelectedItem == null ||
                    nudPurchasingPrice.Value <= 0)
                {
                    MessageBox.Show("Please fill all fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string productId = lblProductID.Text;

                if (IsProductReferenced(productId))
                {
                    MessageBox.Show($"Product ID {productId} cannot be edited because it is referenced in Inventory.", "Edit Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dr = ds.Tables["Product"].Rows.Find(productId);
                if (dr != null)
                {
                    dr[1] = txtProductName.Text;
                    dr[2] = cboCategory.SelectedItem.ToString();
                    dr[3] = nudPurchasingPrice.Value;

                    UpdateData();
                    MessageBox.Show($"Product ID {productId} has been edited.", "Edit Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Empty();
                }
                else
                {
                    MessageBox.Show($"Product ID {productId} does not exist.", "Edit Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Empty();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                LoadData();

                string productId = lblProductID.Text;

                if (IsProductReferenced(productId))
                {
                    MessageBox.Show($"Product ID {productId} cannot be deleted because it is referenced in Inventory.", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dr = ds.Tables["Product"].Rows.Find(productId);
                if (dr != null)
                {
                    var confirmResult = MessageBox.Show($"Are you sure to delete Product ID {productId}?",
                        "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirmResult == DialogResult.Yes)
                    {
                        dr.Delete();
                        UpdateData();
                        MessageBox.Show($"Product ID {productId} has been deleted.", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Empty();
                    }
                }
                else
                {
                    MessageBox.Show($"Product ID {productId} does not exist.", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Empty();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
