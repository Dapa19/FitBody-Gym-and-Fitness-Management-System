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
    public partial class frmBrowseClasses : Form
    {
        public frmBrowseClasses()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        Transaction.frmClasses transactionClasses;
        public frmBrowseClasses(Transaction.frmClasses transactionClasses)
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
            query = "SELECT CH.classID, CH.className, S.staffID, S.staffName, CH.scheduleDate, CH.startTime, CH.endTime FROM ClassHeader CH INNER JOIN Staff S ON CH.staffID = S.staffID";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "joinPurchaseHeaderVendor");
            dc[0] = ds.Tables["joinPurchaseHeaderVendor"].Columns[0];
            ds.Tables["joinPurchaseHeaderVendor"].PrimaryKey = dc;
        }

        private void FilterData()
        {
            ds = new DataSet();
            query = "SELECT CH.classID, CH.className, S.staffID, S.staffName, CH.scheduleDate, CH.startTime, CH.endTime FROM ClassHeader CH INNER JOIN Staff S ON CH.staffID = S.staffI WHERE CH.scheduleDate BETWEEN '" + dtpFrom.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpTo.Value.ToString("yyyy-MM-dd") + "'";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "joinPurchaseHeaderVendor");
            dc[0] = ds.Tables["joinPurchaseHeaderVendor"].Columns[0];
            ds.Tables["joinPurchaseHeaderVendor"].PrimaryKey = dc;
        }

        private void TampilData()
        {
            dgvData.DataSource = ds.Tables["joinPurchaseHeaderVendor"];
            dgvData.Columns[0].HeaderText = "Class ID";
            dgvData.Columns[1].HeaderText = "Class Name";
            dgvData.Columns[2].HeaderText = "Staff ID";
            dgvData.Columns[3].HeaderText = "Staff Name";
            dgvData.Columns[4].HeaderText = "Schedule Date";
            dgvData.Columns[5].HeaderText = "Start Time";
            dgvData.Columns[6].HeaderText = "End Time";

            dgvData.AllowUserToAddRows = false;
            dgvData.ReadOnly = true;
            dgvData.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            lblTotal.Text = dgvData.RowCount.ToString();
        }

        private void frmBrowseClasses_Load(object sender, EventArgs e)
        {
            dtpFrom.CustomFormat = "dd MMMM yyyy";
            dtpFrom.Format = DateTimePickerFormat.Custom;
            dtpFrom.Value = DateTime.Now.AddDays(-30);

            dtpTo.CustomFormat = "dd MMMM yyyy";
            dtpTo.Format = DateTimePickerFormat.Custom;
            dtpTo.Value = DateTime.Now;

            Connection();
            LoadData();
            TampilData();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            FilterData();
            TampilData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadData();
            TampilData();

            dtpTo.CustomFormat = "dd MMMM yyyy";
            dtpTo.Format = DateTimePickerFormat.Custom;
            dtpTo.Value = DateTime.Now;

            dtpFrom.CustomFormat = "dd MMMM yyyy";
            dtpFrom.Format = DateTimePickerFormat.Custom;
            dtpFrom.Value = DateTime.Now.AddDays(-30);
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Tag == transactionClasses)
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvData.Rows.Count)
                {

                    // Ambil row yang di-double-click
                    DataGridViewRow selectedRow = dgvData.Rows[e.RowIndex];

                    transactionClasses.lblClassID.Text = selectedRow.Cells[0].Value?.ToString() ?? string.Empty;
                    transactionClasses.lblStaffID.Text = selectedRow.Cells[2].Value?.ToString() ?? string.Empty;
                    transactionClasses.txtClassName.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
                    transactionClasses.lblStaffName.Text = selectedRow.Cells[3].Value?.ToString() ?? string.Empty;

                    DateTime scheduleDate = Convert.ToDateTime(dgvData.Rows[e.RowIndex].Cells[4].Value);
                    transactionClasses.dtpSchedule.Value = scheduleDate;

                    transactionClasses.txtStart.Text = selectedRow.Cells[5].Value?.ToString() ?? string.Empty;
                    transactionClasses.txtEnd.Text = selectedRow.Cells[6].Value?.ToString() ?? string.Empty;

                }
                this.Close();
            }
        }
    }
}
