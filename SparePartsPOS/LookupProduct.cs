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
    public partial class LookupProduct : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        Dbconnect dbcon = new Dbconnect();
        SqlDataReader DR;
        Cashier cashier;
        public LookupProduct(Cashier cash)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            loadProduct();
            cashier = cash;
        }

        private void btnlookclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void loadProduct()
        {
            int i = 0;
            dgvProduct.Rows.Clear();
            cm = new SqlCommand("SELECT p.ProCode,p.BarCode,p.ProDes,p.BrndID,p.CateID,p.ProPrice,p.ProQti FROM productTB AS p INNER JOIN brandTB AS b ON b.ID=p.BrndID INNER JOIN categoryTB AS c ON c.ID =P.CateID WHERE CONCAT(p.ProDes,p.BrndID,p.CateID) LIKE '%" + txtprsearch.Text + "%'", cn);
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

        //private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    string colName = dgvProduct.Columns[e.ColumnIndex].Name;
        //    if (colName=="Select")
        //    {
        //        Qty pty = new Qty(cashier);
        //        pty.productDetails(dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString(), double.Parse(dgvProduct.Rows[e.RowIndex].Cells[6].Value.ToString()), cashier.lblTransNo.Text, int.Parse(dgvProduct.Rows[e.RowIndex].Cells[7].Value.ToString()));
        //        pty.ShowDialog();
        //    }
        //}

        private void dgvProduct_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvProduct.Columns[e.ColumnIndex].Name;
            if (colName == "Select")
            {
                Qty pty = new Qty(cashier);
                pty.productDetails(dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString(), double.Parse(dgvProduct.Rows[e.RowIndex].Cells[6].Value.ToString()), cashier.lblTransNo.Text, int.Parse(dgvProduct.Rows[e.RowIndex].Cells[7].Value.ToString()));
                pty.ShowDialog();
            }
        }

        private void txtprsearch_Click(object sender, EventArgs e)
        {

        }

        private void txtprsearch_TextChanged(object sender, EventArgs e)
        {
            loadProduct();
        }

        private void LookupProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            {
                this.Dispose(); 
            }
        }
    }
}
