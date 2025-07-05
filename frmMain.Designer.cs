namespace FitBody
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlIcon = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.lblTransaction = new System.Windows.Forms.Label();
            this.btnTransaction = new FontAwesome.Sharp.IconButton();
            this.lblClasses = new System.Windows.Forms.Label();
            this.btnClasses = new FontAwesome.Sharp.IconButton();
            this.lblProduct = new System.Windows.Forms.Label();
            this.btnProduct = new FontAwesome.Sharp.IconButton();
            this.lblEquipment = new System.Windows.Forms.Label();
            this.btnEquipment = new FontAwesome.Sharp.IconButton();
            this.lblMember = new System.Windows.Forms.Label();
            this.btnMember = new FontAwesome.Sharp.IconButton();
            this.lblStaff = new System.Windows.Forms.Label();
            this.btnStaff = new FontAwesome.Sharp.IconButton();
            this.lblOverview = new System.Windows.Forms.Label();
            this.btnOverview = new FontAwesome.Sharp.IconButton();
            this.mnuStaff = new CustomBox.RJControls.RJDropdownMenu(this.components);
            this.manageStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffListReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMember = new CustomBox.RJControls.RJDropdownMenu(this.components);
            this.manageMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberListReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEquipment = new CustomBox.RJControls.RJDropdownMenu(this.components);
            this.manageEquipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainEquipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipmentListReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProduct = new CustomBox.RJControls.RJDropdownMenu(this.components);
            this.manageProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productListReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClasses = new CustomBox.RJControls.RJDropdownMenu(this.components);
            this.manageClassesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransaction = new CustomBox.RJControls.RJDropdownMenu(this.components);
            this.membershipPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membershipReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printMembershipReceiptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlOverview = new System.Windows.Forms.Panel();
            this.pnlProduct = new System.Windows.Forms.Panel();
            this.pnlInventory = new System.Windows.Forms.Panel();
            this.pnlStaff = new System.Windows.Forms.Panel();
            this.pnlEquipment = new System.Windows.Forms.Panel();
            this.pnlMember = new System.Windows.Forms.Panel();
            this.pnlMembershipPayment = new System.Windows.Forms.Panel();
            this.pnlClasses = new System.Windows.Forms.Panel();
            this.pnlMaintenanceEquipment = new System.Windows.Forms.Panel();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTitleBar.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.mnuStaff.SuspendLayout();
            this.mnuMember.SuspendLayout();
            this.mnuEquipment.SuspendLayout();
            this.mnuProduct.SuspendLayout();
            this.mnuClasses.SuspendLayout();
            this.mnuTransaction.SuspendLayout();
            this.pnlMaintenanceEquipment.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlIcon
            // 
            this.pnlIcon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlIcon.Controls.Add(this.pictureBox1);
            this.pnlIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlIcon.Location = new System.Drawing.Point(0, 0);
            this.pnlIcon.Name = "pnlIcon";
            this.pnlIcon.Size = new System.Drawing.Size(217, 115);
            this.pnlIcon.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FitBody.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(47, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlTitleBar.Controls.Add(this.btnMinimize);
            this.pnlTitleBar.Controls.Add(this.lblTitle);
            this.pnlTitleBar.Controls.Add(this.btnMaximize);
            this.pnlTitleBar.Controls.Add(this.btnClose);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(217, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(867, 44);
            this.pnlTitleBar.TabIndex = 1;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimize.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 20;
            this.btnMinimize.Location = new System.Drawing.Point(666, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(67, 44);
            this.btnMinimize.TabIndex = 11;
            this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Location = new System.Drawing.Point(9, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(110, 28);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Overview";
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 20;
            this.btnMaximize.Location = new System.Drawing.Point(733, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(67, 44);
            this.btnMaximize.TabIndex = 12;
            this.btnMaximize.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnClose.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 20;
            this.btnClose.Location = new System.Drawing.Point(800, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClose.Size = new System.Drawing.Size(67, 44);
            this.btnClose.TabIndex = 1;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlMenu.Controls.Add(this.btnExit);
            this.pnlMenu.Controls.Add(this.lblTransaction);
            this.pnlMenu.Controls.Add(this.btnTransaction);
            this.pnlMenu.Controls.Add(this.lblClasses);
            this.pnlMenu.Controls.Add(this.btnClasses);
            this.pnlMenu.Controls.Add(this.lblProduct);
            this.pnlMenu.Controls.Add(this.btnProduct);
            this.pnlMenu.Controls.Add(this.lblEquipment);
            this.pnlMenu.Controls.Add(this.btnEquipment);
            this.pnlMenu.Controls.Add(this.lblMember);
            this.pnlMenu.Controls.Add(this.btnMember);
            this.pnlMenu.Controls.Add(this.lblStaff);
            this.pnlMenu.Controls.Add(this.btnStaff);
            this.pnlMenu.Controls.Add(this.lblOverview);
            this.pnlMenu.Controls.Add(this.btnOverview);
            this.pnlMenu.Controls.Add(this.pnlIcon);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(217, 761);
            this.pnlMenu.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 705);
            this.btnExit.Margin = new System.Windows.Forms.Padding(8);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(8);
            this.btnExit.Size = new System.Drawing.Size(217, 56);
            this.btnExit.TabIndex = 13;
            this.btnExit.Tag = "Exit";
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTransaction
            // 
            this.lblTransaction.BackColor = System.Drawing.Color.GreenYellow;
            this.lblTransaction.Location = new System.Drawing.Point(191, 451);
            this.lblTransaction.Name = "lblTransaction";
            this.lblTransaction.Size = new System.Drawing.Size(26, 56);
            this.lblTransaction.TabIndex = 12;
            // 
            // btnTransaction
            // 
            this.btnTransaction.BackColor = System.Drawing.Color.Black;
            this.btnTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaction.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaction.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTransaction.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btnTransaction.IconColor = System.Drawing.Color.White;
            this.btnTransaction.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransaction.Location = new System.Drawing.Point(0, 451);
            this.btnTransaction.Margin = new System.Windows.Forms.Padding(8);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Padding = new System.Windows.Forms.Padding(8);
            this.btnTransaction.Size = new System.Drawing.Size(217, 56);
            this.btnTransaction.TabIndex = 11;
            this.btnTransaction.Tag = "Transaction";
            this.btnTransaction.Text = "Transaction";
            this.btnTransaction.UseVisualStyleBackColor = false;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // lblClasses
            // 
            this.lblClasses.BackColor = System.Drawing.Color.GreenYellow;
            this.lblClasses.Location = new System.Drawing.Point(191, 395);
            this.lblClasses.Name = "lblClasses";
            this.lblClasses.Size = new System.Drawing.Size(26, 56);
            this.lblClasses.TabIndex = 10;
            // 
            // btnClasses
            // 
            this.btnClasses.BackColor = System.Drawing.Color.Black;
            this.btnClasses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClasses.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClasses.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClasses.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClasses.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnClasses.IconColor = System.Drawing.Color.White;
            this.btnClasses.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClasses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClasses.Location = new System.Drawing.Point(0, 395);
            this.btnClasses.Margin = new System.Windows.Forms.Padding(8);
            this.btnClasses.Name = "btnClasses";
            this.btnClasses.Padding = new System.Windows.Forms.Padding(8);
            this.btnClasses.Size = new System.Drawing.Size(217, 56);
            this.btnClasses.TabIndex = 9;
            this.btnClasses.Tag = "Classes";
            this.btnClasses.Text = "Classes";
            this.btnClasses.UseVisualStyleBackColor = false;
            this.btnClasses.Click += new System.EventHandler(this.btnClasses_Click);
            // 
            // lblProduct
            // 
            this.lblProduct.BackColor = System.Drawing.Color.GreenYellow;
            this.lblProduct.Location = new System.Drawing.Point(191, 339);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(26, 56);
            this.lblProduct.TabIndex = 8;
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.Black;
            this.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProduct.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            this.btnProduct.IconColor = System.Drawing.Color.White;
            this.btnProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(0, 339);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(8);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Padding = new System.Windows.Forms.Padding(8);
            this.btnProduct.Size = new System.Drawing.Size(217, 56);
            this.btnProduct.TabIndex = 7;
            this.btnProduct.Tag = "Product";
            this.btnProduct.Text = "Inventory";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // lblEquipment
            // 
            this.lblEquipment.BackColor = System.Drawing.Color.GreenYellow;
            this.lblEquipment.Location = new System.Drawing.Point(191, 283);
            this.lblEquipment.Name = "lblEquipment";
            this.lblEquipment.Size = new System.Drawing.Size(26, 56);
            this.lblEquipment.TabIndex = 6;
            // 
            // btnEquipment
            // 
            this.btnEquipment.BackColor = System.Drawing.Color.Black;
            this.btnEquipment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEquipment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquipment.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEquipment.IconChar = FontAwesome.Sharp.IconChar.Dumbbell;
            this.btnEquipment.IconColor = System.Drawing.Color.White;
            this.btnEquipment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEquipment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEquipment.Location = new System.Drawing.Point(0, 283);
            this.btnEquipment.Margin = new System.Windows.Forms.Padding(8);
            this.btnEquipment.Name = "btnEquipment";
            this.btnEquipment.Padding = new System.Windows.Forms.Padding(8);
            this.btnEquipment.Size = new System.Drawing.Size(217, 56);
            this.btnEquipment.TabIndex = 5;
            this.btnEquipment.Tag = "Equipment";
            this.btnEquipment.Text = "Equipment";
            this.btnEquipment.UseVisualStyleBackColor = false;
            this.btnEquipment.Click += new System.EventHandler(this.btnEquipment_Click);
            // 
            // lblMember
            // 
            this.lblMember.BackColor = System.Drawing.Color.GreenYellow;
            this.lblMember.Location = new System.Drawing.Point(191, 227);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(26, 56);
            this.lblMember.TabIndex = 4;
            // 
            // btnMember
            // 
            this.btnMember.BackColor = System.Drawing.Color.Black;
            this.btnMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMember.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMember.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMember.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMember.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.btnMember.IconColor = System.Drawing.Color.White;
            this.btnMember.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMember.Location = new System.Drawing.Point(0, 227);
            this.btnMember.Margin = new System.Windows.Forms.Padding(8);
            this.btnMember.Name = "btnMember";
            this.btnMember.Padding = new System.Windows.Forms.Padding(8);
            this.btnMember.Size = new System.Drawing.Size(217, 56);
            this.btnMember.TabIndex = 3;
            this.btnMember.Tag = "Member";
            this.btnMember.Text = "Member";
            this.btnMember.UseVisualStyleBackColor = false;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // lblStaff
            // 
            this.lblStaff.BackColor = System.Drawing.Color.GreenYellow;
            this.lblStaff.Location = new System.Drawing.Point(191, 171);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(26, 56);
            this.lblStaff.TabIndex = 2;
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.Black;
            this.btnStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStaff.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnStaff.IconColor = System.Drawing.Color.White;
            this.btnStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.Location = new System.Drawing.Point(0, 171);
            this.btnStaff.Margin = new System.Windows.Forms.Padding(8);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Padding = new System.Windows.Forms.Padding(8);
            this.btnStaff.Size = new System.Drawing.Size(217, 56);
            this.btnStaff.TabIndex = 1;
            this.btnStaff.Tag = "Staff";
            this.btnStaff.Text = "Staff";
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // lblOverview
            // 
            this.lblOverview.BackColor = System.Drawing.Color.GreenYellow;
            this.lblOverview.Location = new System.Drawing.Point(191, 115);
            this.lblOverview.Name = "lblOverview";
            this.lblOverview.Size = new System.Drawing.Size(26, 56);
            this.lblOverview.TabIndex = 0;
            // 
            // btnOverview
            // 
            this.btnOverview.BackColor = System.Drawing.Color.Black;
            this.btnOverview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOverview.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOverview.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOverview.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOverview.IconChar = FontAwesome.Sharp.IconChar.PieChart;
            this.btnOverview.IconColor = System.Drawing.Color.White;
            this.btnOverview.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOverview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOverview.Location = new System.Drawing.Point(0, 115);
            this.btnOverview.Margin = new System.Windows.Forms.Padding(8);
            this.btnOverview.Name = "btnOverview";
            this.btnOverview.Padding = new System.Windows.Forms.Padding(8);
            this.btnOverview.Size = new System.Drawing.Size(217, 56);
            this.btnOverview.TabIndex = 0;
            this.btnOverview.Tag = "Overview";
            this.btnOverview.Text = "Overview";
            this.btnOverview.UseVisualStyleBackColor = false;
            this.btnOverview.Click += new System.EventHandler(this.btnOverview_Click);
            // 
            // mnuStaff
            // 
            this.mnuStaff.BackColor = System.Drawing.Color.YellowGreen;
            this.mnuStaff.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuStaff.IsMainMenu = false;
            this.mnuStaff.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageStaffToolStripMenuItem,
            this.staffListReportToolStripMenuItem});
            this.mnuStaff.MenuItemHeight = 25;
            this.mnuStaff.MenuItemTextColor = System.Drawing.Color.Empty;
            this.mnuStaff.Name = "mnuStaff";
            this.mnuStaff.PrimaryColor = System.Drawing.Color.Empty;
            this.mnuStaff.Size = new System.Drawing.Size(159, 48);
            // 
            // manageStaffToolStripMenuItem
            // 
            this.manageStaffToolStripMenuItem.Name = "manageStaffToolStripMenuItem";
            this.manageStaffToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.manageStaffToolStripMenuItem.Text = "Manage Staff";
            this.manageStaffToolStripMenuItem.Click += new System.EventHandler(this.manageStaffToolStripMenuItem_Click);
            // 
            // staffListReportToolStripMenuItem
            // 
            this.staffListReportToolStripMenuItem.Name = "staffListReportToolStripMenuItem";
            this.staffListReportToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.staffListReportToolStripMenuItem.Text = "Staff List Report";
            this.staffListReportToolStripMenuItem.Click += new System.EventHandler(this.staffListReportToolStripMenuItem_Click);
            // 
            // mnuMember
            // 
            this.mnuMember.BackColor = System.Drawing.Color.YellowGreen;
            this.mnuMember.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMember.IsMainMenu = false;
            this.mnuMember.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageMemberToolStripMenuItem,
            this.memberListReportToolStripMenuItem});
            this.mnuMember.MenuItemHeight = 25;
            this.mnuMember.MenuItemTextColor = System.Drawing.Color.Empty;
            this.mnuMember.Name = "mnuMember";
            this.mnuMember.PrimaryColor = System.Drawing.Color.Empty;
            this.mnuMember.Size = new System.Drawing.Size(179, 48);
            // 
            // manageMemberToolStripMenuItem
            // 
            this.manageMemberToolStripMenuItem.Name = "manageMemberToolStripMenuItem";
            this.manageMemberToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.manageMemberToolStripMenuItem.Text = "Manage Member";
            this.manageMemberToolStripMenuItem.Click += new System.EventHandler(this.manageMemberToolStripMenuItem_Click);
            // 
            // memberListReportToolStripMenuItem
            // 
            this.memberListReportToolStripMenuItem.Name = "memberListReportToolStripMenuItem";
            this.memberListReportToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.memberListReportToolStripMenuItem.Text = "Member List Report";
            this.memberListReportToolStripMenuItem.Click += new System.EventHandler(this.memberListReportToolStripMenuItem_Click);
            // 
            // mnuEquipment
            // 
            this.mnuEquipment.BackColor = System.Drawing.Color.YellowGreen;
            this.mnuEquipment.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuEquipment.IsMainMenu = false;
            this.mnuEquipment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageEquipmentToolStripMenuItem,
            this.maintainEquipmentToolStripMenuItem,
            this.equipmentListReportToolStripMenuItem,
            this.maintenanceReportToolStripMenuItem});
            this.mnuEquipment.MenuItemHeight = 25;
            this.mnuEquipment.MenuItemTextColor = System.Drawing.Color.Empty;
            this.mnuEquipment.Name = "mnuEquipment";
            this.mnuEquipment.PrimaryColor = System.Drawing.Color.Empty;
            this.mnuEquipment.Size = new System.Drawing.Size(192, 92);
            // 
            // manageEquipmentToolStripMenuItem
            // 
            this.manageEquipmentToolStripMenuItem.Name = "manageEquipmentToolStripMenuItem";
            this.manageEquipmentToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.manageEquipmentToolStripMenuItem.Text = "Manage Equipment";
            this.manageEquipmentToolStripMenuItem.Click += new System.EventHandler(this.manageEquipmentToolStripMenuItem_Click);
            // 
            // maintainEquipmentToolStripMenuItem
            // 
            this.maintainEquipmentToolStripMenuItem.Name = "maintainEquipmentToolStripMenuItem";
            this.maintainEquipmentToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.maintainEquipmentToolStripMenuItem.Text = "Maintain Equipment";
            this.maintainEquipmentToolStripMenuItem.Click += new System.EventHandler(this.maintainEquipmentToolStripMenuItem_Click);
            // 
            // equipmentListReportToolStripMenuItem
            // 
            this.equipmentListReportToolStripMenuItem.Name = "equipmentListReportToolStripMenuItem";
            this.equipmentListReportToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.equipmentListReportToolStripMenuItem.Text = "Equipment List Report";
            this.equipmentListReportToolStripMenuItem.Click += new System.EventHandler(this.equipmentListReportToolStripMenuItem_Click);
            // 
            // maintenanceReportToolStripMenuItem
            // 
            this.maintenanceReportToolStripMenuItem.Name = "maintenanceReportToolStripMenuItem";
            this.maintenanceReportToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.maintenanceReportToolStripMenuItem.Text = "Maintenance Report";
            this.maintenanceReportToolStripMenuItem.Click += new System.EventHandler(this.maintenanceReportToolStripMenuItem_Click);
            // 
            // mnuProduct
            // 
            this.mnuProduct.BackColor = System.Drawing.Color.YellowGreen;
            this.mnuProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuProduct.IsMainMenu = false;
            this.mnuProduct.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageProductToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.productListReportToolStripMenuItem});
            this.mnuProduct.MenuItemHeight = 25;
            this.mnuProduct.MenuItemTextColor = System.Drawing.Color.Empty;
            this.mnuProduct.Name = "mnuProduct";
            this.mnuProduct.PrimaryColor = System.Drawing.Color.Empty;
            this.mnuProduct.Size = new System.Drawing.Size(200, 70);
            // 
            // manageProductToolStripMenuItem
            // 
            this.manageProductToolStripMenuItem.Name = "manageProductToolStripMenuItem";
            this.manageProductToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.manageProductToolStripMenuItem.Text = "Manage Product";
            this.manageProductToolStripMenuItem.Click += new System.EventHandler(this.manageProductToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.inventoryToolStripMenuItem.Text = "Inventory Management";
            this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
            // 
            // productListReportToolStripMenuItem
            // 
            this.productListReportToolStripMenuItem.Name = "productListReportToolStripMenuItem";
            this.productListReportToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.productListReportToolStripMenuItem.Text = "Inventory Report";
            this.productListReportToolStripMenuItem.Click += new System.EventHandler(this.productListReportToolStripMenuItem_Click);
            // 
            // mnuClasses
            // 
            this.mnuClasses.BackColor = System.Drawing.Color.YellowGreen;
            this.mnuClasses.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuClasses.IsMainMenu = false;
            this.mnuClasses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageClassesToolStripMenuItem,
            this.classesReportToolStripMenuItem});
            this.mnuClasses.MenuItemHeight = 25;
            this.mnuClasses.MenuItemTextColor = System.Drawing.Color.Empty;
            this.mnuClasses.Name = "mnuClasses";
            this.mnuClasses.PrimaryColor = System.Drawing.Color.Empty;
            this.mnuClasses.Size = new System.Drawing.Size(158, 48);
            // 
            // manageClassesToolStripMenuItem
            // 
            this.manageClassesToolStripMenuItem.Name = "manageClassesToolStripMenuItem";
            this.manageClassesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.manageClassesToolStripMenuItem.Text = "Manage Classes";
            this.manageClassesToolStripMenuItem.Click += new System.EventHandler(this.manageClassesToolStripMenuItem_Click);
            // 
            // classesReportToolStripMenuItem
            // 
            this.classesReportToolStripMenuItem.Name = "classesReportToolStripMenuItem";
            this.classesReportToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.classesReportToolStripMenuItem.Text = "Classes Report";
            this.classesReportToolStripMenuItem.Click += new System.EventHandler(this.classesReportToolStripMenuItem_Click);
            // 
            // mnuTransaction
            // 
            this.mnuTransaction.BackColor = System.Drawing.Color.YellowGreen;
            this.mnuTransaction.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTransaction.IsMainMenu = false;
            this.mnuTransaction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.membershipPaymentToolStripMenuItem,
            this.membershipReportToolStripMenuItem,
            this.printMembershipReceiptToolStripMenuItem});
            this.mnuTransaction.MenuItemHeight = 25;
            this.mnuTransaction.MenuItemTextColor = System.Drawing.Color.Empty;
            this.mnuTransaction.Name = "mnuTransaction";
            this.mnuTransaction.PrimaryColor = System.Drawing.Color.Empty;
            this.mnuTransaction.Size = new System.Drawing.Size(212, 70);
            // 
            // membershipPaymentToolStripMenuItem
            // 
            this.membershipPaymentToolStripMenuItem.Name = "membershipPaymentToolStripMenuItem";
            this.membershipPaymentToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.membershipPaymentToolStripMenuItem.Text = "Membership Payment";
            this.membershipPaymentToolStripMenuItem.Click += new System.EventHandler(this.membershipPaymentToolStripMenuItem_Click);
            // 
            // membershipReportToolStripMenuItem
            // 
            this.membershipReportToolStripMenuItem.Name = "membershipReportToolStripMenuItem";
            this.membershipReportToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.membershipReportToolStripMenuItem.Text = "Membership Report";
            this.membershipReportToolStripMenuItem.Click += new System.EventHandler(this.membershipReportToolStripMenuItem_Click);
            // 
            // printMembershipReceiptToolStripMenuItem
            // 
            this.printMembershipReceiptToolStripMenuItem.Name = "printMembershipReceiptToolStripMenuItem";
            this.printMembershipReceiptToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.printMembershipReceiptToolStripMenuItem.Text = "Print Membership Invoice";
            this.printMembershipReceiptToolStripMenuItem.Click += new System.EventHandler(this.printMembershipReceiptToolStripMenuItem_Click);
            // 
            // pnlOverview
            // 
            this.pnlOverview.AutoScroll = true;
            this.pnlOverview.AutoScrollMinSize = new System.Drawing.Size(867, 925);
            this.pnlOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOverview.Location = new System.Drawing.Point(217, 44);
            this.pnlOverview.Name = "pnlOverview";
            this.pnlOverview.Size = new System.Drawing.Size(867, 717);
            this.pnlOverview.TabIndex = 6;
            // 
            // pnlProduct
            // 
            this.pnlProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProduct.Location = new System.Drawing.Point(217, 44);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(867, 717);
            this.pnlProduct.TabIndex = 0;
            // 
            // pnlInventory
            // 
            this.pnlInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInventory.Location = new System.Drawing.Point(217, 44);
            this.pnlInventory.Name = "pnlInventory";
            this.pnlInventory.Size = new System.Drawing.Size(867, 717);
            this.pnlInventory.TabIndex = 1;
            // 
            // pnlStaff
            // 
            this.pnlStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStaff.Location = new System.Drawing.Point(217, 44);
            this.pnlStaff.Name = "pnlStaff";
            this.pnlStaff.Size = new System.Drawing.Size(867, 717);
            this.pnlStaff.TabIndex = 2;
            // 
            // pnlEquipment
            // 
            this.pnlEquipment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEquipment.Location = new System.Drawing.Point(217, 44);
            this.pnlEquipment.Name = "pnlEquipment";
            this.pnlEquipment.Size = new System.Drawing.Size(867, 717);
            this.pnlEquipment.TabIndex = 3;
            // 
            // pnlMember
            // 
            this.pnlMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMember.Location = new System.Drawing.Point(217, 44);
            this.pnlMember.Name = "pnlMember";
            this.pnlMember.Size = new System.Drawing.Size(867, 717);
            this.pnlMember.TabIndex = 4;
            // 
            // pnlMembershipPayment
            // 
            this.pnlMembershipPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMembershipPayment.Location = new System.Drawing.Point(217, 44);
            this.pnlMembershipPayment.Name = "pnlMembershipPayment";
            this.pnlMembershipPayment.Size = new System.Drawing.Size(867, 717);
            this.pnlMembershipPayment.TabIndex = 5;
            // 
            // pnlClasses
            // 
            this.pnlClasses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlClasses.Location = new System.Drawing.Point(217, 44);
            this.pnlClasses.Name = "pnlClasses";
            this.pnlClasses.Size = new System.Drawing.Size(867, 717);
            this.pnlClasses.TabIndex = 7;
            // 
            // pnlMaintenanceEquipment
            // 
            this.pnlMaintenanceEquipment.AutoScroll = true;
            this.pnlMaintenanceEquipment.AutoScrollMinSize = new System.Drawing.Size(867, 717);
            this.pnlMaintenanceEquipment.Controls.Add(this.guna2TextBox1);
            this.pnlMaintenanceEquipment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMaintenanceEquipment.Location = new System.Drawing.Point(217, 44);
            this.pnlMaintenanceEquipment.Name = "pnlMaintenanceEquipment";
            this.pnlMaintenanceEquipment.Size = new System.Drawing.Size(867, 717);
            this.pnlMaintenanceEquipment.TabIndex = 8;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(59, 26);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(200, 36);
            this.guna2TextBox1.TabIndex = 0;
            this.guna2TextBox1.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1084, 761);
            this.Controls.Add(this.pnlMaintenanceEquipment);
            this.Controls.Add(this.pnlClasses);
            this.Controls.Add(this.pnlMembershipPayment);
            this.Controls.Add(this.pnlMember);
            this.Controls.Add(this.pnlEquipment);
            this.Controls.Add(this.pnlStaff);
            this.Controls.Add(this.pnlInventory);
            this.Controls.Add(this.pnlProduct);
            this.Controls.Add(this.pnlOverview);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.pnlIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.mnuStaff.ResumeLayout(false);
            this.mnuMember.ResumeLayout(false);
            this.mnuEquipment.ResumeLayout(false);
            this.mnuProduct.ResumeLayout(false);
            this.mnuClasses.ResumeLayout(false);
            this.mnuTransaction.ResumeLayout(false);
            this.pnlMaintenanceEquipment.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlIcon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlTitleBar;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblTitle;
        private FontAwesome.Sharp.IconButton btnOverview;
        private System.Windows.Forms.Label lblOverview;
        private System.Windows.Forms.Label lblStaff;
        private FontAwesome.Sharp.IconButton btnStaff;
        private System.Windows.Forms.Label lblMember;
        private FontAwesome.Sharp.IconButton btnMember;
        private FontAwesome.Sharp.IconButton btnProduct;
        private System.Windows.Forms.Label lblEquipment;
        private FontAwesome.Sharp.IconButton btnEquipment;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblClasses;
        private FontAwesome.Sharp.IconButton btnClasses;
        private System.Windows.Forms.Label lblTransaction;
        private FontAwesome.Sharp.IconButton btnTransaction;
        private FontAwesome.Sharp.IconButton btnExit;
        private CustomBox.RJControls.RJDropdownMenu mnuStaff;
        private System.Windows.Forms.ToolStripMenuItem manageStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffListReportToolStripMenuItem;
        private CustomBox.RJControls.RJDropdownMenu mnuMember;
        private System.Windows.Forms.ToolStripMenuItem manageMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberListReportToolStripMenuItem;
        private CustomBox.RJControls.RJDropdownMenu mnuEquipment;
        private System.Windows.Forms.ToolStripMenuItem manageEquipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintainEquipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipmentListReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceReportToolStripMenuItem;
        private CustomBox.RJControls.RJDropdownMenu mnuProduct;
        private System.Windows.Forms.ToolStripMenuItem manageProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productListReportToolStripMenuItem;
        private CustomBox.RJControls.RJDropdownMenu mnuClasses;
        private System.Windows.Forms.ToolStripMenuItem manageClassesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classesReportToolStripMenuItem;
        private CustomBox.RJControls.RJDropdownMenu mnuTransaction;
        private System.Windows.Forms.ToolStripMenuItem membershipPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membershipReportToolStripMenuItem;
        private System.Windows.Forms.Panel pnlOverview;
        private System.Windows.Forms.Panel pnlProduct;
        private System.Windows.Forms.Panel pnlInventory;
        private System.Windows.Forms.Panel pnlStaff;
        private System.Windows.Forms.Panel pnlEquipment;
        private System.Windows.Forms.Panel pnlMember;
        private System.Windows.Forms.Panel pnlMembershipPayment;
        private System.Windows.Forms.Panel pnlClasses;
        private System.Windows.Forms.Panel pnlMaintenanceEquipment;
        private System.Windows.Forms.ToolStripMenuItem printMembershipReceiptToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
    }
}