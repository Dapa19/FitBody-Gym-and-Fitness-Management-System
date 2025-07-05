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

namespace FitBody.Report
{
    public partial class frmMaintenanceReport : Form
    {
        public frmMaintenanceReport()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        frmMain mainForm;
        public frmMaintenanceReport(frmMain mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;

            this.StartPosition = FormStartPosition.CenterScreen;
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

        private void LoadDataMaintenance()
        {
            ds = new DataSet();
            query = "SELECT * FROM MaintenanceEquipment";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "MaintenanceEquipment");
        }

        private void frmMaintenanceReport_Load(object sender, EventArgs e)
        {
            Connection();
            LoadDataMaintenance();

            dtpTo.CustomFormat = "dd MMMM yyyy";
            dtpTo.Format = DateTimePickerFormat.Custom;
            dtpTo.Value = DateTime.Now;

            dtpFrom.CustomFormat = "dd MMMM yyyy";
            dtpFrom.Format = DateTimePickerFormat.Custom;
            dtpFrom.Value = DateTime.Now.AddDays(-30);
        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            Report.CrystalReportMaintenance cr = new Report.CrystalReportMaintenance();
            Report.frmCrystalReportViewer viewer = new Report.frmCrystalReportViewer();
            LoadDataMaintenance();
            cr.SetDataSource(ds);
            viewer.crystalReportViewer1.ReportSource = cr;
            viewer.WindowState = FormWindowState.Maximized;
            viewer.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Report.CrystalReportMaintenance cr = new Report.CrystalReportMaintenance();
            frmCrystalReportViewer viewer = new frmCrystalReportViewer();
            ds = new DataSet();
            query = "SELECT * FROM MaintenanceEquipment WHERE maintenanceDate BETWEEN '" + dtpFrom.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpTo.Value.ToString("yyyy-MM-dd") + "'";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "MaintenanceEquipment");
            cr.SetDataSource(ds);
            viewer.crystalReportViewer1.ReportSource = cr;
            viewer.WindowState = FormWindowState.Maximized;
            viewer.Show();
        }
    }
}
