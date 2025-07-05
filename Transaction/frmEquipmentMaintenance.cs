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
    public partial class frmEquipmentMaintenance : Form
    {
        public frmEquipmentMaintenance()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        frmMain mainMenu;
        public frmEquipmentMaintenance(frmMain mainMenu)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
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
            query = "SELECT * FROM MaintenanceEquipment WHERE logID IN (SELECT MAX(logID) FROM MaintenanceEquipment) ORDER BY logID DESC";
            cmd = new SqlCommand(query, con);
            dl = cmd.ExecuteReader();
            dl.Read();

            if (dl.HasRows)
            {
                hitung = Convert.ToInt64(dl[0].ToString().Substring(dl["logID"].ToString().Length - 2, 2)) + 1; //2
                string joinstr = "00" + hitung; // 002
                urut = "MTC00000" + joinstr.Substring(joinstr.Length - 2, 2); //PRO0000002
            }
            else
            {
                urut = "MTC0000001";
            }
            dl.Close();
            lblLogID.Text = urut;
        }

        private void LoadDataMaintenance()
        {
            ds = new DataSet();
            query = "SELECT * FROM MaintenanceEquipment";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "MaintenanceEquipment");
            dc[0] = ds.Tables["MaintenanceEquipment"].Columns[0];
            ds.Tables["MaintenanceEquipment"].PrimaryKey = dc;
        }

        private void LoadDataStaff()
        {
            ds = new DataSet();
            query = "SELECT * FROM Staff";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Staff");
            dc[0] = ds.Tables["Staff"].Columns[0];
            ds.Tables["Staff"].PrimaryKey = dc;
        }

        private void LoadDataEquipment()
        {
            ds = new DataSet();
            query = "SELECT * FROM Equipment";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Equipment");
            dc[0] = ds.Tables["Equipment"].Columns[0];
            ds.Tables["Equipment"].PrimaryKey = dc;
        }

        private void UpdateDataMaintenance()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds.Tables["MaintenanceEquipment"]);
        }

        private void UpdateDataStaff()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds.Tables["Staff"]);
        }

        private void UpdateDataEquipment()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds.Tables["Equipment"]);
        }

        private void Empty()
        {
            AutoID();

            lblStaffID.Text = string.Empty;
            lblStaffName.Text = string.Empty;
            dtpMaintainDate.Value = DateTime.Now;
            lblEquipmentID.Text = string.Empty;
            lblEquipmentName.Text = string.Empty;
            lblCategory.Text = string.Empty;
            lblCurrentCondition.Text = string.Empty;
            rtbMaintenanceDetail.Text = string.Empty;
        }

        private void frmEquipmentMaintenance_Load(object sender, EventArgs e)
        {
            Connection();
            AutoID();

            dtpMaintainDate.CustomFormat = "dd MMMM yyyy";
            dtpMaintainDate.Format = DateTimePickerFormat.Custom;
            dtpMaintainDate.Value = DateTime.Now;

            cboCondition.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCondition.Items.Add("Good");
            cboCondition.Items.Add("Need Repairs");
            cboCondition.Items.Add("Defective");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblLogID.Text) ||
        string.IsNullOrWhiteSpace(lblStaffID.Text) ||
        string.IsNullOrWhiteSpace(lblEquipmentID.Text) ||
        string.IsNullOrWhiteSpace(rtbMaintenanceDetail.Text))
            {
                MessageBox.Show("All fields must be filled before adding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadDataMaintenance();

            dr = ds.Tables["MaintenanceEquipment"].Rows.Find(lblLogID.Text);
            if (dr == null)
            {
                dr = ds.Tables["MaintenanceEquipment"].NewRow();
                dr[0] = lblLogID.Text;
                dr[1] = lblStaffID.Text;
                dr[2] = dtpMaintainDate.Value;
                dr[3] = lblEquipmentID.Text;
                dr[4] = rtbMaintenanceDetail.Text;
                ds.Tables["MaintenanceEquipment"].Rows.Add(dr);
                UpdateDataMaintenance();
                MessageBox.Show("Maintenance ID " + lblLogID.Text + " has been added.", "Add Maintenance", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Empty();
            }
            else
            {
                MessageBox.Show("Maintenance ID " + lblLogID.Text + " exists in database.", "Add Maintenance", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Empty();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblLogID.Text) ||
         string.IsNullOrWhiteSpace(lblStaffID.Text) ||
         string.IsNullOrWhiteSpace(lblEquipmentID.Text) ||
         string.IsNullOrWhiteSpace(rtbMaintenanceDetail.Text))
            {
                MessageBox.Show("All fields must be filled before editing.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadDataMaintenance();

            dr = ds.Tables["MaintenanceEquipment"].Rows.Find(lblLogID.Text);
            if (dr != null)
            {
                dr[1] = lblStaffID.Text;
                dr[2] = dtpMaintainDate.Value;
                dr[3] = lblEquipmentID.Text;
                dr[4] = rtbMaintenanceDetail.Text;
                UpdateDataMaintenance();
                MessageBox.Show("Maintenance ID " + lblLogID.Text + " has been edited.", "Edit Maintenance", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Empty();
            }
            else
            {
                MessageBox.Show("Maintenance ID " + lblLogID.Text + " does not exist in database.", "Edit Maintenance", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Empty();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblLogID.Text))
            {
                MessageBox.Show("Maintenance ID must be filled before deleting.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadDataMaintenance();

            dr = ds.Tables["MaintenanceEquipment"].Rows.Find(lblLogID.Text);
            if (dr != null)
            {
                dr.Delete();
                UpdateDataMaintenance();
                MessageBox.Show("Maintenance ID " + lblLogID.Text + " has been deleted.", "Delete Maintenance", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Empty();
            }
            else
            {
                MessageBox.Show("Maintenance ID " + lblLogID.Text + " does not exist in database.", "Delete Maintenance", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Empty();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Empty();
        }

        private void btnBrowseMaintenance_Click(object sender, EventArgs e)
        {
            Transaction.frmBrowseMaintenance transactionBrowseMaintenance = new Transaction.frmBrowseMaintenance(this);
            transactionBrowseMaintenance.Tag = this;
            transactionBrowseMaintenance.ShowDialog();
        }

        private void btnBrowseStaff_Click(object sender, EventArgs e)
        {
            Master.frmBrowseStaff masterStaff = new Master.frmBrowseStaff(this);
            masterStaff.Tag = this;
            masterStaff.ShowDialog();
        }

        private void btnBowseEquipment_Click(object sender, EventArgs e)
        {
            Master.frmBrowseEquipment masterEquipment = new Master.frmBrowseEquipment(this);
            masterEquipment.Tag = this;
            masterEquipment.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LoadDataEquipment();

            dr = ds.Tables["Equipment"].Rows.Find(lblEquipmentID.Text);
            if (dr != null) // Jika baris yang dicari berdasarkan lblProductID sudah ada
            {


                dr[4] = cboCondition.SelectedItem.ToString();

                UpdateDataEquipment();
                MessageBox.Show("Equipment ID " + lblEquipmentID.Text + " condition has been updated.", "Update Equipment Condition", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboCondition.SelectedIndex = -1;
            }
            else // Jika baris yang dicari berdasarkan lblProductID belum ada
            {
                MessageBox.Show("Equipment ID " + lblEquipmentID.Text + " does not exists in database.", "Update Equipment Condition", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboCondition.SelectedIndex = -1;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cboCondition.SelectedIndex = -1;
        }
    } 
} 
