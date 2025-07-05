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
    public partial class frmInvoice : Form
    {
        public frmInvoice()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        frmMain mainForm;
        public frmInvoice(frmMain mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private string constr = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=FitBody;Integrated Security=true";

        private void Connection(Action<SqlConnection> action)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    action(con);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void frmInvoice_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowsePayment_Click(object sender, EventArgs e)
        {
            Transaction.frmBrowseMembershipPayment transactionBrowsePayment = new Transaction.frmBrowseMembershipPayment(this);
            transactionBrowsePayment.Tag = this;
            transactionBrowsePayment.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Connection(con =>
            {
                Report.Invoice cr = new Report.Invoice();
                Report.frmCrystalReportViewer viewer = new Report.frmCrystalReportViewer();

                DataSet ds = new DataSet();
                DataTable dt = new DataTable("joinMembershipMember");

                dt.Columns.Add("paymentID", typeof(string));
                dt.Columns.Add("memberID", typeof(string));
                dt.Columns.Add("fullName", typeof(string));
                dt.Columns.Add("amount", typeof(decimal));

                ds.Tables.Add(dt);

                string query = "SELECT MP.paymentID, MP.memberID, M.fullName, MP.amount FROM MembershipPayments MP INNER JOIN Members M ON MP.memberID = M.memberID WHERE MP.paymentID = @paymentID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@paymentID", lblPaymentID.Text);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds, "joinMembershipMember");
                    }
                }

                cr.SetDataSource(ds);
                viewer.crystalReportViewer1.ReportSource = cr;
                viewer.WindowState = FormWindowState.Maximized;
                viewer.Show();
            });
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblPaymentID.Text = string.Empty;
            lblMemberID.Text = string.Empty;
            lblMemberDescription.Text = string.Empty;
        }
    }
}
