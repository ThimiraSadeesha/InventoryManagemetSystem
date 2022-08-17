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
    public partial class ChangePassword : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        Dbconnect dbcon = new Dbconnect();
        public ChangePassword()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btndissave_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                cn.Open();
                cm = new SqlCommand("UPDATE usersTB SET password=@reTypePassword Where username=@userName", cn);
                cm.Parameters.AddWithValue("@userName", "Cashier");
                cm.Parameters.AddWithValue("@reTypePassword", textBox2.Text);
                cm.ExecuteReader();
                cn.Close();
                MessageBox.Show("Password saved.");
            }
            else
            {
                MessageBox.Show("Passwords do not match.");
            }

        }
    }
}
