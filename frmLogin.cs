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

namespace FitBody
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        SqlConnection con;
        string constr;
        SqlDataAdapter da;
        SqlCommand cmd;
        string query;
        DataSet ds;
        DataRow dr;
        DataColumn[] dc = new DataColumn[1];


        private void Connection()
        {
            try
            {
                constr = "Data Source=MSI\\SQLEXPRESS; Initial Catalog=FitBody; Integrated Security=true";
                con = new SqlConnection(constr);
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            ds = new DataSet();
            query = "SELECT * FROM Admin";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Admin");

            dc[0] = ds.Tables["Admin"].Columns["username"];
            ds.Tables["Admin"].PrimaryKey = dc;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Connection();
            LoadData();
            txtPassword.UseSystemPasswordChar = true;

            this.AcceptButton = btnLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            dr = ds.Tables["Admin"].Rows.Find(txtUsername.Text);

            if (dr != null) //Jika baris yang dicari berdasarkan txtUserID ada
            {
                if (dr[1].ToString() == txtPassword.Text) //Jika baris kolom ke-2 (password) = txtPassword
                {
                    MessageBox.Show("Login Success!, Welcome :)", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else //Jika baris kolom ke-2 (password) != txtPassword
                {
                    MessageBox.Show("Wrong Password!, Please Try Again ;(", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Text = string.Empty;
                    txtPassword.Focus();
                }
            }
            else //Jika baris yang dicari berdasarkan txtUserID tidak ada
            {
                MessageBox.Show("Username " + txtUsername.Text + " Did Not Exist.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = string.Empty;
                txtPassword.Text = string.Empty;
                txtUsername.Focus();
            }
        }
    }
}
