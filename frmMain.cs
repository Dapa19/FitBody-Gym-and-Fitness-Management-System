using CustomBox.RJControls;
using FontAwesome.Sharp;
using RJCodeAdvance.RJControls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitBody
{
    public partial class frmMain : Form
    {
        private int borderSize = 2;
        private Size formSize;
        private Form currentChildForm;

        public frmMain()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);//Border size

            this.StartPosition = FormStartPosition.CenterScreen;

            lblTitle.Text = "Overview";

            pnlOverview.Visible = true;
            pnlProduct.Visible = false;
            pnlInventory.Visible = false;
            pnlStaff.Visible = false;
            pnlEquipment.Visible = false;
            pnlMember.Visible = false;
            pnlMembershipPayment.Visible = false;
            pnlClasses.Visible = false;
            pnlMaintenanceEquipment.Visible = false;

            lblOverview.Visible = true;
            lblStaff.Visible = false;
            lblMember.Visible = false;
            lblEquipment.Visible = false;
            lblProduct.Visible = false;
            lblClasses.Visible = false;
            lblTransaction.Visible = false;
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                formSize = this.ClientSize;
                this.WindowState = FormWindowState.Maximized;
                btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = formSize;
                btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Connection();
            LoadDataMember();
            LoadDataStaff();
            LoadDataEquipment();
            LoadDataInventory();

            formSize = this.ClientSize;

            pnlOverview.AutoScroll = true;

            btnOverview.PerformClick();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Overridden methods
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;

            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right

            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>

            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          

                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion

            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }

            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);

                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }

        //Private methods
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized: //Maximized form (After)
                    btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
                    this.Padding = new Padding(8, 8, 8, 8);
                    break;
                case FormWindowState.Normal: //Restored form (After)
                    btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Tampilkan kotak dialog konfirmasi sebelum keluar
            DialogResult result = MessageBox.Show(
                "Are you want to close this apps?",
                "Close Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Periksa pilihan pengguna
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Keluar dari aplikasi
            }
            // Jika pengguna memilih No, tidak ada tindakan yang dilakukan
        }

        private void Open_DropdownMenu(RJDropdownMenu dropdownMenu, object sender)
        {
            Control control = (Control)sender;
            dropdownMenu.VisibleChanged += new EventHandler((sender2, ev) =>
                DropdownMenu_VisibleChanged(sender2, ev, control));
            dropdownMenu.Show(control, control.Width, 0);
        }

        private void DropdownMenu_VisibleChanged(object sender, EventArgs e, Control ctrl)
        {
            RJDropdownMenu dropdownMenu = (RJDropdownMenu)sender;
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            Open_DropdownMenu(mnuStaff, sender);
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            Open_DropdownMenu(mnuMember, sender);
        }

        private void btnEquipment_Click(object sender, EventArgs e)
        {
            Open_DropdownMenu(mnuEquipment, sender);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Open_DropdownMenu(mnuProduct, sender);
        }

        private void btnClasses_Click(object sender, EventArgs e)
        {
            Open_DropdownMenu(mnuClasses, sender);
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            Open_DropdownMenu(mnuTransaction, sender);
        }

        //Start disini untuk panel

        private void OpenChildFormOverview(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlOverview.Controls.Add(childForm);
            this.pnlOverview.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnOverview_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Overview";

            lblOverview.Visible = true;
            lblStaff.Visible = false;
            lblMember.Visible = false;
            lblEquipment.Visible = false;
            lblProduct.Visible = false;
            lblClasses.Visible = false;
            lblTransaction.Visible = false;


            pnlOverview.Visible = true;
            pnlProduct.Visible = false;
            pnlInventory.Visible = false;
            pnlStaff.Visible = false;
            pnlEquipment.Visible = false;
            pnlMember.Visible = false;
            pnlMembershipPayment.Visible = false;
            pnlClasses.Visible = false;
            pnlMaintenanceEquipment.Visible = false;

            frmOverview overview = new frmOverview(this);
            overview.Tag = this;

            OpenChildFormOverview(new frmOverview());
        }

        private void OpenChildFormProduct(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlProduct.Controls.Add(childForm);
            this.pnlProduct.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void manageProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Product";

            lblOverview.Visible = false;
            lblStaff.Visible = false;
            lblMember.Visible = false;
            lblEquipment.Visible = false;
            lblProduct.Visible = true;
            lblClasses.Visible = false;
            lblTransaction.Visible = false;


            pnlOverview.Visible = false;
            pnlProduct.Visible= true;
            pnlInventory.Visible = false;
            pnlStaff.Visible = false;
            pnlEquipment.Visible = false;
            pnlMember.Visible = false;
            pnlMembershipPayment.Visible = false;
            pnlClasses.Visible = false;
            pnlMaintenanceEquipment.Visible = false;

            Master.frmProduct masterProduct = new Master.frmProduct(this);
            masterProduct.Tag = this;

            OpenChildFormProduct(new Master.frmProduct());
        }

        private void OpenChildFormInventory(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlInventory.Controls.Add(childForm);
            this.pnlInventory.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Inventory";

            lblOverview.Visible = false;
            lblStaff.Visible = false;
            lblMember.Visible = false;
            lblEquipment.Visible = false;
            lblProduct.Visible = true;
            lblClasses.Visible = false;
            lblTransaction.Visible = false;


            pnlOverview.Visible = false;
            pnlProduct.Visible = false;
            pnlInventory.Visible = true;
            pnlStaff.Visible = false;
            pnlEquipment.Visible = false;
            pnlMember.Visible = false;
            pnlMembershipPayment.Visible = false;
            pnlClasses.Visible = false;
            pnlMaintenanceEquipment.Visible = false;


            Transaction.frmInventory transactionInventory = new Transaction.frmInventory(this);
            transactionInventory.Tag = this;

            OpenChildFormInventory(new Transaction.frmInventory());
        }

        private void OpenChildFormStaff(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlStaff.Controls.Add(childForm);
            this.pnlStaff.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void manageStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Staff";

            lblOverview.Visible = false;
            lblStaff.Visible = true;
            lblMember.Visible = false;
            lblEquipment.Visible = false;
            lblProduct.Visible = false;
            lblClasses.Visible = false;
            lblTransaction.Visible = false;

            pnlOverview.Visible = false;
            pnlProduct.Visible = false;
            pnlInventory.Visible = false;
            pnlStaff.Visible = true;
            pnlEquipment.Visible = false;
            pnlMember.Visible = false;
            pnlMembershipPayment.Visible = false;
            pnlClasses.Visible = false;
            pnlMaintenanceEquipment.Visible = false;

            Master.frmStaff masterStaff = new Master.frmStaff(this);
            masterStaff.Tag = this;

            OpenChildFormStaff(new Master.frmStaff());
        }

        private void OpenChildFormEquipment(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlEquipment.Controls.Add(childForm);
            this.pnlEquipment.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void manageEquipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Equipment";

            lblOverview.Visible = false;
            lblStaff.Visible = false;
            lblMember.Visible = false;
            lblEquipment.Visible = true;
            lblProduct.Visible = false;
            lblClasses.Visible = false;
            lblTransaction.Visible = false;

            pnlOverview.Visible = false;
            pnlProduct.Visible = false;
            pnlInventory.Visible = false;
            pnlStaff.Visible = false;
            pnlEquipment.Visible = true;
            pnlMember.Visible = false;
            pnlMembershipPayment.Visible = false;
            pnlClasses.Visible = false;
            pnlMaintenanceEquipment.Visible = false;

            Master.frmEquipment masterEquipment = new Master.frmEquipment(this);
            masterEquipment.Tag = this;

            OpenChildFormEquipment(new Master.frmEquipment());
        }

        private void OpenChildFormMember(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlMember.Controls.Add(childForm);
            this.pnlMember.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void manageMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Member";

            lblOverview.Visible = false;
            lblStaff.Visible = false;
            lblMember.Visible = true;
            lblEquipment.Visible = false;
            lblProduct.Visible = false;
            lblClasses.Visible = false;
            lblTransaction.Visible = false;

            pnlOverview.Visible = false;
            pnlProduct.Visible = false;
            pnlInventory.Visible = false;
            pnlStaff.Visible = false;
            pnlEquipment.Visible = false;
            pnlMember.Visible = true;
            pnlMembershipPayment.Visible = false;
            pnlClasses.Visible = false;
            pnlMaintenanceEquipment.Visible = false;

            Master.frmMember masterMember = new Master.frmMember(this);
            masterMember.Tag = this;

            OpenChildFormMember(new Master.frmMember());
        }

        private void OpenChildFormMembershipPayment(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlMembershipPayment.Controls.Add(childForm);
            this.pnlMembershipPayment.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void membershipPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Membership Payment";

            lblOverview.Visible = false;
            lblStaff.Visible = false;
            lblMember.Visible = false;
            lblEquipment.Visible = false;
            lblProduct.Visible = false;
            lblClasses.Visible = false;
            lblTransaction.Visible = true;

            pnlOverview.Visible = false;
            pnlProduct.Visible = false;
            pnlInventory.Visible = false;
            pnlStaff.Visible = false;
            pnlEquipment.Visible = false;
            pnlMember.Visible = false;
            pnlMembershipPayment.Visible = true;
            pnlClasses.Visible = false;
            pnlMaintenanceEquipment.Visible = false;


            Transaction.frmMembershipPayment transactionPayment = new Transaction.frmMembershipPayment(this);
            transactionPayment.Tag = this;

            OpenChildFormMembershipPayment(new Transaction.frmMembershipPayment());
        }

        private void OpenChildFormClasses(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlClasses.Controls.Add(childForm);
            this.pnlClasses.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void manageClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Manage Classes";

            lblOverview.Visible = false;
            lblStaff.Visible = false;
            lblMember.Visible = false;
            lblEquipment.Visible = false;
            lblProduct.Visible = false;
            lblClasses.Visible = true;
            lblTransaction.Visible = false;

            pnlOverview.Visible = false;
            pnlProduct.Visible = false;
            pnlInventory.Visible = false;
            pnlStaff.Visible = false;
            pnlEquipment.Visible = false;
            pnlMember.Visible = false;
            pnlMembershipPayment.Visible = false;
            pnlClasses.Visible = true;
            pnlMaintenanceEquipment.Visible = false;

            Transaction.frmClasses transactionClasses = new Transaction.frmClasses(this);
            transactionClasses.Tag = this;

            OpenChildFormClasses(new Transaction.frmClasses());
        }

        private void OpenChildFormMaintenance(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlMaintenanceEquipment.Controls.Add(childForm);
            this.pnlMaintenanceEquipment.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void maintainEquipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Maintain Equipment";

            lblOverview.Visible = false;
            lblStaff.Visible = false;
            lblMember.Visible = false;
            lblEquipment.Visible = true;
            lblProduct.Visible = false;
            lblClasses.Visible = false;
            lblTransaction.Visible = false;

            pnlOverview.Visible = false;
            pnlProduct.Visible = false;
            pnlInventory.Visible = false;
            pnlStaff.Visible = false;
            pnlEquipment.Visible = false;
            pnlMember.Visible = false;
            pnlMembershipPayment.Visible = false;
            pnlClasses.Visible = false;
            pnlMaintenanceEquipment.Visible = true;

            Transaction.frmEquipmentMaintenance transactionMaintenance = new Transaction.frmEquipmentMaintenance(this);
            transactionMaintenance.Tag = this;

            OpenChildFormMaintenance(new Transaction.frmEquipmentMaintenance());
        }

        //Report

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

        private void LoadDataMember()
        {
            ds = new DataSet();
            query = "SELECT * FROM Members";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Members");
        }

        private void memberListReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.CrystalReportMembers cr = new Report.CrystalReportMembers();
            Report.frmCrystalReportViewer viewer = new Report.frmCrystalReportViewer();
            LoadDataMember();
            cr.SetDataSource(ds);
            viewer.crystalReportViewer1.ReportSource = cr;
            viewer.WindowState = FormWindowState.Maximized;
            viewer.Show();
        }

        private void LoadDataStaff()
        {
            ds = new DataSet();
            query = "SELECT * FROM Staff";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Staff");
        }

        private void staffListReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.CrystalReportStaff cr = new Report.CrystalReportStaff();
            Report.frmCrystalReportViewer viewer = new Report.frmCrystalReportViewer();
            LoadDataStaff();
            cr.SetDataSource(ds);
            viewer.crystalReportViewer1.ReportSource = cr;
            viewer.WindowState = FormWindowState.Maximized;
            viewer.Show();
        }

        private void LoadDataEquipment()
        {
            ds = new DataSet();
            query = "SELECT * FROM Equipment";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Equipment");
        }

        private void equipmentListReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.CrystalReportEquipment cr = new Report.CrystalReportEquipment();
            Report.frmCrystalReportViewer viewer = new Report.frmCrystalReportViewer();
            LoadDataEquipment();
            cr.SetDataSource(ds);
            viewer.crystalReportViewer1.ReportSource = cr;
            viewer.WindowState = FormWindowState.Maximized;
            viewer.Show();
        }

        private void LoadDataInventory()
        {
            ds = new DataSet();
            query = "SELECT P.productID, P.productName, P.productCategory, I.qty FROM Product P INNER JOIN Inventory I ON P.productID = I.productID";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Inventory");
        }

        private void productListReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.CrystalReportInventory cr = new Report.CrystalReportInventory();
            Report.frmCrystalReportViewer viewer = new Report.frmCrystalReportViewer();
            LoadDataInventory();
            cr.SetDataSource(ds);
            viewer.crystalReportViewer1.ReportSource = cr;
            viewer.WindowState = FormWindowState.Maximized;
            viewer.Show();
        }

        private void membershipReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.frmReportMembershipPayment reportPayment = new Report.frmReportMembershipPayment(this);
            reportPayment.Tag = this;
            reportPayment.ShowDialog();
        }

        private void classesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.frmClassesReport reportClasses = new Report.frmClassesReport(this);
            reportClasses.Tag = this;
            reportClasses.ShowDialog();
        }

        private void maintenanceReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.frmMaintenanceReport maintenanceReport = new Report.frmMaintenanceReport(this);
            maintenanceReport.Tag = this;
            maintenanceReport.ShowDialog();
        }

        private void printMembershipReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.frmInvoice invoice = new Report.frmInvoice(this);
            invoice.Tag = this;
            invoice.ShowDialog();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
