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
    public partial class supplier : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        Dbconnect dbcon = new Dbconnect();
        SqlDataReader DR;
        public supplier()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            loadSupplier();
        }
        public void loadSupplier()
        {
            dgvsuplier.Rows.Clear();
            int i = 0;
            cn.Open();
            cm = new SqlCommand("SELECT * FROM supplierTB ", cn);
            DR = cm.ExecuteReader();
            while (DR.Read())
            {
                i++;
                dgvsuplier.Rows.Add(i, DR[0].ToString(), DR[1].ToString(), DR[2].ToString(), DR[3].ToString(), DR[4].ToString(), DR[5].ToString(), DR[6].ToString());

            }
            DR.Close();
            cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            supplierModule supmod = new supplierModule(this);
            supmod.ShowDialog();
        }

        private void dgvsuplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvsuplier.Columns[e.ColumnIndex].Name;
            if (colName=="Edit")
            {
                supplierModule supp = new supplierModule(this);
                supp.lblID.Text = dgvsuplier.Rows[e.RowIndex].Cells[1].Value.ToString();
                supp.txtsupname.Text = dgvsuplier.Rows[e.RowIndex].Cells[2].Value.ToString();
                supp.txtsupaddrss.Text = dgvsuplier.Rows[e.RowIndex].Cells[3].Value.ToString();
                supp.txtsupcontcper.Text = dgvsuplier.Rows[e.RowIndex].Cells[4].Value.ToString();
                supp.txtsupmobi.Text = dgvsuplier.Rows[e.RowIndex].Cells[5].Value.ToString();
                supp.txtsupmail.Text = dgvsuplier.Rows[e.RowIndex].Cells[6].Value.ToString();
                supp.txtsupfax.Text = dgvsuplier.Rows[e.RowIndex].Cells[7].Value.ToString();
                supp.btnsupsave.Enabled = false;
                supp.btnsupupdate.Enabled = true;
                supp.ShowDialog();


            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Do you want to Delete this Supplier ?", "Supplier Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM supplierTB WHERE id like ' " + dgvsuplier.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been Successfully Saved", "Supplier Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            loadSupplier();
        }
    }
}
