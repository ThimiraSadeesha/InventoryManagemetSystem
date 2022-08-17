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
    public partial class Stockin : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        Dbconnect dbcon = new Dbconnect();
        SqlDataReader DR;

        public Stockin()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            loadSupplier();
            GetRefNo();
        }
        public void GetRefNo()
        {
            Random rnd = new Random();
            txtrefno.Clear();
            txtrefno.Text += rnd.Next();

        }

        public void loadSupplier()
        {
            cmbsupplier.Items.Clear();
            cmbsupplier.DataSource =dbcon.GetTable("SELECT * FROM supplierTB");
            cmbsupplier.DisplayMember = "supplier";
        }
        public void LoadStockIn()
        {
            int i = 0;
            dgvstockin.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM vwstockin WHERE refno LIKE '" + txtrefno.Text + "'AND status LIKE 'pending'", cn);
            DR = cm.ExecuteReader();
            while (DR.Read())
            {
                i++;
                dgvstockin.Rows.Add(i, DR[0].ToString(), DR[1].ToString(), DR[2].ToString(), DR[3].ToString(), DR[4].ToString(), DR[5].ToString(), DR[6].ToString(), DR[7].ToString());


            }
            DR.Close();
            cn.Close();

        }

        private void cmbsupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("SELECT *  FROM supplierTB WHERE supplier LIKE '" + cmbsupplier.Text + "'", cn);
            DR = cm.ExecuteReader();
            DR.Read();
            if (DR.HasRows)
            {
                lblsupplierid.Text = DR["id"].ToString();
                txtconpersn.Text = DR["contacperson"].ToString();
                txtrefaddrs.Text = DR["address"].ToString();

            }
            DR.Close();
            cn.Close();
        }

        private void cmbsupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void linkgenrate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GetRefNo();
        }

        private void linkclickhere_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProductStockin productstk = new ProductStockin(this);
            productstk.Show();
        }

        private void btnstccksave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvstockin.Rows.Count>0) 
                {
                    if ((MessageBox.Show("Are you sure you want save this record", "ADD RECORD", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        for (int i = 0;i<dgvstockin.Rows.Count; i++)
                        {
                            //update product qntyty
                            cn.Open();
                            cm = new SqlCommand("UPDATE productTB SET proQti = proQti +" + int.Parse(dgvstockin.Rows[i].Cells[5].Value.ToString()) +" WHERE ProCode LIKE'" + dgvstockin.Rows[i].Cells[3].Value.ToString() +"'",cn);
                            cm.ExecuteNonQuery();
                            cn.Close();

                            //update stockin qtyty
                            cn.Open();
                            cm = new SqlCommand("UPDATE StockinTB SET qty = Qty +" + int.Parse(dgvstockin.Rows[i].Cells[5].Value.ToString()) + ", status ='Done' WHERE id LIKE '" + dgvstockin.Rows[i].Cells[1].Value.ToString() + "'", cn);
                            cm.ExecuteNonQuery();
                            cn.Close();

                        }
                        Clear();
                        LoadStockIn();


                    }

                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Point Of Sale",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        public void Clear()
        {
            txtrefno.Clear();
            txtstockinby.Clear();
            dtstockin.Value = DateTime.Now;
        }

        private void dgvstockin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvstockin.Columns[e.ColumnIndex].Name;
            if (colName=="Delete")
            {
                if (((MessageBox.Show("Remove  this Items ?", "POINT OF SALE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)))
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM StockinTB WHERE id ='" + dgvstockin.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Item has been successfully  removed", "POINT OF SALE ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                    LoadStockIn();
                    cn.Close();

                }
               
            }
        }
    }

}
