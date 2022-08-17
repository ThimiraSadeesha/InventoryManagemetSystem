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
    public partial class ManagestckFrom : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        Dbconnect dbcon = new Dbconnect();
      //  SqlDataReader dr;
        SqlDataReader DR;
       // Brand brand;
        public ManagestckFrom()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            loadBrand();
            //brand = br;
        }

        public void loadBrand()
        {
            int i = 0;
            dgvCate.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM brandTB ORDER BY Brand ",cn);
            DR = cm.ExecuteReader();
            while (DR.Read())
            {
                i++;
                dgvCate.Rows.Add(i, DR["ID"].ToString(), DR["Brand"].ToString());
            }
            DR.Close();
            cn.Close();
        }

        private void ManagestckFrom_Load(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            StockModule moduleform = new StockModule(this);
            moduleform.ShowDialog();

        }

        private void dgvCate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //to edit or delete entry data
            string colName = dgvCate.Columns[e.ColumnIndex].Name;
            if (colName== "Delete")
            {
                if (MessageBox.Show("are you want to delete this record ?","Delete Record",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM brandTB WHERE ID Like '" + dgvCate[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Brand has been Deleted.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
            }
            else if (colName=="Edit")
            {
                StockModule stockmodule = new StockModule(this);
                stockmodule.lblID.Text = dgvCate[1, e.RowIndex].Value.ToString();
               stockmodule .txtbrand.Text =dgvCate[2, e.RowIndex].Value.ToString();
                stockmodule.btnsave.Enabled = false;
                stockmodule.btnedit.Enabled = true;
                stockmodule.ShowDialog();
            }
            loadBrand();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
