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
    public partial class CategoryModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        Dbconnect dbcon = new Dbconnect();
        Category category;
        public CategoryModule(Category ct)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            category = ct;
        }

        private void CategoryModule_Load(object sender, EventArgs e)
        {

        }
        public void Clear()
        {
            txtCate.Clear();
            txtCate.Focus();
            btnsave.Enabled = true;
            btnupdate.Enabled = false;

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this Category ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO categoryTB (Category)VALUES(@Category) ", cn);
                    cm.Parameters.AddWithValue("@Category", txtCate.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Category has been successful saved.", "Point Of Sales");
                    Clear();
                  

                }
                category.loadCategory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to Update this Category ?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("UPDATE categoryTB SET Category =@Category WHERE ID LIKE'" + lblID.Text + "'", cn);
                cm.Parameters.AddWithValue("@Category", txtCate.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Category has been Successfully Updated", "Point Of Sales");
                Clear();
                this.Dispose();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
