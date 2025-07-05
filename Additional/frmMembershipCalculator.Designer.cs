namespace FitBody.Additional
{
    partial class frmMembershipCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMembershipCalculator));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnResetMonthly = new CustomBox.RJControls.RJButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalculateMonthly = new CustomBox.RJControls.RJButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHasilHargaMonthly = new System.Windows.Forms.Label();
            this.lblHasilTglMonthly = new System.Windows.Forms.Label();
            this.nudRangeMonthly = new System.Windows.Forms.NumericUpDown();
            this.txtPriceMonth = new System.Windows.Forms.TextBox();
            this.dtpFromMonthly = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnResetYearly = new CustomBox.RJControls.RJButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCalculateYearly = new CustomBox.RJControls.RJButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotalPriceYearly = new System.Windows.Forms.Label();
            this.lblExpiryDateYearly = new System.Windows.Forms.Label();
            this.nudRangeYearly = new System.Windows.Forms.NumericUpDown();
            this.txtPriceperYear = new System.Windows.Forms.TextBox();
            this.dtpFromYearly = new System.Windows.Forms.DateTimePicker();
            this.btnConfirmMonth = new CustomBox.RJControls.RJButton();
            this.btnConfirmYear = new CustomBox.RJControls.RJButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRangeMonthly)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRangeYearly)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(108, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Membership Calculator";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 76);
            this.panel1.TabIndex = 21;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FitBody.Properties.Resources.Calc;
            this.pictureBox2.Location = new System.Drawing.Point(46, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConfirmMonth);
            this.groupBox1.Controls.Add(this.btnResetMonthly);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnCalculateMonthly);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblHasilHargaMonthly);
            this.groupBox1.Controls.Add(this.lblHasilTglMonthly);
            this.groupBox1.Controls.Add(this.nudRangeMonthly);
            this.groupBox1.Controls.Add(this.txtPriceMonth);
            this.groupBox1.Controls.Add(this.dtpFromMonthly);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(837, 561);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Monthly Calculator";
            // 
            // btnResetMonthly
            // 
            this.btnResetMonthly.BackColor = System.Drawing.Color.LightGray;
            this.btnResetMonthly.BackgroundColor = System.Drawing.Color.LightGray;
            this.btnResetMonthly.BorderColor = System.Drawing.Color.Red;
            this.btnResetMonthly.BorderRadius = 5;
            this.btnResetMonthly.BorderSize = 0;
            this.btnResetMonthly.FlatAppearance.BorderSize = 0;
            this.btnResetMonthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetMonthly.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetMonthly.ForeColor = System.Drawing.Color.DimGray;
            this.btnResetMonthly.Location = new System.Drawing.Point(574, 498);
            this.btnResetMonthly.Name = "btnResetMonthly";
            this.btnResetMonthly.Size = new System.Drawing.Size(98, 40);
            this.btnResetMonthly.TabIndex = 24;
            this.btnResetMonthly.Text = "Reset";
            this.btnResetMonthly.TextColor = System.Drawing.Color.DimGray;
            this.btnResetMonthly.UseVisualStyleBackColor = false;
            this.btnResetMonthly.Click += new System.EventHandler(this.btnResetMonthly_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(292, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 19);
            this.label6.TabIndex = 27;
            this.label6.Text = "Total Price (Rp) : ";
            // 
            // btnCalculateMonthly
            // 
            this.btnCalculateMonthly.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCalculateMonthly.BackgroundColor = System.Drawing.Color.ForestGreen;
            this.btnCalculateMonthly.BorderColor = System.Drawing.Color.Red;
            this.btnCalculateMonthly.BorderRadius = 5;
            this.btnCalculateMonthly.BorderSize = 0;
            this.btnCalculateMonthly.FlatAppearance.BorderSize = 0;
            this.btnCalculateMonthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateMonthly.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateMonthly.ForeColor = System.Drawing.Color.White;
            this.btnCalculateMonthly.Location = new System.Drawing.Point(678, 498);
            this.btnCalculateMonthly.Name = "btnCalculateMonthly";
            this.btnCalculateMonthly.Size = new System.Drawing.Size(130, 40);
            this.btnCalculateMonthly.TabIndex = 23;
            this.btnCalculateMonthly.Text = "Calculate";
            this.btnCalculateMonthly.TextColor = System.Drawing.Color.White;
            this.btnCalculateMonthly.UseVisualStyleBackColor = false;
            this.btnCalculateMonthly.Click += new System.EventHandler(this.btnCalculateMonthly_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(48, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "Expiry Date : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(504, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "Price per Month (Rp) : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(292, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "How many months : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(48, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "From Date : ";
            // 
            // lblHasilHargaMonthly
            // 
            this.lblHasilHargaMonthly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHasilHargaMonthly.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasilHargaMonthly.Location = new System.Drawing.Point(296, 153);
            this.lblHasilHargaMonthly.Name = "lblHasilHargaMonthly";
            this.lblHasilHargaMonthly.Size = new System.Drawing.Size(187, 34);
            this.lblHasilHargaMonthly.TabIndex = 4;
            this.lblHasilHargaMonthly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHasilTglMonthly
            // 
            this.lblHasilTglMonthly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHasilTglMonthly.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasilTglMonthly.Location = new System.Drawing.Point(52, 153);
            this.lblHasilTglMonthly.Name = "lblHasilTglMonthly";
            this.lblHasilTglMonthly.Size = new System.Drawing.Size(200, 34);
            this.lblHasilTglMonthly.TabIndex = 3;
            this.lblHasilTglMonthly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudRangeMonthly
            // 
            this.nudRangeMonthly.Location = new System.Drawing.Point(296, 67);
            this.nudRangeMonthly.Name = "nudRangeMonthly";
            this.nudRangeMonthly.Size = new System.Drawing.Size(166, 28);
            this.nudRangeMonthly.TabIndex = 2;
            // 
            // txtPriceMonth
            // 
            this.txtPriceMonth.Location = new System.Drawing.Point(508, 67);
            this.txtPriceMonth.Name = "txtPriceMonth";
            this.txtPriceMonth.Size = new System.Drawing.Size(200, 28);
            this.txtPriceMonth.TabIndex = 1;
            this.txtPriceMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPriceMonth_KeyPress);
            // 
            // dtpFromMonthly
            // 
            this.dtpFromMonthly.Location = new System.Drawing.Point(52, 67);
            this.dtpFromMonthly.Name = "dtpFromMonthly";
            this.dtpFromMonthly.Size = new System.Drawing.Size(200, 28);
            this.dtpFromMonthly.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 76);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(851, 602);
            this.tabControl1.TabIndex = 23;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(843, 567);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Monthly";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(843, 567);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Yearly";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConfirmYear);
            this.groupBox2.Controls.Add(this.btnResetYearly);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnCalculateYearly);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lblTotalPriceYearly);
            this.groupBox2.Controls.Add(this.lblExpiryDateYearly);
            this.groupBox2.Controls.Add(this.nudRangeYearly);
            this.groupBox2.Controls.Add(this.txtPriceperYear);
            this.groupBox2.Controls.Add(this.dtpFromYearly);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(837, 561);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yearly Calculator";
            // 
            // btnResetYearly
            // 
            this.btnResetYearly.BackColor = System.Drawing.Color.LightGray;
            this.btnResetYearly.BackgroundColor = System.Drawing.Color.LightGray;
            this.btnResetYearly.BorderColor = System.Drawing.Color.Red;
            this.btnResetYearly.BorderRadius = 5;
            this.btnResetYearly.BorderSize = 0;
            this.btnResetYearly.FlatAppearance.BorderSize = 0;
            this.btnResetYearly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetYearly.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetYearly.ForeColor = System.Drawing.Color.DimGray;
            this.btnResetYearly.Location = new System.Drawing.Point(573, 496);
            this.btnResetYearly.Name = "btnResetYearly";
            this.btnResetYearly.Size = new System.Drawing.Size(98, 40);
            this.btnResetYearly.TabIndex = 24;
            this.btnResetYearly.Text = "Reset";
            this.btnResetYearly.TextColor = System.Drawing.Color.DimGray;
            this.btnResetYearly.UseVisualStyleBackColor = false;
            this.btnResetYearly.Click += new System.EventHandler(this.btnResetYearly_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(292, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 19);
            this.label7.TabIndex = 27;
            this.label7.Text = "Total Price (Rp) : ";
            // 
            // btnCalculateYearly
            // 
            this.btnCalculateYearly.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCalculateYearly.BackgroundColor = System.Drawing.Color.ForestGreen;
            this.btnCalculateYearly.BorderColor = System.Drawing.Color.Red;
            this.btnCalculateYearly.BorderRadius = 5;
            this.btnCalculateYearly.BorderSize = 0;
            this.btnCalculateYearly.FlatAppearance.BorderSize = 0;
            this.btnCalculateYearly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateYearly.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateYearly.ForeColor = System.Drawing.Color.White;
            this.btnCalculateYearly.Location = new System.Drawing.Point(677, 496);
            this.btnCalculateYearly.Name = "btnCalculateYearly";
            this.btnCalculateYearly.Size = new System.Drawing.Size(130, 40);
            this.btnCalculateYearly.TabIndex = 23;
            this.btnCalculateYearly.Text = "Calculate";
            this.btnCalculateYearly.TextColor = System.Drawing.Color.White;
            this.btnCalculateYearly.UseVisualStyleBackColor = false;
            this.btnCalculateYearly.Click += new System.EventHandler(this.btnCalculateYearly_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(48, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 19);
            this.label8.TabIndex = 26;
            this.label8.Text = "Expiry Date : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(504, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 19);
            this.label9.TabIndex = 25;
            this.label9.Text = "Price per Year (Rp) : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(292, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 19);
            this.label10.TabIndex = 24;
            this.label10.Text = "How many Year : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(48, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 19);
            this.label11.TabIndex = 23;
            this.label11.Text = "From Date : ";
            // 
            // lblTotalPriceYearly
            // 
            this.lblTotalPriceYearly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalPriceYearly.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPriceYearly.Location = new System.Drawing.Point(296, 153);
            this.lblTotalPriceYearly.Name = "lblTotalPriceYearly";
            this.lblTotalPriceYearly.Size = new System.Drawing.Size(187, 34);
            this.lblTotalPriceYearly.TabIndex = 4;
            this.lblTotalPriceYearly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExpiryDateYearly
            // 
            this.lblExpiryDateYearly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblExpiryDateYearly.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiryDateYearly.Location = new System.Drawing.Point(52, 153);
            this.lblExpiryDateYearly.Name = "lblExpiryDateYearly";
            this.lblExpiryDateYearly.Size = new System.Drawing.Size(200, 34);
            this.lblExpiryDateYearly.TabIndex = 3;
            this.lblExpiryDateYearly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudRangeYearly
            // 
            this.nudRangeYearly.Location = new System.Drawing.Point(296, 67);
            this.nudRangeYearly.Name = "nudRangeYearly";
            this.nudRangeYearly.Size = new System.Drawing.Size(166, 28);
            this.nudRangeYearly.TabIndex = 2;
            // 
            // txtPriceperYear
            // 
            this.txtPriceperYear.Location = new System.Drawing.Point(508, 67);
            this.txtPriceperYear.Name = "txtPriceperYear";
            this.txtPriceperYear.Size = new System.Drawing.Size(200, 28);
            this.txtPriceperYear.TabIndex = 1;
            this.txtPriceperYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPriceperYear_KeyPress);
            // 
            // dtpFromYearly
            // 
            this.dtpFromYearly.Location = new System.Drawing.Point(52, 67);
            this.dtpFromYearly.Name = "dtpFromYearly";
            this.dtpFromYearly.Size = new System.Drawing.Size(200, 28);
            this.dtpFromYearly.TabIndex = 0;
            // 
            // btnConfirmMonth
            // 
            this.btnConfirmMonth.BackColor = System.Drawing.Color.Teal;
            this.btnConfirmMonth.BackgroundColor = System.Drawing.Color.Teal;
            this.btnConfirmMonth.BorderColor = System.Drawing.Color.Red;
            this.btnConfirmMonth.BorderRadius = 5;
            this.btnConfirmMonth.BorderSize = 0;
            this.btnConfirmMonth.FlatAppearance.BorderSize = 0;
            this.btnConfirmMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmMonth.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmMonth.ForeColor = System.Drawing.Color.White;
            this.btnConfirmMonth.Location = new System.Drawing.Point(610, 147);
            this.btnConfirmMonth.Name = "btnConfirmMonth";
            this.btnConfirmMonth.Size = new System.Drawing.Size(98, 40);
            this.btnConfirmMonth.TabIndex = 28;
            this.btnConfirmMonth.Text = "Confirm";
            this.btnConfirmMonth.TextColor = System.Drawing.Color.White;
            this.btnConfirmMonth.UseVisualStyleBackColor = false;
            this.btnConfirmMonth.Click += new System.EventHandler(this.btnConfirmMonth_Click);
            // 
            // btnConfirmYear
            // 
            this.btnConfirmYear.BackColor = System.Drawing.Color.Teal;
            this.btnConfirmYear.BackgroundColor = System.Drawing.Color.Teal;
            this.btnConfirmYear.BorderColor = System.Drawing.Color.Red;
            this.btnConfirmYear.BorderRadius = 5;
            this.btnConfirmYear.BorderSize = 0;
            this.btnConfirmYear.FlatAppearance.BorderSize = 0;
            this.btnConfirmYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmYear.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmYear.ForeColor = System.Drawing.Color.White;
            this.btnConfirmYear.Location = new System.Drawing.Point(610, 147);
            this.btnConfirmYear.Name = "btnConfirmYear";
            this.btnConfirmYear.Size = new System.Drawing.Size(98, 40);
            this.btnConfirmYear.TabIndex = 29;
            this.btnConfirmYear.Text = "Confirm";
            this.btnConfirmYear.TextColor = System.Drawing.Color.White;
            this.btnConfirmYear.UseVisualStyleBackColor = false;
            this.btnConfirmYear.Click += new System.EventHandler(this.btnConfirmYear_Click);
            // 
            // frmMembershipCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 678);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMembershipCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Membership Calculator";
            this.Load += new System.EventHandler(this.frmMembershipCalculator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRangeMonthly)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRangeYearly)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHasilTglMonthly;
        private System.Windows.Forms.NumericUpDown nudRangeMonthly;
        private System.Windows.Forms.DateTimePicker dtpFromMonthly;
        private System.Windows.Forms.Label lblHasilHargaMonthly;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPriceMonth;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public CustomBox.RJControls.RJButton btnResetMonthly;
        public CustomBox.RJControls.RJButton btnCalculateMonthly;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        public CustomBox.RJControls.RJButton btnResetYearly;
        public System.Windows.Forms.Label label7;
        public CustomBox.RJControls.RJButton btnCalculateYearly;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotalPriceYearly;
        private System.Windows.Forms.Label lblExpiryDateYearly;
        private System.Windows.Forms.NumericUpDown nudRangeYearly;
        private System.Windows.Forms.TextBox txtPriceperYear;
        private System.Windows.Forms.DateTimePicker dtpFromYearly;
        public CustomBox.RJControls.RJButton btnConfirmMonth;
        public CustomBox.RJControls.RJButton btnConfirmYear;
    }
}