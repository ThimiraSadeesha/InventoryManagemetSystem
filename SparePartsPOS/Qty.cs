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
    public partial class Qty : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        Dbconnect dbcon = new Dbconnect();
        SqlDataReader DR;
        private string ProCode;
        private double price;
        private String transno;
        private int qty;

        Cashier cashier;
        //LookupProduct LookupProduct;


        public Qty(Cashier cash)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
           cashier = cash;
        }

        public void productDetails(string ProCode, double price, String transno, int qty)
        {
            this.ProCode = ProCode;
            this.price = price;
            this.transno = transno;
            this.qty = qty;

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Adding Quantyty
            qty = int.Parse(txtQty.Text);
            if ((e.KeyChar == 13) && (txtQty.Text != string.Empty))
            {
                cn.Open();
                cm = new SqlCommand("INSERT INTO TBCartnew (transno,ProCode,price,qty,sdate,cashier) VALUES (@transno,@ProCode,@price,@qty,@sdate,@cashier)", cn);
                cm.Parameters.AddWithValue("@transno", transno);
                cm.Parameters.AddWithValue("@ProCode", ProCode);
                cm.Parameters.AddWithValue("@price", price);
                cm.Parameters.AddWithValue("@qty", int.Parse(txtQty.Text));
                cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                cm.Parameters.AddWithValue("@cashier", cashier.lblUsername.Text);
                cm.ExecuteNonQuery();
                cn.Close();

                /*  cm = new SqlCommand("SELECT * FROM TBCartnew", cn);
                  cn.Open();
                  DR = cm.ExecuteReader();
                  while (DR.Read())
                  {
                      i++;
                      LookupProduct.dgvProduct.Rows.Add(i, DR[0].ToString(), DR[1].ToString(), DR[2].ToString(), DR[3].ToString(), DR[4].ToString(), DR[5].ToString(), DR[6].ToString());

                  }
                  DR.Close();
                  cn.Close();*/

                // cashier.txtBarcode.Clear();
                // cashier.txtBarcode.Focus();
                cashier.Loadcart();
                this.Dispose();
            }


            /*if ((e.KeyChar==13)&&(txtQty.Text!=string.Empty))
            {
                try
                {
                    string id = "";
                    int cart_qty = 0;
                    bool found = false;
                    cn.Open();
                    cm = new SqlCommand("SELECT * FROM TBCartnew WHERE transno=@transno and ProCode=@ProCode ", cn);
                    cm.Parameters.AddWithValue("@transno",transno);
                    cm.Parameters.AddWithValue("@ProCode", ProCode);
                    DR = cm.ExecuteReader();
                    DR.Read();
                    if (DR.HasRows)
                    {
                        id = DR["id"].ToString();
                        cart_qty = int.Parse(DR["qty"].ToString());

                        found = true;
                    }
                    else found = false;
                    DR.Close();
                    cn.Close();

                    if (found)
                    {
                        if (qty < (int.Parse(txtQty.Text) + cart_qty))
                        {

                            MessageBox.Show("Unabale to Process reaming qty on  hand is" + qty, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        cn.Open();
                        cm = new SqlCommand("UPDATE TBCartnew SET qty=(qty+" + int.Parse(txtQty.Text) + ")Where id ='" + id + "'", cn);
                        cm.ExecuteReader();
                        cn.Close();
                        cashier.txtBarcode.Clear();
                        cashier.txtBarcode.Focus();
                        cashier. Loadcart();
                        this.Dispose();

                    }
                    else
                    {
                        if (qty < (int.Parse(txtQty.Text) + cart_qty))
                        {

                            MessageBox.Show("Unabale to Process Reaming qty on hand is " + qty, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        cn.Open();
                        cm = new SqlCommand("INSERT INTO TBCartnew (transno,ProCode,price,qty,sdate,cashier) VALUES (@transno,@ProCode,@price,@qty,@sdate,@cashier)", cn);
                        cm.Parameters.AddWithValue("@transno", transno);
                        cm.Parameters.AddWithValue("@ProCode", ProCode);
                        cm.Parameters.AddWithValue("@price", price);
                        cm.Parameters.AddWithValue("@qty", qty);
                        cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                        cm.Parameters.AddWithValue("@cashier",cashier. lblUsername.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        cashier.txtBarcode.Clear();
                        cashier.txtBarcode.Focus();
                        cashier.Loadcart();
                        this.Dispose();
                    }
                }
                catch (Exception EX)
                {

                    MessageBox.Show(EX.Message, "POINT OF SALE");
                }
            }*/
        }
    }
}
