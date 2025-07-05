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
    public partial class frmClassesReport : Form
    {
        public frmClassesReport()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        frmMain mainForm;
        public frmClassesReport(frmMain mainForm)
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

        private void LoadDataClasses()
        {
            ds = new DataSet();
            query = "SELECT CH.classID, CH.className, CH.staffID, S.staffName, CH.scheduleDate, CH.startTime, CH.endTime FROM ClassHeader CH INNER JOIN Staff S ON CH.staffID = S.staffID";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Classes");
        }

        private void frmClassesReport_Load(object sender, EventArgs e)
        {
            Connection();
            LoadDataClasses();

            dtpTo.CustomFormat = "dd MMMM yyyy";
            dtpTo.Format = DateTimePickerFormat.Custom;
            dtpTo.Value = DateTime.Now;

            dtpFrom.CustomFormat = "dd MMMM yyyy";
            dtpFrom.Format = DateTimePickerFormat.Custom;
            dtpFrom.Value = DateTime.Now.AddDays(-30);
        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            Report.CrystalReportClass cr = new Report.CrystalReportClass();
            Report.frmCrystalReportViewer viewer = new Report.frmCrystalReportViewer();
            LoadDataClasses();
            cr.SetDataSource(ds);
            viewer.crystalReportViewer1.ReportSource = cr;
            viewer.WindowState = FormWindowState.Maximized;
            viewer.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Report.CrystalReportClass cr = new Report.CrystalReportClass();
            frmCrystalReportViewer viewer = new frmCrystalReportViewer();
            ds = new DataSet();
            query = "SELECT CH.classID, CH.className, CH.staffID, S.staffName, CH.scheduleDate, CH.startTime, CH.endTime FROM ClassHeader CH INNER JOIN Staff S ON CH.staffID = S.staffID WHERE CH.scheduleDate BETWEEN '" + dtpFrom.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpTo.Value.ToString("yyyy-MM-dd") + "'";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Classes");
            cr.SetDataSource(ds);
            viewer.crystalReportViewer1.ReportSource = cr;
            viewer.WindowState = FormWindowState.Maximized;
            viewer.Show();
        }
    }
}
