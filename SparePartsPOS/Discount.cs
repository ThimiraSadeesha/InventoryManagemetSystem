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
    public partial class Discount : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        Dbconnect dbcon = new Dbconnect();
        Cashier cashier;
        public Discount(Cashier cash)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            cashier = cash;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Discount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            {
                this.Dispose(); 

            }
        }

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double disc = double.Parse(txttotalprice.Text) * double.Parse(txtdiscount.Text)*0.01;
                txtdiscountamount.Text = disc.ToString("#,##0.00");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btndissave_Click(object sender, EventArgs e)
        {
            double discountAmount = double.Parse(txtdiscountamount.Text);
            double discountPercentage = double.Parse(txtdiscount.Text);
            try
            {
                if (MessageBox.Show("Add Discount ? Click yes to Confirm", "Point Of Sale", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE TBCartnew SET disc=@disc,discPercent=@discPercent WHERE id=@id", cn);
                    cm.Parameters.AddWithValue("@disc", discountAmount);
                    cm.Parameters.AddWithValue("@discPercent", discountPercentage);
                    cm.Parameters.AddWithValue("@id", lbid.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    cashier.Loadcart();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Point Of Sale");
                
            }

        }
    }
}
