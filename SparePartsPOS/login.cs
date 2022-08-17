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

namespace SparePartsPOS
{
    public partial class login : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        Dbconnect dbcon = new Dbconnect();
        SqlDataReader DR;
        public string _pass="";
        public bool _isactive;
        public login()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            txtlogusername.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want exit this Application ?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)==DialogResult.Yes)
            {
                Application.Exit();
            }

            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string _username = "", _name = "", _role = "";
            try
            {
                bool found;
                cn.Open();
                cm = new SqlCommand("Select * From usersTB Where username = @username and password=@password", cn);
                cm.Parameters.AddWithValue("@username", txtlogusername.Text);
                cm.Parameters.AddWithValue("@password", txtlogpasswrd.Text);
                DR = cm.ExecuteReader();
                DR.Read();  
                if (DR.HasRows)
                {
                    found = true;
                    _username = DR["username"].ToString();
                   _name = DR["name"].ToString();
                    _role = DR["role"].ToString();
                    _pass = DR["password"].ToString();
                    _isactive = bool.Parse(DR["isactive"].ToString());

                }
                else
                {
                    found = false;
                }
                DR.Close();
                cn.Close();
                if (found)
                {
                    if (!_isactive)
                    {
                        MessageBox.Show("Account is Inactive.Unable to Login","INACTIVE ACCOUNT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (_role=="Cashier")
                    {
                        MessageBox.Show("Welcome "+_name + "|", "ACCESS GRANNTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtlogusername.Clear();
                        txtlogpasswrd.Clear();
                        this.Hide();
                       Cashier cashier = new Cashier();
                       cashier.lblUsername.Text = _username;
                       cashier.lblname.Text = _name + "  " + _role;
                       cashier.ShowDialog();
                    }
                    else
                    {
                        //adminlogin
                        MessageBox.Show("Welcome  " + _name + "|", "ACCESS GRANNTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtlogusername.Clear();
                        txtlogpasswrd.Clear();
                        this.Hide();
                        MainForm main = new MainForm();
                        main.lblUsernme.Text = _username;
                        main.lblnme.Text = _name;
                        main.ShowDialog();
                         
                    }

                }
                else
                {
                    MessageBox.Show("Invalid Username Or Password", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                      
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void txtlogpasswrd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                btnLogin.PerformClick();
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
