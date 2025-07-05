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
    public partial class frmBrowseMaintenance : Form
    {
        public frmBrowseMaintenance()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        Transaction.frmEquipmentMaintenance transactionMaintenance;
        public frmBrowseMaintenance(Transaction.frmEquipmentMaintenance transactionMaintenance)
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
            query = "SELECT ME.logID, ME.staffID, S.staffName, ME.maintenanceDate, ME.equipmentID, E.equipmentName, E.category, E.condition, ME.maintenanceDetails FROM MaintenanceEquipment ME INNER JOIN Staff S ON ME.staffID = S.staffID INNER JOIN Equipment E ON ME.equipmentID = E.equipmentID";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "MaintenanceEquipment");
            dc[0] = ds.Tables["MaintenanceEquipment"].Columns[0];
            ds.Tables["MaintenanceEquipment"].PrimaryKey = dc;
        }

        private void FilterData()
        {
            ds = new DataSet();
            query = "SELECT ME.logID, ME.staffID, S.staffName, ME.maintenanceDate, ME.equipmentID, E.equipmentName, E.category, E.condition, ME.maintenanceDetails FROM MaintenanceEquipment ME INNER JOIN Staff S ON ME.staffID = S.staffID INNER JOIN Equipment E ON ME.equipmentID = E.equipmentID WHERE ME.maintenanceDate BETWEEN '" + dtpFrom.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpTo.Value.ToString("yyyy-MM-dd") + "'";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "MaintenanceEquipment");
            dc[0] = ds.Tables["MaintenanceEquipment"].Columns[0];
            ds.Tables["MaintenanceEquipment"].PrimaryKey = dc;
        }

        private void ShowData()
        {
            dgvData.DataSource = ds.Tables["MaintenanceEquipment"];
            dgvData.Columns[0].HeaderText = "Maintenance ID";
            dgvData.Columns[1].HeaderText = "Staff ID";
            dgvData.Columns[2].HeaderText = "Staff Name";
            dgvData.Columns[3].HeaderText = "Maintenance Date";
            dgvData.Columns[4].HeaderText = "Equipment ID";
            dgvData.Columns[5].HeaderText = "Equipment Name";
            dgvData.Columns[6].HeaderText = "Category";
            dgvData.Columns[7].HeaderText = "Condition";
            dgvData.Columns[8].HeaderText = "Maintenance Details";
            dgvData.AllowUserToAddRows = false;
            dgvData.ReadOnly = true;
            dgvData.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            lblTotalTransaction.Text = dgvData.RowCount.ToString();
        }

        private void frmBrowseMaintenance_Load(object sender, EventArgs e)
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
            if (this.Tag == transactionMaintenance)
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvData.Rows.Count)
                {

                    // Ambil row yang di-double-click
                    DataGridViewRow selectedRow = dgvData.Rows[e.RowIndex];

                    dgvData.Columns[0].HeaderText = "Maintenance ID";
                    dgvData.Columns[1].HeaderText = "Staff ID";
                    dgvData.Columns[2].HeaderText = "Staff Name";
                    dgvData.Columns[3].HeaderText = "Maintenance Date";
                    dgvData.Columns[4].HeaderText = "Equipment ID";
                    dgvData.Columns[5].HeaderText = "Equipment Name";
                    dgvData.Columns[6].HeaderText = "Category";
                    dgvData.Columns[7].HeaderText = "Condition";
                    dgvData.Columns[8].HeaderText = "Maintenance Details";

                    transactionMaintenance.lblLogID.Text = selectedRow.Cells[0].Value?.ToString() ?? string.Empty;
                    transactionMaintenance.lblStaffID.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
                    transactionMaintenance.lblStaffName.Text = selectedRow.Cells[2].Value?.ToString() ?? string.Empty;

                    DateTime maintainDate = Convert.ToDateTime(dgvData.Rows[e.RowIndex].Cells[3].Value);
                    transactionMaintenance.dtpMaintainDate.Value = maintainDate;

                    transactionMaintenance.lblEquipmentID.Text = selectedRow.Cells[4].Value?.ToString() ?? string.Empty;
                    transactionMaintenance.lblEquipmentName.Text = selectedRow.Cells[5].Value?.ToString() ?? string.Empty;
                    transactionMaintenance.lblCategory.Text = selectedRow.Cells[6].Value?.ToString() ?? string.Empty;
                    transactionMaintenance.lblCurrentCondition.Text = selectedRow.Cells[7].Value?.ToString() ?? string.Empty;
                    transactionMaintenance.rtbMaintenanceDetail.Text = selectedRow.Cells[8].Value?.ToString() ?? string.Empty;

                }
                this.Close();
            }
        }
    }
}
