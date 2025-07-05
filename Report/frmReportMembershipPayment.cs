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
    public partial class frmReportMembershipPayment : Form
    {
        public frmReportMembershipPayment()
        {
            InitializeComponent();
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

        frmMain mainForm;
        public frmReportMembershipPayment(frmMain mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoadDataMembershipPayment()
        {
            ds = new DataSet();
            query = "SELECT * FROM MembershipPayments" ;
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "MembershipPayment");
        }

        private void frmReportMembershipPayment_Load(object sender, EventArgs e)
        {
            Connection();
            LoadDataMembershipPayment();

            dtpTo.CustomFormat = "dd MMMM yyyy";
            dtpTo.Format = DateTimePickerFormat.Custom;
            dtpTo.Value = DateTime.Now;

            dtpFrom.CustomFormat = "dd MMMM yyyy";
            dtpFrom.Format = DateTimePickerFormat.Custom;
            dtpFrom.Value = DateTime.Now.AddDays(-30);
        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            Report.CrystalReportMembershipPayment cr = new Report.CrystalReportMembershipPayment();
            Report.frmCrystalReportViewer viewer = new Report.frmCrystalReportViewer();
            LoadDataMembershipPayment();
            cr.SetDataSource(ds);
            viewer.crystalReportViewer1.ReportSource = cr;
            viewer.WindowState = FormWindowState.Maximized;
            viewer.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Report.CrystalReportMembershipPayment cr = new Report.CrystalReportMembershipPayment();
            frmCrystalReportViewer viewer = new frmCrystalReportViewer();
            ds = new DataSet();
            query = "SELECT * FROM MembershipPayments WHERE paymentDate BETWEEN '" + dtpFrom.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpTo.Value.ToString("yyyy-MM-dd") + "'";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "MembershipPayment");
            cr.SetDataSource(ds);
            viewer.crystalReportViewer1.ReportSource = cr;
            viewer.WindowState = FormWindowState.Maximized;
            viewer.Show();
        }
    }
}
