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
    public partial class frmMembershipPayment : Form
    {
        public frmMembershipPayment()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        frmMain mainMenu;
        public frmMembershipPayment(frmMain mainMenu)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
        }

        public string SelectedPayment
        {
            get { return cboPaymentMethod.SelectedItem?.ToString() ?? string.Empty; }
            set
            {
                if (cboPaymentMethod.Items.Contains(value))
                {
                    cboPaymentMethod.SelectedItem = value;
                }
            }
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
            query = "SELECT * FROM MembershipPayments WHERE paymentID IN (SELECT MAX(paymentID) FROM MembershipPayments) ORDER BY paymentID DESC";
            cmd = new SqlCommand(query, con);
            dl = cmd.ExecuteReader();
            dl.Read();

            if (dl.HasRows)
            {
                hitung = Convert.ToInt64(dl[0].ToString().Substring(dl["paymentID"].ToString().Length - 2, 2)) + 1; //2
                string joinstr = "00" + hitung; // 002
                urut = "PAY00000" + joinstr.Substring(joinstr.Length - 2, 2); //PRO0000002
            }
            else
            {
                urut = "PAY0000001";
            }
            dl.Close();
            lblPaymentID.Text = urut;
        }

        private void LoadDataPayment()
        {
            ds = new DataSet();
            query = "SELECT * FROM MembershipPayments";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "MembershipPayments");
            dc[0] = ds.Tables["MembershipPayments"].Columns[0];
            ds.Tables["MembershipPayments"].PrimaryKey = dc;
        }

        private void LoadDataMember()
        {
            ds = new DataSet();
            query = "SELECT * FROM Members";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Members");
            dc[0] = ds.Tables["Members"].Columns[0];
            ds.Tables["Members"].PrimaryKey = dc;
        }

        private void UpdateDataPayment()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds.Tables["MembershipPayments"]);
        }

        private void UpdateDataMember()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds.Tables["Members"]);
        }

        private void Empty()
        {
            AutoID();

            dtpPaymentDate.Value = DateTime.Now;
            cboPaymentMethod.SelectedIndex = -1;
            nudAmount.Value = 0;
            lblMemberID.Text = string.Empty;
            lblMemberDescription.Text = string.Empty;
            lblCurrentExpiry.Text = string.Empty;
        }

        private void frmMembershipPayment_Load(object sender, EventArgs e)
        {
            Connection();
            AutoID();

            cboPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPaymentMethod.Items.Add("Cash");
            cboPaymentMethod.Items.Add("Card");

            dtpPaymentDate.CustomFormat = "dd MMMM yyyy";
            dtpPaymentDate.Format = DateTimePickerFormat.Custom;
            dtpPaymentDate.Value = DateTime.Now;

            dtpExpiryDate.CustomFormat = "dd MMMM yyyy";
            dtpExpiryDate.Format = DateTimePickerFormat.Custom;
            dtpExpiryDate.Value = DateTime.Now;

            nudAmount.Maximum = 9999999999;
            nudAmount.Increment = 500;

            nudAmount.ThousandsSeparator = true;
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(lblPaymentID.Text) ||
                string.IsNullOrWhiteSpace(lblMemberID.Text) ||
                nudAmount.Value <= 0 ||
                cboPaymentMethod.SelectedItem == null)
            {
                MessageBox.Show("All fields must be filled before proceeding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            LoadDataPayment();
            dr = ds.Tables["MembershipPayments"].Rows.Find(lblPaymentID.Text);
            if (dr == null)
            {
                dr = ds.Tables["MembershipPayments"].NewRow();
                dr[0] = lblPaymentID.Text;
                dr[1] = lblMemberID.Text;
                dr[2] = nudAmount.Value;
                dr[3] = dtpPaymentDate.Value;
                dr[4] = cboPaymentMethod.SelectedItem.ToString();
                ds.Tables["MembershipPayments"].Rows.Add(dr);
                UpdateDataPayment();
                MessageBox.Show("Payment ID " + lblPaymentID.Text + " has been added.", "Add Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Empty();
            }
            else
            {
                MessageBox.Show("Payment ID " + lblPaymentID.Text + " exists in the database.", "Add Payment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Empty();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            LoadDataPayment();
            dr = ds.Tables["MembershipPayments"].Rows.Find(lblPaymentID.Text);
            if (dr != null)
            {
                dr[1] = lblMemberID.Text;
                dr[2] = nudAmount.Value;
                dr[3] = dtpPaymentDate.Value;
                dr[4] = cboPaymentMethod.SelectedItem.ToString();
                UpdateDataPayment();
                MessageBox.Show("Payment ID " + lblPaymentID.Text + " has been edited.", "Edit Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Empty();
            }
            else
            {
                MessageBox.Show("Payment ID " + lblPaymentID.Text + " does not exist in the database.", "Edit Payment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Empty();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblPaymentID.Text))
            {
                MessageBox.Show("Payment ID must be filled before deleting.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadDataPayment();
            dr = ds.Tables["MembershipPayments"].Rows.Find(lblPaymentID.Text);
            if (dr != null)
            {
                dr.Delete();
                UpdateDataPayment();
                MessageBox.Show("Payment ID " + lblPaymentID.Text + " has been deleted.", "Delete Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Empty();
            }
            else
            {
                MessageBox.Show("Payment ID " + lblPaymentID.Text + " does not exist in the database.", "Delete Payment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Empty();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Empty();
        }

        private void btnBrowseMember_Click(object sender, EventArgs e)
        {
            Master.frmBrowseMember masterBrowseMember = new Master.frmBrowseMember(this);
            masterBrowseMember.Tag = this;
            masterBrowseMember.ShowDialog();
        }

        private void btnBrowsePayment_Click(object sender, EventArgs e)
        {
            Transaction.frmBrowseMembershipPayment transactionBrowsePayment = new Transaction.frmBrowseMembershipPayment(this);
            transactionBrowsePayment.Tag = this;
            transactionBrowsePayment.ShowDialog();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            Additional.frmMembershipCalculator additionCalculator = new Additional.frmMembershipCalculator(this);
            additionCalculator.Tag = this;
            additionCalculator.ShowDialog();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblCurrentExpiry.Text = string.Empty;
            dtpExpiryDate.Value = DateTime.Now;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LoadDataMember();

            dr = ds.Tables["Members"].Rows.Find(lblMemberID.Text);
            if (dr != null) // Jika baris yang dicari berdasarkan lblProductID sudah ada
            {
                dr[8] = dtpExpiryDate.Value;
                UpdateDataMember();
                MessageBox.Show("Member ID " + lblMemberID.Text + " expiry date has been updated.", "Update Expiry Date", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblCurrentExpiry.Text = string.Empty;
                dtpExpiryDate.Value = DateTime.Now;
            }
            else // Jika baris yang dicari berdasarkan lblProductID belum ada
            {
                MessageBox.Show("Member ID " + lblMemberID.Text + " does not exists in database.", "Update Expiry Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblCurrentExpiry.Text = string.Empty;
                dtpExpiryDate.Value = DateTime.Now;
            }

        }
    }
}
