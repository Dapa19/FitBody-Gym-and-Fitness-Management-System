using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitBody.Additional
{
    public partial class frmMembershipCalculator : Form
    {
        public frmMembershipCalculator()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        Master.frmMember masterMember;
        public frmMembershipCalculator(Master.frmMember masterMember)
        {
            InitializeComponent();

            this.masterMember = masterMember;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        Transaction.frmMembershipPayment transactionPayment;
        public frmMembershipCalculator(Transaction.frmMembershipPayment transactionPayment)
        {
            InitializeComponent();

            this.transactionPayment = transactionPayment;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void txtPriceMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Izinkan angka (0-9), backspace, dan karakter desimal (titik atau koma)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true; // Tolong input yang tidak valid
            }

            // Pastikan hanya satu karakter desimal yang diizinkan
            if ((e.KeyChar == '.' || e.KeyChar == ',') && ((TextBox)sender).Text.Contains(".") || ((TextBox)sender).Text.Contains(","))
            {
                e.Handled = true; // Tolong jika sudah ada karakter desimal
            }
        }

        private void btnCalculateMonthly_Click(object sender, EventArgs e)
        {
            // Validasi input harga
            if (!decimal.TryParse(txtPriceMonth.Text, out decimal price))
            {
                MessageBox.Show("Input only number please.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lanjutkan perhitungan jika input valid
            DateTime startDate = dtpFromMonthly.Value;
            int rangeInMonths = (int)nudRangeMonthly.Value;

            DateTime expiryDate = startDate.AddMonths(rangeInMonths);
            decimal totalPrice = price * rangeInMonths;

            lblHasilTglMonthly.Text = expiryDate.ToShortDateString();
            lblHasilHargaMonthly.Text = totalPrice.ToString("C");

            
        }

        private void frmMembershipCalculator_Load(object sender, EventArgs e)
        {
            dtpFromMonthly.CustomFormat = "dd MMMM yyyy";
            dtpFromMonthly.Format = DateTimePickerFormat.Custom;
            dtpFromMonthly.Value = DateTime.Now;

            dtpFromYearly.CustomFormat = "dd MMMM yyyy";
            dtpFromYearly.Format = DateTimePickerFormat.Custom;
            dtpFromYearly.Value = DateTime.Now;
        }

        private void btnResetMonthly_Click(object sender, EventArgs e)
        {
            dtpFromMonthly.Value = DateTime.Now;
            nudRangeMonthly.Value = 0;
            txtPriceMonth.Text = string.Empty;
            lblHasilTglMonthly.Text = string.Empty;
            lblHasilHargaMonthly.Text= string.Empty;
        }

        private void btnCalculateYearly_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpFromYearly.Value;
            decimal pricePerYear = decimal.Parse(txtPriceperYear.Text);
            int rangeInYears = (int)nudRangeYearly.Value;

            DateTime expiryDate = startDate.AddYears(rangeInYears);
            decimal totalPrice = pricePerYear * rangeInYears;

            lblExpiryDateYearly.Text = expiryDate.ToShortDateString();
            lblTotalPriceYearly.Text = totalPrice.ToString("C");

        }

        private void txtPriceperYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Izinkan angka (0-9), backspace, dan karakter desimal (titik atau koma)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true; // Tolong input yang tidak valid
            }

            // Pastikan hanya satu karakter desimal yang diizinkan
            if ((e.KeyChar == '.' || e.KeyChar == ',') && ((TextBox)sender).Text.Contains(".") || ((TextBox)sender).Text.Contains(","))
            {
                e.Handled = true; // Tolong jika sudah ada karakter desimal
            }
        }

        private void btnResetYearly_Click(object sender, EventArgs e)
        {
            dtpFromYearly.Value = DateTime.Now;
            nudRangeYearly.Value = 0;
            txtPriceperYear.Text = string.Empty;
            lblExpiryDateYearly.Text = string.Empty;
            lblTotalPriceYearly.Text = string.Empty;
        }

        private void btnConfirmMonth_Click(object sender, EventArgs e)
        {
            // Validasi input harga
            if (!decimal.TryParse(txtPriceMonth.Text, out decimal price))
            {
                MessageBox.Show("Input only number please.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lanjutkan perhitungan jika input valid
            DateTime startDate = dtpFromMonthly.Value;
            int rangeInMonths = (int)nudRangeMonthly.Value;

            DateTime expiryDate = startDate.AddMonths(rangeInMonths);
            decimal totalPrice = price * rangeInMonths;

            lblHasilTglMonthly.Text = expiryDate.ToShortDateString();
            lblHasilHargaMonthly.Text = totalPrice.ToString("C");

            if (this.Tag == transactionPayment)
            {
                transactionPayment.dtpExpiryDate.Value = expiryDate;
                transactionPayment.nudAmount.Value = totalPrice;
            }
            if (this.Tag == masterMember)
            {
                masterMember.dtpExpiryDate.Value = expiryDate;
            }
        }

        private void btnConfirmYear_Click(object sender, EventArgs e)
        {

            DateTime startDate = dtpFromYearly.Value;
            decimal pricePerYear = decimal.Parse(txtPriceperYear.Text);
            int rangeInYears = (int)nudRangeYearly.Value;

            DateTime expiryDate = startDate.AddYears(rangeInYears);
            decimal totalPrice = pricePerYear * rangeInYears;

            lblExpiryDateYearly.Text = expiryDate.ToShortDateString();
            lblTotalPriceYearly.Text = totalPrice.ToString("C");

            if (this.Tag == transactionPayment)
            {
                transactionPayment.dtpExpiryDate.Value = expiryDate;
                transactionPayment.nudAmount.Value = totalPrice;
            }
            if (this.Tag == masterMember)
            {
                masterMember.dtpExpiryDate.Value = expiryDate;
            }
        }
    }
}
