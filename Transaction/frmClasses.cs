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
    public partial class frmClasses : Form
    {
        public frmClasses()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        frmMain mainMenu;
        public frmClasses(frmMain mainMenu)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
        }

        SqlConnection con;
        string constr;
        SqlDataAdapter da;
        SqlCommand cmd;
        string query;
        DataSet ds, dsInventory;
        DataRow dr;
        DataColumn[] dc1 = new DataColumn[1]; //1 PK
        DataColumn[] dc2 = new DataColumn[2]; //2 PK
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
            query = "SELECT * FROM ClassHeader WHERE classID IN (SELECT MAX(classID) FROM ClassHeader) ORDER BY classID DESC";
            cmd = new SqlCommand(query, con);
            dl = cmd.ExecuteReader();
            dl.Read();

            if (dl.HasRows)
            {
                hitung = Convert.ToInt64(dl[0].ToString().Substring(dl["classID"].ToString().Length - 2, 2)) + 1; //2
                string joinstr = "00" + hitung; // 002
                urut = "CLS00000" + joinstr.Substring(joinstr.Length - 2, 2); //PRO0000002
            }
            else
            {
                urut = "CLS0000001";
            }
            dl.Close();
            lblClassID.Text = urut;
        }

        private void LoadDataHeader()
        {
            ds = new DataSet();
            query = "SELECT * FROM ClassHeader";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "ClassHeader");
            dc1[0] = ds.Tables["ClassHeader"].Columns[0];
            ds.Tables["ClassHeader"].PrimaryKey = dc1;
        }

        private void LoadDataHeaderStaff()
        {
            ds = new DataSet();
            query = "SELECT CH.classID, CH.className, S.staffID, S.staffName, CH.scheduleDate, CH.startTime, CH.endTime FROM ClassHeader CH INNER JOIN Staff S ON CH.staffID = S.staffID WHERE CH.classID = '" + lblClassID.Text + "'";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "joinClassHeaderStaff");
            dc1[0] = ds.Tables["joinClassHeaderStaff"].Columns[0];
            ds.Tables["joinClassHeaderStaff"].PrimaryKey = dc1;
        }

        private void LoadDataDetail()
        {
            ds = new DataSet();
            query = "SELECT * FROM ClassDetail";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "ClassDetail");
            dc2[0] = ds.Tables["ClassDetail"].Columns[0];
            dc2[1] = ds.Tables["ClassDetail"].Columns[1];
            ds.Tables["ClassDetail"].PrimaryKey = dc2;
        }

        private void LoadDataDetailMember()
        {
            ds = new DataSet();
            query = "SELECT CD.classID, M.memberID, M.fullname FROM ClassDetail CD INNER JOIN Members M ON CD.memberID = M.memberID WHERE CD.classID = '" + lblClassID.Text + "'";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "joinClassDetailMember");
            dc2[0] = ds.Tables["joinClassDetailMember"].Columns[0];
            dc2[1] = ds.Tables["joinClassDetailMember"].Columns[1];
            ds.Tables["joinClassDetailMember"].PrimaryKey = dc2;
        }

        private void LoadDataDetailberdasarkanClassID()
        {
            ds = new DataSet();
            query = "SELECT * FROM ClassDetail WHERE classID = '" + lblClassID.Text + "'";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "ClassDetail");
            dc2[0] = ds.Tables["ClassDetail"].Columns[0];
            dc2[1] = ds.Tables["ClassDetail"].Columns[1];
            ds.Tables["ClassDetail"].PrimaryKey = dc2;
        }

        private void UpdateDataHeader()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds.Tables["ClassHeader"]);
        }

        private void UpdateDataDetail()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds.Tables["ClassDetail"]);
        }

        private void EmptyHeader()
        {
            AutoID();

            dtpSchedule.Value = DateTime.Today;
            lblStaffID.Text = string.Empty;
            lblStaffName.Text = string.Empty;
            txtClassName.Text = string.Empty;
            txtStart.Text = string.Empty;
            txtEnd.Text = string.Empty;

            dgvData.Rows.Clear();

            txtClassName.Focus();
        }

        private void EmptyDetail()
        {
            lblMemberID.Text = string.Empty;
            lblMemberName.Text = string.Empty;
        }

        private void btnBrowseClass_Click(object sender, EventArgs e)
        {
            Transaction.frmBrowseClasses transactionBrowseClasses = new Transaction.frmBrowseClasses(this);
            transactionBrowseClasses.Tag = this;
            transactionBrowseClasses.ShowDialog();
        }

        private void btnBrowseStaff_Click(object sender, EventArgs e)
        {
            Master.frmBrowseStaff masterBrowseStaff = new Master.frmBrowseStaff(this);
            masterBrowseStaff.Tag = this;
            masterBrowseStaff.ShowDialog();
        }

        private void btnBrowseMember_Click(object sender, EventArgs e)
        {
            Master.frmBrowseMember masterBrowseMember = new Master.frmBrowseMember(this);
            masterBrowseMember.Tag = this;
            masterBrowseMember.ShowDialog();
        }

        private void frmClasses_Load(object sender, EventArgs e)
        {
            Connection();
            AutoID();

            dtpSchedule.CustomFormat = "dd MMMM yyyy";
            dtpSchedule.Format = DateTimePickerFormat.Custom;

            dgvData.ColumnCount = 2;
            dgvData.Columns[0].HeaderText = "Member ID";
            dgvData.Columns[1].HeaderText = "Member Name";
            dgvData.AllowUserToAddRows = false;
            dgvData.ReadOnly = true;
            dgvData.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(lblMemberID.Text) && !string.IsNullOrWhiteSpace(lblMemberName.Text))  //Jika Field sudah terisi semua
            {
                bool cari = false; // Data belum ada

                for (int i = 0; i < dgvData.RowCount; i++)
                {
                    if (lblMemberID.Text == dgvData.Rows[i].Cells[0].Value.ToString())
                    {
                        cari = true; //Data sudah ada
                    }
                }

                if (cari == false) //Jika Data belum ada
                {
                    dgvData.Rows.Add(lblMemberID.Text, lblMemberName.Text);

                }
                else  //Jika Data sudah ada
                {
                    MessageBox.Show("Member ID " + lblMemberID.Text + " does exists.", "Add Class Detail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                EmptyDetail();
            }
            else //Jika Field belum terisi semua
            {
                MessageBox.Show("Complete the data!", "Add Class Detail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dgvData.CurrentCell.RowIndex;

            lblMemberID.Text = dgvData.Rows[baris].Cells[0].Value.ToString();
            lblMemberName.Text = dgvData.Rows[baris].Cells[1].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(lblMemberID.Text) && !string.IsNullOrWhiteSpace(lblMemberName.Text))  //Jika Field sudah terisi semua
            {
                bool cari = false; // Data belum ada

                for (int i = 0; i < dgvData.RowCount; i++)
                {
                    if (lblMemberID.Text == dgvData.Rows[i].Cells[0].Value.ToString())
                    {
                        cari = true; //tetapkan cari = true / data sudah ada
                        dgvData.Rows[i].Cells[0].Value = lblMemberID.Text;
                        dgvData.Rows[i].Cells[1].Value = lblMemberName.Text;
                    }
                }

                if (cari == true) //Jika Data sudah ada
                {
                    
                }
                else  //Jika Data belum ada
                {
                    MessageBox.Show("Member ID " + lblMemberID.Text + " does not exists.", "Edit Class Detail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                EmptyDetail();
            }
            else //Jika Field belum terisi semua
            {
                MessageBox.Show("Complete the data!", "Edit Class Detail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(lblMemberID.Text) && !string.IsNullOrWhiteSpace(lblMemberName.Text))  //Jika Field sudah terisi semua
            {
                bool cari = false; // Data belum ada

                for (int i = 0; i < dgvData.RowCount; i++)
                {
                    if (lblMemberID.Text == dgvData.Rows[i].Cells[0].Value.ToString())
                    {
                        cari = true; //tetapkan cari = true / data sudah ada

                        dgvData.Rows.Remove(dgvData.Rows[i]);
                    }
                }

                if (cari == true) //Jika Data sudah ada
                {
                    
                }
                else  //Jika Data belum ada
                {
                    MessageBox.Show("Member ID " + lblMemberID.Text + " does not exists.", "Delete Class Detail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                EmptyDetail();
            }
            else //Jika Field belum terisi semua
            {
                MessageBox.Show("Complete the data!", "Delete Class Detail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            EmptyDetail();
        }

        private void lblClassID_TextChanged(object sender, EventArgs e)
        {
            LoadDataHeader();

            dr = ds.Tables["ClassHeader"].Rows.Find(lblClassID.Text);

            if (dr != null) //Jika baris yang dicari berdasarkan lblPurchaseID pada tabel ada
            {
                //Purchasing.PurchaseHeader
                LoadDataHeaderStaff();

                dr = ds.Tables["joinClassHeaderStaff"].Rows.Find(lblClassID.Text);
                dtpSchedule.Value = DateTime.Parse(dr[4].ToString());
                lblStaffID.Text = dr[2].ToString();
                lblStaffName.Text = dr[3].ToString();
                //Purchasing.PurchaseDetail
                LoadDataDetailMember();

                dgvData.Rows.Clear();
                foreach (DataRow dr in ds.Tables["joinClassDetailMember"].Rows)
                {
                    dgvData.Rows.Add(dr[1], dr[2]);
                }
            }
            else //Jika baris yang dicari berdasarkan lblPurchaseID pada tabel tidak ada
            {
                dtpSchedule.Value = DateTime.Today;
                lblStaffID.Text = string.Empty;
                lblStaffName.Text = string.Empty;
                dgvData.Rows.Clear();

                EmptyDetail();
            }
        }

        private void btnSaveHeader_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(lblClassID.Text) && !string.IsNullOrWhiteSpace(lblStaffID.Text))
            {
                LoadDataHeader();

                dr = ds.Tables["ClassHeader"].Rows.Find(lblClassID.Text); //Cari baris pada tabel Purchasing.PurchaseHeader di dataset berdasarkan lblPurchaseID
                if (dr == null) //Jika baris belum ada
                {
                    //Tambah baris pada tabel Purchasing.PurchaseHeader
                    dr = ds.Tables["ClassHeader"].NewRow();
                    dr[0] = lblClassID.Text;
                    dr[1] = txtClassName.Text;
                    dr[2] = lblStaffID.Text;
                    dr[3] = dtpSchedule.Value;
                    dr[4] = txtStart.Text;
                    dr[5] = txtEnd.Text;
                    
                    ds.Tables["ClassHeader"].Rows.Add(dr);
                    UpdateDataHeader();

                    //Tambah baris pada tabel Purchasing.PurchaseDetail
                    for (int i = 0; i < dgvData.RowCount; i++)
                    {
                        LoadDataDetail();

                        dr = ds.Tables["ClassDetail"].NewRow();
                        dr[0] = lblClassID.Text;
                        dr[1] = dgvData.Rows[i].Cells[0].Value; //Member ID
                        ds.Tables["ClassDetail"].Rows.Add(dr);
                        UpdateDataDetail();

                    }
                    MessageBox.Show("Class ID " + lblClassID.Text + " has been saved.", "Save Class Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EmptyHeader();
                }
                else //Jika baris sudah ada
                {
                    //Update baris pada tabel Purchasing.PurchaseHeader
                    dr[1] = txtClassName.Text;
                    dr[2] = lblStaffID.Text;
                    dr[3] = dtpSchedule.Value;
                    dr[4] = txtStart.Text;
                    dr[5] = txtEnd.Text;
                    UpdateDataHeader();

                    //Perbaharui stock pada tabel Production.Inventory
                    //Perlu LoadDataDetailberdasarkanPurchaseID untuk mendapatkan ProductID dan Qty dari pembelian sebelumnya
                    LoadDataDetailberdasarkanClassID();

                    foreach (DataRow baris in ds.Tables["ClassDetail"].Rows)
                    {
                        string memberID = baris[1].ToString();
                    }

                    LoadDataDetailberdasarkanClassID();

                    //Hapus seluruh baris pada tabel Purchasing.PurchaseDetail (pembelian sebelumnya)
                    foreach (DataRow baris in ds.Tables["ClassDetail"].Rows)
                    {
                        baris.Delete();
                    }
                    UpdateDataDetail();

                    //Tambah ulang baris pada tabel Purchasing.PurchaseDetail
                    for (int i = 0; i < dgvData.RowCount; i++)
                    {
                        LoadDataDetail();

                        dr = ds.Tables["ClassDetail"].NewRow();
                        dr[0] = lblClassID.Text;
                        dr[1] = dgvData.Rows[i].Cells[0].Value; 
                        ds.Tables["ClassDetail"].Rows.Add(dr);
                        UpdateDataDetail();

                    }
                    MessageBox.Show("Class ID " + lblClassID.Text + " has been saved.", "Save Class Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EmptyHeader();

                }
            }
            else
            {
                MessageBox.Show("Complete the data!", "Save Class Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteHeader_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(lblClassID.Text) && !string.IsNullOrWhiteSpace(lblStaffID.Text))
            {
                LoadDataHeader();

                dr = ds.Tables["ClassHeader"].Rows.Find(lblClassID.Text); //Cari baris pada tabel Purchasing.PurchaseHeader di dataset berdasarkan lblPurchaseID
                if (dr != null) //Jika baris belum ada
                {
                    LoadDataDetailberdasarkanClassID();

                    foreach (DataRow baris in ds.Tables["ClassDetail"].Rows)
                    {
                        string productID = baris[1].ToString();
                    }

                    LoadDataDetailberdasarkanClassID();

                    //Hapus seluruh baris pada tabel Purchasing.PurchaseDetail (pembelian sebelumnya)
                    foreach (DataRow baris in ds.Tables["ClassDetail"].Rows)
                    {
                        baris.Delete();
                    }
                    UpdateDataDetail();

                    //Hapus baris pada tabel Purchasing.PurchaseHeader (pembelian sebelumnya)
                    LoadDataHeader();

                    dr = ds.Tables["ClassHeader"].Rows.Find(lblClassID.Text);
                    if (dr != null)
                    {
                        dr.Delete();
                        UpdateDataHeader();
                    }
                    MessageBox.Show("Class ID " + lblClassID.Text + " has been deleted.", "Delete Class Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EmptyHeader();
                }
                else //Jika baris sudah ada
                {
                    MessageBox.Show("Class ID " + lblClassID.Text + " does not exists.", "Delete Class Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EmptyHeader();
                }
            }
            else
            {
                MessageBox.Show("Complete the data!", "Delete Class Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
