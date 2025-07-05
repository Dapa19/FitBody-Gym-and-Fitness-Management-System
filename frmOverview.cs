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
using System.Globalization;

namespace FitBody
{
    public partial class frmOverview : Form
    {
        public frmOverview()
        {
            InitializeComponent();
            LoadDashboardData();
        }

        frmMain mainMenu;
        public frmOverview(frmMain mainMenu)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
        }

        private string connectionString = "Data Source = MSI\\SQLEXPRESS; Initial Catalog = FitBody; Integrated Security = true";

        private void LoadDashboardData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Total Member
                lblTotalMember.Text = ExecuteScalar(connection, "SELECT COUNT(*) FROM Members");

                // Total Equipment
                lblTotalEquipment.Text = ExecuteScalar(connection, "SELECT COUNT(*) FROM Equipment");

                // Total Revenue in Rupiah
                lblTotalRevenue.Text = FormatAsCurrency(ExecuteScalar(connection, "SELECT SUM(amount) FROM MembershipPayments"));

                // Male Member
                lblMaleMember.Text = ExecuteScalar(connection, "SELECT COUNT(*) FROM Members WHERE gender = 'Male'");

                // Female Member
                lblFemaleMember.Text = ExecuteScalar(connection, "SELECT COUNT(*) FROM Members WHERE gender = 'Female'");

                // Equipment Condition
                lblGoodCondition.Text = ExecuteScalar(connection, "SELECT COUNT(*) FROM Equipment WHERE condition = 'Good'");
                lblNeedRepairs.Text = ExecuteScalar(connection, "SELECT COUNT(*) FROM Equipment WHERE condition = 'Need Repairs'");
                lblDefective.Text = ExecuteScalar(connection, "SELECT COUNT(*) FROM Equipment WHERE condition = 'Defective'");

                // Total Staff
                lblTotalStaff.Text = ExecuteScalar(connection, "SELECT COUNT(*) FROM Staff");

                // Total Transaction
                lblTotalTransaction.Text = ExecuteScalar(connection, "SELECT COUNT(*) FROM MembershipPayments");

                lblTotalStock.Text = ExecuteScalar(connection, "SELECT SUM(qty) AS TotalStock FROM Inventory");

                // Load Current Transaction into DataGridView
                LoadCurrentTransaction(connection);

                LoadTotalRevenueByPaymentMethod();

            }
        }

        private void LoadCurrentTransaction(SqlConnection connection)
        {
            string query = "SELECT paymentID, memberID, paymentDate, amount FROM MembershipPayments ORDER BY paymentDate DESC";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Set DataSource DataGridView
                dgvData.DataSource = dataTable;

                // Custom header column
                dgvData.Columns[0].HeaderText = "Transaction ID";
                dgvData.Columns[1].HeaderText = "Member ID";
                dgvData.Columns[2].HeaderText = "Payment Date";
                dgvData.Columns[3].HeaderText = "Amount (Rp)";

                // Fill mode untuk memenuhi lebar DataGridView
                dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Atur alignment teks header ke tengah
                foreach (DataGridViewColumn column in dgvData.Columns)
                {
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                // Atur format kolom Amount untuk mata uang
                dgvData.Columns[3].DefaultCellStyle.Format = "C";
                dgvData.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                // Optional: Sesuaikan tinggi baris
                dgvData.RowTemplate.Height = 30;

                // Optional: Atur warna header
                dgvData.EnableHeadersVisualStyles = false; // Agar custom warna diterapkan
                dgvData.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
                dgvData.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                dgvData.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            }
        }

       

        private string ExecuteScalar(SqlConnection connection, string query)
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                object result = command.ExecuteScalar();
                return result != DBNull.Value ? result.ToString() : "0";
            }
        }

        private string FormatAsCurrency(string value)
        {
            if (decimal.TryParse(value, out decimal amount))
            {
                // Format as Rupiah
                CultureInfo culture = new CultureInfo("id-ID");
                return amount.ToString("C", culture);
            }
            return "Rp0";
        }

        private void LoadTotalRevenueByPaymentMethod(SqlConnection connection)
        {
            try
            {
                // Query untuk mendapatkan Total Revenue berdasarkan metode pembayaran
                string query = @"
            SELECT paymentMethod, SUM(amount) AS TotalRevenue
            FROM MembershipPayments
            GROUP BY paymentMethod";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open(); // Buka koneksi ke database

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Inisialisasi nilai default
                        decimal totalFromCash = 0;
                        decimal totalFromCard = 0;

                        while (reader.Read())
                        {
                            string paymentMethod = reader["paymentMethod"].ToString();
                            decimal totalRevenue = reader["TotalRevenue"] != DBNull.Value
                                ? Convert.ToDecimal(reader["TotalRevenue"])
                                : 0;

                            // Cek metode pembayaran dan set nilai ke label yang sesuai
                            if (paymentMethod == "Cash")
                            {
                                totalFromCash = totalRevenue;
                            }
                            else if (paymentMethod == "Card")
                            {
                                totalFromCard = totalRevenue;
                            }
                        }

                        // Tampilkan hasil ke label
                        lblFromCash.Text = totalFromCash.ToString("C", new System.Globalization.CultureInfo("id-ID"));
                        lblFromCard.Text = totalFromCard.ToString("C", new System.Globalization.CultureInfo("id-ID"));
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("General Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close(); // Pastikan koneksi tertutup setelah selesai
                }
            }
        }

        private void LoadTotalRevenueByPaymentMethod()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Query untuk mendapatkan Total Revenue berdasarkan metode pembayaran
                    string query = @"SELECT paymentMethod, SUM(amount) AS TotalRevenue FROM MembershipPayments GROUP BY paymentMethod";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open(); // Buka koneksi ke database

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Inisialisasi nilai default
                            decimal totalFromCash = 0;
                            decimal totalFromCard = 0;

                            while (reader.Read())
                            {
                                string paymentMethod = reader["paymentMethod"].ToString();
                                decimal totalRevenue = reader["TotalRevenue"] != DBNull.Value
                                    ? Convert.ToDecimal(reader["TotalRevenue"])
                                    : 0;

                                // Cek metode pembayaran dan set nilai ke label yang sesuai
                                if (paymentMethod == "Cash")
                                {
                                    totalFromCash = totalRevenue;
                                }
                                else if (paymentMethod == "Card")
                                {
                                    totalFromCard = totalRevenue;
                                }
                            }

                            // Tampilkan hasil ke label
                            lblFromCash.Text = totalFromCash.ToString("C", new CultureInfo("id-ID"));
                            lblFromCard.Text = totalFromCard.ToString("C", new CultureInfo("id-ID"));
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("General Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }
    }
}
