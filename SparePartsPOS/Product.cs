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
    public partial class Product : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        Dbconnect dbcon = new Dbconnect();
        SqlDataReader DR;
        public Product()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            loadProduct();
        }
        public void loadProduct()
        {
            int i = 0;
            dgvProduct.Rows.Clear();
            cm = new SqlCommand("SELECT p.ProCode,p.BarCode,p.ProDes,p.BrndID,p.CateID,p.ProPrice,p.ProReordr FROM productTB AS p INNER JOIN brandTB AS b ON b.ID=p.BrndID INNER JOIN categoryTB AS c ON c.ID =P.CateID WHERE CONCAT(p.ProDes,p.BrndID,p.CateID) LIKE '%" + txtsearch.Text+"%'", cn);
            cn.Open();
            DR = cm.ExecuteReader();
            while (DR.Read())
            {
                i++;
                dgvProduct.Rows.Add(i, DR[0].ToString(), DR[1].ToString(), DR[2].ToString(), DR[3].ToString(), DR[4].ToString(), DR[5].ToString(), DR[6].ToString());

            }
            DR.Close();
            cn.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            ProductModule promodule = new ProductModule(this);
            promodule.ShowDialog();
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvProduct.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                ProductModule product = new ProductModule(this);
                product.txtproductCode.Text = dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                product.txtbarcode.Text = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                product.txtDescrp.Text = dgvProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                product.cmbBrand.Text = dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                product.cmbCategory.Text = dgvProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
                product.txtprice.Text = dgvProduct.Rows[e.RowIndex].Cells[6].Value.ToString();
                product.numOrdr.Value = int.Parse(dgvProduct.Rows[e.RowIndex].Cells[7].Value.ToString());

                product.txtproductCode.Enabled = false;
                product.btnsave.Enabled = false;
                product.btnupdate.Enabled = true;
                product.ShowDialog();


            }
            else if (colName=="Delete")
            {
                if (MessageBox.Show("Are you want to Delete this Product ?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM productTB WHERE ProCode Like '" + dgvProduct[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Producty has been  successfully Deleted.", "Point Of Sales", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            loadProduct();
           
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            loadProduct();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
