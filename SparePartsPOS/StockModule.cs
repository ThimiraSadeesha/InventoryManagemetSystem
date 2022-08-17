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
    public partial class StockModule : Form
    {

       SqlConnection cn = new SqlConnection();
       SqlCommand cm = new SqlCommand();
        Dbconnect dbcon = new Dbconnect();
        ManagestckFrom brand;


        public StockModule(ManagestckFrom br)
        {
            InitializeComponent();
           cn = new SqlConnection(dbcon.myConnection());
            brand = br;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Clear();
            //this.Dispose();
        }
        public void Clear()
        {
            txtbrand.Clear();
            btnedit.Enabled = false;
            btnsave.Enabled = true;
            txtbrand.Focus();
        }


        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this brand ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                   cn.Open();
                   cm=new SqlCommand("INSERT INTO brandTB (Brand)VALUES(@Brand) ", cn);
                   cm.Parameters.AddWithValue("@Brand", txtbrand.Text);
                   cm.ExecuteNonQuery();
                   cn.Close();
                   MessageBox.Show("Record has been successful saved.","POS");
                   Clear();
                    brand.loadBrand();

                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to Update this Brand ?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("UPDATE brandTB SET Brand =@Brand WHERE ID LIKE'" + lblID.Text + "'", cn);
                cm.Parameters.AddWithValue("@Brand", txtbrand.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Brand has been Successfully Updated", "POS");
                Clear();
                this.Dispose();

            }
        }

        private void StockModule_Load(object sender, EventArgs e)
        {

        }
    }
}
