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
    public partial class Useraccount : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        Dbconnect dbcon = new Dbconnect();
        SqlDataReader DR;
        public Useraccount()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
        }
        public void Clear()
        {
            txtusername.Clear();
            txtpswrd.Clear();
            txtrepass.Clear();
            txtfullnme.Clear();
            cmbrole.Text = "";
            txtusername.Focus();
        }

        private void btnaccsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtpswrd.Text!=txtrepass.Text)
                {
                    MessageBox.Show("Password did not Mach !", "Saved Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                cn.Open();
                cm = new SqlCommand("Insert into usersTB(username,password,role,name)Values (@username,@password,@role,@name)", cn);
                cm.Parameters.AddWithValue("@username", txtusername.Text);
                cm.Parameters.AddWithValue("@password", txtpswrd.Text);
                cm.Parameters.AddWithValue("@role", cmbrole.Text);
                cm.Parameters.AddWithValue("@name", txtfullnme.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("New Account has been successfully Saved !", "Saved Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Warning");
            }
        }

        private void btnaccclose_Click(object sender, EventArgs e)
        { 
            Clear();
        }
    }
}
