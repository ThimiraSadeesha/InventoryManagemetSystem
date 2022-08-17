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
    public partial class supplierModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        Dbconnect dbcon = new Dbconnect();
        // SqlDataReader DR;
        supplier Supplier;

        public supplierModule(supplier sp)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            Supplier = sp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void Clear()
        {
            txtsupaddrss.Clear();
            txtsupcontcper.Clear();
            txtsupfax.Clear();
            txtsupmail.Clear();
            txtsupmobi.Clear();
            txtsupname.Clear();

            btnsupsave.Enabled = true;
            btnsupupdate.Enabled = false;
            txtsupname.Focus();
        }

        private void btnsupsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Save this Supplier ?", "SUPPLIER MODULE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO supplierTB (supplier,address,contacperson,phone,email,fax) VALUES (@supplier,@address,@contacperson,@phone,@email,@fax)", cn);
                    cm.Parameters.AddWithValue("@supplier", txtsupname.Text);
                    cm.Parameters.AddWithValue("@address", txtsupaddrss.Text);
                    cm.Parameters.AddWithValue("@contacperson", txtsupcontcper.Text);
                    cm.Parameters.AddWithValue("@phone", txtsupmobi.Text);
                    cm.Parameters.AddWithValue("@email", txtsupmail.Text);
                    cm.Parameters.AddWithValue("@fax", txtsupfax.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                   
                    MessageBox.Show("Record has been Successfullt Saved !", "SUPPLIER MODULE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    Supplier.loadSupplier();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnsupclose_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnsupupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Update this Supplier ?", "SUPPLIER MODULE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE supplierTB SET supplier=@supplier,address=@address,contacperson=@contacperson,phone=@phone,email=@email,fax=@fax WHERE id=@id", cn);
                    cm.Parameters.AddWithValue("@id", lblID.Text);
                    cm.Parameters.AddWithValue("@supplier", txtsupname.Text);
                    cm.Parameters.AddWithValue("@address", txtsupaddrss.Text);
                    cm.Parameters.AddWithValue("@contacperson", txtsupcontcper.Text);
                    cm.Parameters.AddWithValue("@phone", txtsupmobi.Text);
                    cm.Parameters.AddWithValue("@email", txtsupmail.Text);
                    cm.Parameters.AddWithValue("@fax", txtsupfax.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been Successfullt Updted !", "SUPPLIER MODULE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
