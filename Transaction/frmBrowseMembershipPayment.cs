using Newtonsoft.Json.Linq;
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

namespace FitBody.Transaction
{
    public partial class frmBrowseMembershipPayment : Form
    {
        public frmBrowseMembershipPayment()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        Transaction.frmMembershipPayment transactionPayment;
        public frmBrowseMembershipPayment(Transaction.frmMembershipPayment transactionPayment)
        {
            InitializeComponent();

            this.transactionPayment = transactionPayment;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        Report.frmInvoice invoice;
        public frmBrowseMembershipPayment(Report.frmInvoice invoice)
        {
            InitializeComponent();

            this.invoice = invoice;

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
            query = "SELECT MP.paymentID, MP.memberID, M.fullName, MP.amount,MP.paymentDate ,MP.paymentMethod, M.expiryDate FROM Members M INNER JOIN MembershipPayments MP ON M.memberID = MP.memberID";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "joinPaymentMember");
            dc[0] = ds.Tables["joinPaymentMember"].Columns[0];
            ds.Tables["joinPaymentMember"].PrimaryKey = dc;
        }

        private void FilterData()
        {
            ds = new DataSet();
            query = "SELECT MP.paymentID, MP.memberID, M.fullName, MP.amount,MP.paymentDate ,MP.paymentMethod, M.expiryDate FROM Members M INNER JOIN MembershipPayments MP ON M.memberID = MP.memberID WHERE MP.paymentDate BETWEEN '" + dtpFrom.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpTo.Value.ToString("yyyy-MM-dd") + "'";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "joinPaymentMember");
            dc[0] = ds.Tables["joinPaymentMember"].Columns[0];
            ds.Tables["joinPaymentMember"].PrimaryKey = dc;
        }

        private void ShowData()
        {
            dgvData.DataSource = ds.Tables["joinPaymentMember"];
            dgvData.Columns[0].HeaderText = "Payment ID";
            dgvData.Columns[1].HeaderText = "Member ID";
            dgvData.Columns[2].HeaderText = "Member Name";
            dgvData.Columns[3].HeaderText = "Amount (Rp)";
            dgvData.Columns[4].HeaderText = "Payment Date";
            dgvData.Columns[5].HeaderText = "Payment Method";
            dgvData.Columns[6].HeaderText = "Expiry Date";
            dgvData.AllowUserToAddRows = false;
            dgvData.ReadOnly = true;
            dgvData.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            lblTotalTransaction.Text = dgvData.RowCount.ToString();

            // Menghitung total revenue dari kolom Amount (Rp)
            decimal totalRevenue = 0;
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    totalRevenue += Convert.ToDecimal(row.Cells[3].Value);
                }
            }

            lblTotalRevenue.Text = totalRevenue.ToString("N0");
        }

        private void frmBrowseMembershipPayment_Load(object sender, EventArgs e)
        {
            Connection();
            LoadData();
            ShowData();

            dtpTo.CustomFormat = "dd MMMM yyyy";
            dtpTo.Format = DateTimePickerFormat.Custom;
            dtpTo.Value = DateTime.Now;

            dtpFrom.CustomFormat = "dd MMMM yyyy";
            dtpFrom.Format = DateTimePickerFormat.Custom;
            dtpFrom.Value = DateTime.Now.AddDays(-30);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            FilterData();
            ShowData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadData();
            ShowData();

            dtpTo.CustomFormat = "dd MMMM yyyy";
            dtpTo.Format = DateTimePickerFormat.Custom;
            dtpTo.Value = DateTime.Now;

            dtpFrom.CustomFormat = "dd MMMM yyyy";
            dtpFrom.Format = DateTimePickerFormat.Custom;
            dtpFrom.Value = DateTime.Now.AddDays(-30);
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Tag == transactionPayment)
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvData.Rows.Count)
                {

                    // Ambil row yang di-double-click
                    DataGridViewRow selectedRow = dgvData.Rows[e.RowIndex];

                    transactionPayment.lblPaymentID.Text = selectedRow.Cells[0].Value?.ToString() ?? string.Empty;
                    transactionPayment.lblMemberID.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
                    transactionPayment.lblMemberDescription.Text = selectedRow.Cells[2].Value?.ToString() ?? string.Empty;
                    transactionPayment.nudAmount.Text = selectedRow.Cells[3].Value?.ToString() ?? string.Empty;

                    DateTime paymentDate = Convert.ToDateTime(dgvData.Rows[e.RowIndex].Cells[4].Value);
                    transactionPayment.dtpPaymentDate.Value = paymentDate;

                    string paymentMethod = selectedRow.Cells[5].Value?.ToString() ?? string.Empty;
                    transactionPayment.SelectedPayment = paymentMethod;

                    DateTime expiryDate = Convert.ToDateTime(dgvData.Rows[e.RowIndex].Cells[6].Value);
                    transactionPayment.lblCurrentExpiry.Text = expiryDate.ToString("D");

                    transactionPayment.dtpExpiryDate.Value = expiryDate;

                }
                this.Close();
            }
            else if (this.Tag == invoice)
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvData.Rows.Count)
                {

                    // Ambil row yang di-double-click
                    DataGridViewRow selectedRow = dgvData.Rows[e.RowIndex];

                    invoice.lblPaymentID.Text = selectedRow.Cells[0].Value?.ToString() ?? string.Empty;
                    invoice.lblMemberID.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
                    invoice.lblMemberDescription.Text = selectedRow.Cells[2].Value?.ToString() ?? string.Empty;

                }
                this.Close();
            }
        }
    }
}
