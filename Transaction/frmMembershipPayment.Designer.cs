namespace FitBody.Transaction
{
    partial class frmMembershipPayment
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.lblMemberDescription = new System.Windows.Forms.Label();
            this.btnDelete = new CustomBox.RJControls.RJButton();
            this.btnClear = new CustomBox.RJControls.RJButton();
            this.dtpPaymentDate = new CustomBox.RJControls.RJDatePicker();
            this.btnAdd = new CustomBox.RJControls.RJButton();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.cboPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBrowseMember = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPaymentID = new System.Windows.Forms.Label();
            this.btnBrowsePayment = new FontAwesome.Sharp.IconButton();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReset = new CustomBox.RJControls.RJButton();
            this.btnUpdate = new CustomBox.RJControls.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCurrentExpiry = new System.Windows.Forms.Label();
            this.dtpExpiryDate = new CustomBox.RJControls.RJDatePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCalculator = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.lblMemberDescription);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.dtpPaymentDate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lblMemberID);
            this.groupBox1.Controls.Add(this.cboPaymentMethod);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnBrowseMember);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblPaymentID);
            this.groupBox1.Controls.Add(this.btnBrowsePayment);
            this.groupBox1.Controls.Add(this.nudAmount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(22, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(805, 388);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Membership Payment";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(32, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 19);
            this.label9.TabIndex = 28;
            this.label9.Text = "Payment Date";
            // 
            // btnEdit
            // 
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEdit.IconColor = System.Drawing.Color.Goldenrod;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.IconSize = 32;
            this.btnEdit.Location = new System.Drawing.Point(741, 324);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(40, 40);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblMemberDescription
            // 
            this.lblMemberDescription.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMemberDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMemberDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMemberDescription.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberDescription.Location = new System.Drawing.Point(535, 112);
            this.lblMemberDescription.Name = "lblMemberDescription";
            this.lblMemberDescription.Size = new System.Drawing.Size(179, 45);
            this.lblMemberDescription.TabIndex = 18;
            this.lblMemberDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkRed;
            this.btnDelete.BackgroundColor = System.Drawing.Color.DarkRed;
            this.btnDelete.BorderColor = System.Drawing.Color.Red;
            this.btnDelete.BorderRadius = 5;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(36, 324);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 40);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightGray;
            this.btnClear.BackgroundColor = System.Drawing.Color.LightGray;
            this.btnClear.BorderColor = System.Drawing.Color.Red;
            this.btnClear.BorderRadius = 5;
            this.btnClear.BorderSize = 0;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.DimGray;
            this.btnClear.Location = new System.Drawing.Point(498, 325);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 40);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.TextColor = System.Drawing.Color.DimGray;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtpPaymentDate.BorderSize = 0;
            this.dtpPaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtpPaymentDate.Location = new System.Drawing.Point(36, 156);
            this.dtpPaymentDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(200, 35);
            this.dtpPaymentDate.SkinColor = System.Drawing.Color.Black;
            this.dtpPaymentDate.TabIndex = 27;
            this.dtpPaymentDate.TextColor = System.Drawing.Color.GreenYellow;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.BackgroundColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.BorderColor = System.Drawing.Color.Red;
            this.btnAdd.BorderRadius = 5;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(602, 324);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 40);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Confirm";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblMemberID
            // 
            this.lblMemberID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMemberID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMemberID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMemberID.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberID.Location = new System.Drawing.Point(535, 68);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(179, 30);
            this.lblMemberID.TabIndex = 17;
            this.lblMemberID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboPaymentMethod
            // 
            this.cboPaymentMethod.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPaymentMethod.FormattingEnabled = true;
            this.cboPaymentMethod.Location = new System.Drawing.Point(36, 256);
            this.cboPaymentMethod.Name = "cboPaymentMethod";
            this.cboPaymentMethod.Size = new System.Drawing.Size(222, 29);
            this.cboPaymentMethod.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(33, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Payment Method";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(288, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "E.g. 250000";
            // 
            // btnBrowseMember
            // 
            this.btnBrowseMember.IconChar = FontAwesome.Sharp.IconChar.Display;
            this.btnBrowseMember.IconColor = System.Drawing.Color.Black;
            this.btnBrowseMember.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBrowseMember.IconSize = 32;
            this.btnBrowseMember.Location = new System.Drawing.Point(724, 63);
            this.btnBrowseMember.Name = "btnBrowseMember";
            this.btnBrowseMember.Size = new System.Drawing.Size(54, 37);
            this.btnBrowseMember.TabIndex = 16;
            this.btnBrowseMember.UseVisualStyleBackColor = true;
            this.btnBrowseMember.Click += new System.EventHandler(this.btnBrowseMember_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(531, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "From Member : ";
            // 
            // lblPaymentID
            // 
            this.lblPaymentID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPaymentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPaymentID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPaymentID.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentID.Location = new System.Drawing.Point(36, 75);
            this.lblPaymentID.Name = "lblPaymentID";
            this.lblPaymentID.Size = new System.Drawing.Size(179, 30);
            this.lblPaymentID.TabIndex = 14;
            this.lblPaymentID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBrowsePayment
            // 
            this.btnBrowsePayment.IconChar = FontAwesome.Sharp.IconChar.Display;
            this.btnBrowsePayment.IconColor = System.Drawing.Color.Black;
            this.btnBrowsePayment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBrowsePayment.IconSize = 32;
            this.btnBrowsePayment.Location = new System.Drawing.Point(225, 70);
            this.btnBrowsePayment.Name = "btnBrowsePayment";
            this.btnBrowsePayment.Size = new System.Drawing.Size(54, 37);
            this.btnBrowsePayment.TabIndex = 13;
            this.btnBrowsePayment.UseVisualStyleBackColor = true;
            this.btnBrowsePayment.Click += new System.EventHandler(this.btnBrowsePayment_Click);
            // 
            // nudAmount
            // 
            this.nudAmount.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAmount.Location = new System.Drawing.Point(292, 256);
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(195, 28);
            this.nudAmount.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(32, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Payment ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(288, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Amount (Rp)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblCurrentExpiry);
            this.groupBox2.Controls.Add(this.dtpExpiryDate);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(22, 434);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 199);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Expiry Date";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightGray;
            this.btnReset.BackgroundColor = System.Drawing.Color.LightGray;
            this.btnReset.BorderColor = System.Drawing.Color.Red;
            this.btnReset.BorderRadius = 5;
            this.btnReset.BorderSize = 0;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.DimGray;
            this.btnReset.Location = new System.Drawing.Point(251, 129);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(98, 40);
            this.btnReset.TabIndex = 29;
            this.btnReset.Text = "Reset";
            this.btnReset.TextColor = System.Drawing.Color.DimGray;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Goldenrod;
            this.btnUpdate.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.btnUpdate.BorderColor = System.Drawing.Color.Red;
            this.btnUpdate.BorderRadius = 5;
            this.btnUpdate.BorderSize = 0;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(357, 129);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 40);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextColor = System.Drawing.Color.White;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(283, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "Update Expiry Date";
            // 
            // lblCurrentExpiry
            // 
            this.lblCurrentExpiry.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCurrentExpiry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrentExpiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCurrentExpiry.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentExpiry.Location = new System.Drawing.Point(36, 75);
            this.lblCurrentExpiry.Name = "lblCurrentExpiry";
            this.lblCurrentExpiry.Size = new System.Drawing.Size(200, 30);
            this.lblCurrentExpiry.TabIndex = 14;
            this.lblCurrentExpiry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtpExpiryDate.BorderSize = 0;
            this.dtpExpiryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtpExpiryDate.Location = new System.Drawing.Point(287, 68);
            this.dtpExpiryDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(200, 35);
            this.dtpExpiryDate.SkinColor = System.Drawing.Color.Black;
            this.dtpExpiryDate.TabIndex = 29;
            this.dtpExpiryDate.TextColor = System.Drawing.Color.GreenYellow;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(31, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(212, 19);
            this.label12.TabIndex = 6;
            this.label12.Text = "Member Current Expiry Date : ";
            // 
            // btnCalculator
            // 
            this.btnCalculator.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculator.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.btnCalculator.IconColor = System.Drawing.Color.Black;
            this.btnCalculator.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCalculator.IconSize = 32;
            this.btnCalculator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculator.Location = new System.Drawing.Point(591, 674);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Padding = new System.Windows.Forms.Padding(12);
            this.btnCalculator.Size = new System.Drawing.Size(236, 46);
            this.btnCalculator.TabIndex = 34;
            this.btnCalculator.Text = "Membership Calculator";
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(117, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(644, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(156, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 20);
            this.label10.TabIndex = 31;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(386, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "*";
            // 
            // frmMembershipPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 741);
            this.Controls.Add(this.btnCalculator);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMembershipPayment";
            this.Text = "Membership Payment";
            this.Load += new System.EventHandler(this.frmMembershipPayment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label lblMemberID;
        public FontAwesome.Sharp.IconButton btnBrowseMember;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lblPaymentID;
        public FontAwesome.Sharp.IconButton btnBrowsePayment;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.NumericUpDown nudAmount;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblMemberDescription;
        public System.Windows.Forms.Label label9;
        public CustomBox.RJControls.RJDatePicker dtpPaymentDate;
        public System.Windows.Forms.ComboBox cboPaymentMethod;
        public System.Windows.Forms.Label label3;
        public FontAwesome.Sharp.IconButton btnEdit;
        public CustomBox.RJControls.RJButton btnDelete;
        public CustomBox.RJControls.RJButton btnClear;
        public CustomBox.RJControls.RJButton btnAdd;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label lblCurrentExpiry;
        public System.Windows.Forms.Label label12;
        public CustomBox.RJControls.RJButton btnUpdate;
        public System.Windows.Forms.Label label2;
        public CustomBox.RJControls.RJDatePicker dtpExpiryDate;
        public CustomBox.RJControls.RJButton btnReset;
        public FontAwesome.Sharp.IconButton btnCalculator;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
    }
}