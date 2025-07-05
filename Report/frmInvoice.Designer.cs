namespace FitBody.Report
{
    partial class frmInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoice));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblMemberDescription = new System.Windows.Forms.Label();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.lblPaymentID = new System.Windows.Forms.Label();
            this.btnBrowsePayment = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrint = new CustomBox.RJControls.RJButton();
            this.btnClear = new CustomBox.RJControls.RJButton();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(103, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Print Invoice";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-17, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 84);
            this.panel1.TabIndex = 46;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FitBody.Properties.Resources.pngwing_com__5_;
            this.pictureBox2.Location = new System.Drawing.Point(49, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // lblMemberDescription
            // 
            this.lblMemberDescription.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMemberDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMemberDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMemberDescription.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberDescription.Location = new System.Drawing.Point(32, 287);
            this.lblMemberDescription.Name = "lblMemberDescription";
            this.lblMemberDescription.Size = new System.Drawing.Size(179, 45);
            this.lblMemberDescription.TabIndex = 51;
            this.lblMemberDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMemberID
            // 
            this.lblMemberID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMemberID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMemberID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMemberID.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberID.Location = new System.Drawing.Point(32, 241);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(179, 30);
            this.lblMemberID.TabIndex = 50;
            this.lblMemberID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPaymentID
            // 
            this.lblPaymentID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPaymentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPaymentID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPaymentID.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentID.Location = new System.Drawing.Point(32, 152);
            this.lblPaymentID.Name = "lblPaymentID";
            this.lblPaymentID.Size = new System.Drawing.Size(179, 30);
            this.lblPaymentID.TabIndex = 49;
            this.lblPaymentID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBrowsePayment
            // 
            this.btnBrowsePayment.IconChar = FontAwesome.Sharp.IconChar.Display;
            this.btnBrowsePayment.IconColor = System.Drawing.Color.Black;
            this.btnBrowsePayment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBrowsePayment.IconSize = 32;
            this.btnBrowsePayment.Location = new System.Drawing.Point(221, 147);
            this.btnBrowsePayment.Name = "btnBrowsePayment";
            this.btnBrowsePayment.Size = new System.Drawing.Size(54, 37);
            this.btnBrowsePayment.TabIndex = 48;
            this.btnBrowsePayment.UseVisualStyleBackColor = true;
            this.btnBrowsePayment.Click += new System.EventHandler(this.btnBrowsePayment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(28, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 19);
            this.label1.TabIndex = 47;
            this.label1.Text = "From (Payment ID)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(28, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 52;
            this.label3.Text = "To Member : ";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.ForestGreen;
            this.btnPrint.BackgroundColor = System.Drawing.Color.ForestGreen;
            this.btnPrint.BorderColor = System.Drawing.Color.Red;
            this.btnPrint.BorderRadius = 5;
            this.btnPrint.BorderSize = 0;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(221, 366);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(179, 50);
            this.btnPrint.TabIndex = 53;
            this.btnPrint.Text = "Print Invoice";
            this.btnPrint.TextColor = System.Drawing.Color.White;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.BackgroundColor = System.Drawing.Color.Gray;
            this.btnClear.BorderColor = System.Drawing.Color.Red;
            this.btnClear.BorderRadius = 5;
            this.btnClear.BorderSize = 0;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(32, 366);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(179, 50);
            this.btnClear.TabIndex = 54;
            this.btnClear.Text = "Clear All";
            this.btnClear.TextColor = System.Drawing.Color.White;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(159, 119);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 20);
            this.label15.TabIndex = 55;
            this.label15.Text = "*";
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMemberDescription);
            this.Controls.Add(this.lblMemberID);
            this.Controls.Add(this.lblPaymentID);
            this.Controls.Add(this.btnBrowsePayment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmInvoice";
            this.Text = "Print Invoice";
            this.Load += new System.EventHandler(this.frmInvoice_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblMemberDescription;
        public System.Windows.Forms.Label lblMemberID;
        public System.Windows.Forms.Label lblPaymentID;
        public FontAwesome.Sharp.IconButton btnBrowsePayment;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        public CustomBox.RJControls.RJButton btnPrint;
        public CustomBox.RJControls.RJButton btnClear;
        private System.Windows.Forms.Label label15;
    }
}