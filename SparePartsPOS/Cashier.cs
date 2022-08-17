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
    public partial class Cashier : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        Dbconnect dbcon = new Dbconnect();

        int qty;
        string id;
        string price;
        String stitle = "Point of sales";
        public double pricee;

        SqlDataReader DR;
        public Cashier()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            GetTransNo();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit this Application?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();

            }
        }
        public void slide(Button button)
        {
            panel7Slide.BackColor = Color.White;
            panel7Slide.Height = button.Height;
            panel7Slide.Top = button.Top;

        }
        #region Button
        private void btnnewtrns_Click(object sender, EventArgs e)
        {
            slide(btnnewtrns);
            GetTransNo();
        }

        private void btnnewserchpro_Click(object sender, EventArgs e)
        {
            slide(btnnewserchpro);
            LookupProduct lookup = new LookupProduct(this);
            lookup.loadProduct();
            lookup.ShowDialog();
            
        }

        private void btnnewdis_Click(object sender, EventArgs e)
        {
            Discount dsc = new Discount(this);
            dsc.lbid.Text = id;
            dsc.txttotalprice.Text = price;
            dsc.ShowDialog();
            slide(btnnewdis);
        }

        private void btnsttlepay_Click(object sender, EventArgs e)
        {
           // slide(btnsttlepay);
        }

        private void btnclearcrt_Click(object sender, EventArgs e)
        {
          //  slide(btnclearcrt);
        }

        private void btndalysale_Click(object sender, EventArgs e)
        {
            //slide(btndalysale);
        }

        private void btnnwchngepw_Click(object sender, EventArgs e)
        {
            ChangePassword psw = new ChangePassword();
            psw.ShowDialog();
            slide(btnnwchngepw);

        }

        private void btnnwlogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Log Out Application ?", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Hide();
                login Log = new login();
                Log.Show();
            }
            slide(btnnwlogout);
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }

        private void lbltimer_Click(object sender, EventArgs e)
        {

        }
        #endregion Button
        public void Loadcart()
        {
            try
            {
                int i = 0;
                double total = 0.00;
                double discount = 0.00;

                dgvcashi.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("SELECT c.id,c.ProCode,p.ProDes,c.price, c.qty, c.disc, c.total FROM TBCartnew AS c INNER JOIN productTB AS p ON c.ProCode=p.ProCode WHERE c.transno LIKE @transno and c.status LIKE 'pending'", cn);
                cm.Parameters.AddWithValue("@transno", lblTransNo.Text);
                DR = cm.ExecuteReader();
                while (DR.Read())
                {
                    i++;
                    total += Convert.ToDouble(DR["total"]);
                    discount += Convert.ToDouble(DR["disc"].ToString());
                    dgvcashi.Rows.Add(i, DR["id"].ToString(), DR["ProCode"].ToString(), DR["ProDes"].ToString(), DR["price"].ToString(), DR["qty"].ToString(), DR["disc"].ToString(), double.Parse(DR["total"].ToString()).ToString("#,##0.00"));

                }
                //DR.Close();
                cn.Close();
                lblSalestotal.Text = total.ToString("#,##0.00");
                lbldiscount.Text = discount.ToString("#,##0.00");
                GetcartTotal();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "POINT OF SALE");
            }
            
        }

        public void GetcartTotal()
        {
            double discount = double.Parse(lbldiscount.Text);
            double sales = double.Parse(lblSalestotal.Text) - discount;
            double tax = sales * 0.12;//vat 12%
            pricee = (sales + tax);
            //double priceAfterDiscount = price - discount;

            lbltax.Text = tax.ToString("#,##0.00");
            lblSalestotal.Text = sales.ToString("#,##0.00");
            lblPrice.Text = pricee.ToString("#,##0.00");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltimer.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
        public void GetTransNo()
        {
            try
            {
                string sdate = DateTime.Now.ToString("yyyMMdd");
                string transno = sdate + "1001";
                lblTransNo.Text = transno;
                int count;
                cn.Open();
                cm = new SqlCommand("SELECT TOP 1 transno FROM TBCartnew WHERE transno LIKE '" + sdate + "%' ORDER BY id desc", cn);
                DR = cm.ExecuteReader();
                DR.Read();
                if (DR.HasRows)
                {
                    transno = DR[0].ToString();
                    count = int.Parse(transno.Substring(8, 4));
                    lblTransNo.Text = sdate + (count + 1);
                }
                else
                {
                    transno = sdate + "1001";
                    lblTransNo.Text = transno;
                }
                DR.Close();
                cn.Close();
            }
            catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message,stitle);
            }
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBarcode.Text == string.Empty) return;
                else
                {
                    string _pcode;
                    double _price;
                    int _qty;
                    cn.Open();
                    cm = new SqlCommand("SELECT * FROM productTB WHERE BarCode LIKE '" + txtBarcode.Text + "'", cn);
                    DR = cm.ExecuteReader();
                    DR.Read();
                    if (DR.HasRows)
                    {
                        qty = int.Parse(DR["proQti"].ToString());
                        _pcode= (DR["ProCode"].ToString());
                        _price = double.Parse(DR["ProPrice"].ToString());
                        _qty = int.Parse(txtcqty.Text);
                       
                        DR.Close();
                        cn.Close();
                       // inser to tb cart
                        AddCart(_pcode, _price, _qty);
                    }

                }
                DR.Close();
                cn.Close();

            }
            catch (Exception EX)
            {
                cn.Close();

                MessageBox.Show(EX.Message, "POINT OF SALE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void AddCart(string _pcode,double _price,int _qty )
        {
            try
            {
                string id = "";
                int cart_qty = 0;
                bool found = false;
                cn.Open();
                cm = new SqlCommand("SELECT * FROM TBCartnew WHERE transno=@transno and ProCode=@ProCode ",cn);
                cm.Parameters.AddWithValue("@transno", lblTransNo.Text);
                cm.Parameters.AddWithValue("@ProCode", _pcode);
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
                    if (qty < (int.Parse(txtcqty.Text) + cart_qty))
                    {

                        MessageBox.Show("Unabale to Process reaming qty on  hand is" + qty, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    cn.Open();
                    cm = new SqlCommand("UPDATE TBCartnew SET qty=(qty+" + _qty + ")Where id ='" + id + "'", cn);
                    cm.ExecuteReader();
                    cn.Close();
                    txtBarcode.SelectionStart = 0;
                    txtBarcode.SelectionLength = txtBarcode.Text.Length;
                    Loadcart();

                }
                else
                {
                    if (qty < (int.Parse(txtcqty.Text) + cart_qty))
                    {

                        MessageBox.Show("Unabale to Process reaming qty on  hand is " + qty, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO TBCartnew (transno,ProCode,price,qty,sdate,cashier) VALUES (@transno,@ProCode,@price,@qty,@sdate,@cashier)", cn);
                    cm.Parameters.AddWithValue("@transno", lblTransNo.Text);
                    cm.Parameters.AddWithValue("@ProCode", _pcode);
                    cm.Parameters.AddWithValue("@price", _price);
                    cm.Parameters.AddWithValue("@qty", 1);
                    cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                    cm.Parameters.AddWithValue("@cashier", lblUsername.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    Loadcart();
                }
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message, "POINT OF SALE"); 
            }
        }

        private void dgvcashi_SelectionChanged(object sender, EventArgs e)
        {
            int i = dgvcashi.CurrentRow.Index;
            id = dgvcashi[1, i].Value.ToString();
            price = dgvcashi[7, i].Value.ToString();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            Recipt receipt = new Recipt();
            receipt.lbltrans.Text = lblTransNo.Text;
            receipt.lblprice.Text = lblSalestotal.Text;
            receipt.lbltax.Text = lbltax.Text;
            receipt.lbldisc.Text = lbldiscount.Text;
            receipt.lbltotal.Text = lblPrice.Text;
            receipt.ShowDialog();
            this.Hide();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
