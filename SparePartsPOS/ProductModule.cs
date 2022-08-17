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
    public partial class ProductModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        Dbconnect dbcon = new Dbconnect();
        string stitle = "Point Of Sales";
        Product product;
        public ProductModule(Product pd)
        {
            InitializeComponent();
            product = pd;
            cn = new SqlConnection(dbcon.myConnection());
            loadBrand();
            loadCategory();
        }
        public void loadCategory()
        {
            cmbCategory.Items.Clear();
            cmbCategory.DataSource = dbcon.GetTable("SELECT* FROM categoryTB");
            cmbCategory.DisplayMember = "Category";
            cmbCategory.ValueMember = "ID";
        }
        public void loadBrand()
        {
            cmbBrand.Items.Clear();
            cmbBrand.DataSource = dbcon.GetTable("SELECT* FROM brandTB");
            cmbBrand.DisplayMember = "Brand";
            cmbBrand.ValueMember = "ID";
             
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProductModule_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void Clear()
        {
            txtproductCode.Clear();
            txtDescrp.Clear();
            txtprice.Clear();
            txtbarcode.Clear();
            cmbBrand.SelectedItem = 0;
            cmbCategory.SelectedItem = 0;
            numOrdr.Value = 1;

            txtproductCode.Enabled = true;
            txtproductCode.Focus();
            btnsave.Enabled = true;
            btnupdate.Enabled = false;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you want to Add this Product ?", "Add product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO productTB (ProCode,BarCode,ProDes,BrndID,CateID,ProPrice,ProReordr)VALUES(@ProCode,@BarCode,@ProDes,@BrndID,@CateID,@ProPrice,@ProReordr)", cn);
                    cm.Parameters.AddWithValue("@ProCode", txtproductCode.Text);
                    cm.Parameters.AddWithValue("@BarCode", txtbarcode.Text);
                    cm.Parameters.AddWithValue("@ProDes", txtDescrp.Text);
                    cm.Parameters.AddWithValue("@BrndID", cmbBrand.SelectedValue);
                    cm.Parameters.AddWithValue("@CateID", cmbCategory.SelectedValue);
                    cm.Parameters.AddWithValue("@ProPrice", double.Parse (txtprice.Text));
                    cm.Parameters.AddWithValue("@ProReordr", numOrdr.Value);
                    cn.Open();
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product has been Successfully Saved", stitle);
                    Clear();
                    product.loadProduct();

                }

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
            try
            {
                if (MessageBox.Show("Are you want to Update this Product ?", "Update Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE productTB SET Barcode=@Barcode,ProDes=@ProDes,BrndID@BrndID,CateID@CateID,ProPrice@ProPrice,ProReordr@ProReordr WHERE ProCode LIKE @ProCode ", cn);
                    cm.Parameters.AddWithValue("@ProCode", txtproductCode.Text);
                    cm.Parameters.AddWithValue("@BarCode", txtbarcode.Text);
                    cm.Parameters.AddWithValue("@ProDes", txtDescrp.Text);
                    cm.Parameters.AddWithValue("@BrndID", cmbBrand.SelectedValue);
                    cm.Parameters.AddWithValue("@CateID", cmbCategory.SelectedValue);
                    cm.Parameters.AddWithValue("@ProPrice", double.Parse(txtprice.Text));
                    cm.Parameters.AddWithValue("@ProReordr", numOrdr.Value);
                    cn.Open();
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product has been  successfully Updated !", stitle);
                    Clear();
                    this.Dispose();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
