namespace FitBody.Transaction
{
    partial class frmEquipmentMaintenance
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
            this.btnDelete = new CustomBox.RJControls.RJButton();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new CustomBox.RJControls.RJButton();
            this.rtbMaintenanceDetail = new System.Windows.Forms.RichTextBox();
            this.btnAdd = new CustomBox.RJControls.RJButton();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblCurrentCondition = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblEquipmentName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblEquipmentID = new System.Windows.Forms.Label();
            this.btnBowseEquipment = new FontAwesome.Sharp.IconButton();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.btnBrowseStaff = new FontAwesome.Sharp.IconButton();
            this.label14 = new System.Windows.Forms.Label();
            this.lblLogID = new System.Windows.Forms.Label();
            this.btnBrowseMaintenance = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpMaintainDate = new CustomBox.RJControls.RJDatePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboCondition = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReset = new CustomBox.RJControls.RJButton();
            this.btnUpdate = new CustomBox.RJControls.RJButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.rtbMaintenanceDetail);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.lblCurrentCondition);
            this.groupBox1.Controls.Add(this.lblCategory);
            this.groupBox1.Controls.Add(this.lblEquipmentName);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblEquipmentID);
            this.groupBox1.Controls.Add(this.btnBowseEquipment);
            this.groupBox1.Controls.Add(this.lblStaffName);
            this.groupBox1.Controls.Add(this.lblStaffID);
            this.groupBox1.Controls.Add(this.btnBrowseStaff);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lblLogID);
            this.groupBox1.Controls.Add(this.btnBrowseMaintenance);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpMaintainDate);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(805, 459);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Equipment Maintenance";
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
            this.btnDelete.Location = new System.Drawing.Point(375, 398);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 40);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEdit.IconColor = System.Drawing.Color.Goldenrod;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.IconSize = 32;
            this.btnEdit.Location = new System.Drawing.Point(754, 398);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(40, 40);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(32, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "Maintenance Details";
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
            this.btnClear.Location = new System.Drawing.Point(511, 399);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 40);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.TextColor = System.Drawing.Color.DimGray;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rtbMaintenanceDetail
            // 
            this.rtbMaintenanceDetail.Location = new System.Drawing.Point(36, 330);
            this.rtbMaintenanceDetail.Name = "rtbMaintenanceDetail";
            this.rtbMaintenanceDetail.Size = new System.Drawing.Size(292, 96);
            this.rtbMaintenanceDetail.TabIndex = 34;
            this.rtbMaintenanceDetail.Text = "";
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
            this.btnAdd.Location = new System.Drawing.Point(615, 398);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 40);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Confirm";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label19.Location = new System.Drawing.Point(586, 291);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(120, 19);
            this.label19.TabIndex = 33;
            this.label19.Text = "Current Condition";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label18.Location = new System.Drawing.Point(310, 291);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 19);
            this.label18.TabIndex = 32;
            this.label18.Text = "Category";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label17.Location = new System.Drawing.Point(32, 291);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(116, 19);
            this.label17.TabIndex = 23;
            this.label17.Text = "Equipment Name";
            // 
            // lblCurrentCondition
            // 
            this.lblCurrentCondition.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCurrentCondition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrentCondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCurrentCondition.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentCondition.Location = new System.Drawing.Point(590, 258);
            this.lblCurrentCondition.Name = "lblCurrentCondition";
            this.lblCurrentCondition.Size = new System.Drawing.Size(179, 30);
            this.lblCurrentCondition.TabIndex = 31;
            this.lblCurrentCondition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCategory
            // 
            this.lblCategory.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(314, 258);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(179, 30);
            this.lblCategory.TabIndex = 30;
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEquipmentName
            // 
            this.lblEquipmentName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEquipmentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEquipmentName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEquipmentName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipmentName.Location = new System.Drawing.Point(36, 258);
            this.lblEquipmentName.Name = "lblEquipmentName";
            this.lblEquipmentName.Size = new System.Drawing.Size(179, 30);
            this.lblEquipmentName.TabIndex = 29;
            this.lblEquipmentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(32, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 19);
            this.label10.TabIndex = 28;
            this.label10.Text = "Select Equipment";
            // 
            // lblEquipmentID
            // 
            this.lblEquipmentID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEquipmentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEquipmentID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEquipmentID.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipmentID.Location = new System.Drawing.Point(36, 211);
            this.lblEquipmentID.Name = "lblEquipmentID";
            this.lblEquipmentID.Size = new System.Drawing.Size(179, 30);
            this.lblEquipmentID.TabIndex = 27;
            this.lblEquipmentID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBowseEquipment
            // 
            this.btnBowseEquipment.IconChar = FontAwesome.Sharp.IconChar.Display;
            this.btnBowseEquipment.IconColor = System.Drawing.Color.Black;
            this.btnBowseEquipment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBowseEquipment.IconSize = 32;
            this.btnBowseEquipment.Location = new System.Drawing.Point(225, 206);
            this.btnBowseEquipment.Name = "btnBowseEquipment";
            this.btnBowseEquipment.Size = new System.Drawing.Size(54, 37);
            this.btnBowseEquipment.TabIndex = 26;
            this.btnBowseEquipment.UseVisualStyleBackColor = true;
            this.btnBowseEquipment.Click += new System.EventHandler(this.btnBowseEquipment_Click);
            // 
            // lblStaffName
            // 
            this.lblStaffName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblStaffName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStaffName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStaffName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName.Location = new System.Drawing.Point(314, 119);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(179, 30);
            this.lblStaffName.TabIndex = 18;
            this.lblStaffName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStaffID
            // 
            this.lblStaffID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblStaffID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStaffID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStaffID.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffID.Location = new System.Drawing.Point(314, 75);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(179, 30);
            this.lblStaffID.TabIndex = 17;
            this.lblStaffID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBrowseStaff
            // 
            this.btnBrowseStaff.IconChar = FontAwesome.Sharp.IconChar.Display;
            this.btnBrowseStaff.IconColor = System.Drawing.Color.Black;
            this.btnBrowseStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBrowseStaff.IconSize = 32;
            this.btnBrowseStaff.Location = new System.Drawing.Point(503, 70);
            this.btnBrowseStaff.Name = "btnBrowseStaff";
            this.btnBrowseStaff.Size = new System.Drawing.Size(54, 37);
            this.btnBrowseStaff.TabIndex = 16;
            this.btnBrowseStaff.UseVisualStyleBackColor = true;
            this.btnBrowseStaff.Click += new System.EventHandler(this.btnBrowseStaff_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(310, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(165, 19);
            this.label14.TabIndex = 15;
            this.label14.Text = "Performed by (Staff ID)";
            // 
            // lblLogID
            // 
            this.lblLogID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLogID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLogID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLogID.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogID.Location = new System.Drawing.Point(36, 75);
            this.lblLogID.Name = "lblLogID";
            this.lblLogID.Size = new System.Drawing.Size(179, 30);
            this.lblLogID.TabIndex = 14;
            this.lblLogID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBrowseMaintenance
            // 
            this.btnBrowseMaintenance.IconChar = FontAwesome.Sharp.IconChar.Display;
            this.btnBrowseMaintenance.IconColor = System.Drawing.Color.Black;
            this.btnBrowseMaintenance.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBrowseMaintenance.IconSize = 32;
            this.btnBrowseMaintenance.Location = new System.Drawing.Point(225, 70);
            this.btnBrowseMaintenance.Name = "btnBrowseMaintenance";
            this.btnBrowseMaintenance.Size = new System.Drawing.Size(54, 37);
            this.btnBrowseMaintenance.TabIndex = 13;
            this.btnBrowseMaintenance.UseVisualStyleBackColor = true;
            this.btnBrowseMaintenance.Click += new System.EventHandler(this.btnBrowseMaintenance_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(32, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Maintenance ID";
            // 
            // dtpMaintainDate
            // 
            this.dtpMaintainDate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtpMaintainDate.BorderSize = 0;
            this.dtpMaintainDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtpMaintainDate.Location = new System.Drawing.Point(590, 70);
            this.dtpMaintainDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpMaintainDate.Name = "dtpMaintainDate";
            this.dtpMaintainDate.Size = new System.Drawing.Size(200, 35);
            this.dtpMaintainDate.SkinColor = System.Drawing.Color.Black;
            this.dtpMaintainDate.TabIndex = 23;
            this.dtpMaintainDate.TextColor = System.Drawing.Color.GreenYellow;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(586, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 19);
            this.label9.TabIndex = 24;
            this.label9.Text = "Maintenance Date";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboCondition);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Location = new System.Drawing.Point(23, 494);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 111);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Equipment Condition";
            // 
            // cboCondition
            // 
            this.cboCondition.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCondition.FormattingEnabled = true;
            this.cboCondition.Location = new System.Drawing.Point(20, 55);
            this.cboCondition.Name = "cboCondition";
            this.cboCondition.Size = new System.Drawing.Size(222, 29);
            this.cboCondition.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(17, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "Update Condition";
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
            this.btnReset.Location = new System.Drawing.Point(269, 44);
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
            this.btnUpdate.Location = new System.Drawing.Point(375, 44);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 40);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextColor = System.Drawing.Color.White;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(150, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(481, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(721, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(162, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(169, 429);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "*";
            // 
            // frmEquipmentMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 678);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEquipmentMaintenance";
            this.Text = "Equipment Maintenance";
            this.Load += new System.EventHandler(this.frmEquipmentMaintenance_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label9;
        public CustomBox.RJControls.RJDatePicker dtpMaintainDate;
        public System.Windows.Forms.Label lblLogID;
        public FontAwesome.Sharp.IconButton btnBrowseMaintenance;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblCurrentCondition;
        public System.Windows.Forms.Label lblCategory;
        public System.Windows.Forms.Label lblEquipmentName;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label lblEquipmentID;
        public FontAwesome.Sharp.IconButton btnBowseEquipment;
        public System.Windows.Forms.Label lblStaffName;
        public System.Windows.Forms.Label lblStaffID;
        public FontAwesome.Sharp.IconButton btnBrowseStaff;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label19;
        public System.Windows.Forms.Label label18;
        public FontAwesome.Sharp.IconButton btnEdit;
        public CustomBox.RJControls.RJButton btnClear;
        public CustomBox.RJControls.RJButton btnAdd;
        public CustomBox.RJControls.RJButton btnDelete;
        public System.Windows.Forms.GroupBox groupBox2;
        public CustomBox.RJControls.RJButton btnReset;
        public CustomBox.RJControls.RJButton btnUpdate;
        public System.Windows.Forms.ComboBox cboCondition;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.RichTextBox rtbMaintenanceDetail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
    }
}