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
    public partial class ProductStockin : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        Dbconnect dbcon = new Dbconnect();
        SqlDataReader DR;
        //string stitle = "Point Of Sales";
        Stockin stockin;
        public ProductStockin(Stockin stk)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            loadProduct();
            stockin = stk;
        }

        private void btnaccclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void loadProduct()
        {
            int i = 0;
            dgvProductstk.Rows.Clear();
            cm = new SqlCommand("SELECT ProCode,ProDes,proQti FROM productTB  WHERE ProDes LIKE '%" + txtsearch.Text + "%'", cn);
            cn.Open();
            DR = cm.ExecuteReader();
            while (DR.Read())
            {
                i++;
                dgvProductstk.Rows.Add(i, DR[0].ToString(), DR[1].ToString(), DR[2].ToString());

            }
            DR.Close();
            cn.Close();
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvProductstk.Columns[e.ColumnIndex].Name;
            if (colName=="Select")
            {
                if (stockin.txtstockinby.Text==string.Empty)
                {    
                    MessageBox.Show("Please enter stock in  by name !", "STOCKS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    stockin.txtstockinby.Focus();
                    this.Dispose();
                    return;
                }
                if (MessageBox.Show("Add this item ?", "ADD ITEMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        cn.Open();
                        cm = new SqlCommand("INSERT INTO StockinTB (refno,ProCode,sdate,stockinby,supplied) VALUES  (@refno,@ProCode,@sdate,@stockinby,@supplied)", cn);
                        cm.Parameters.AddWithValue("@refno",stockin.txtrefno.Text);   
                        cm.Parameters.AddWithValue("@ProCode", dgvProductstk .Rows[e.RowIndex].Cells[1].Value.ToString());
                        cm.Parameters.AddWithValue("@sdate", stockin.dtstockin.Value);
                        cm.Parameters.AddWithValue("@stockinby", stockin.txtstockinby.Text);
                        cm.Parameters.AddWithValue("@supplied", stockin.lblsupplierid.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        stockin.LoadStockIn();


                    }
                    catch (Exception EX)
                    {

                        MessageBox.Show(EX.Message ,"Point Of Sale");                    }
                    
                }

            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            loadProduct();
        }
    }
}
