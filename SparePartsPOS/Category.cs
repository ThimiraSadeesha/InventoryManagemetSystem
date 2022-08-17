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
    public partial class Category : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        Dbconnect dbcon = new Dbconnect();
        SqlDataReader DR;
        public Category()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
        }
        //data recived from tbcategory  to dgvcategory

        public void loadCategory()
        {
            int i = 0;
            dgvCategory.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM categoryTB ORDER BY Category ", cn);
            DR = cm.ExecuteReader();
            while (DR.Read())
            {
                i++;
                dgvCategory.Rows.Add(i, DR["ID"].ToString(), DR["Category"].ToString());
            }
            DR.Close();
            cn.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            CategoryModule catemoduleform = new CategoryModule(this);
            catemoduleform.ShowDialog();
        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //to edit or delete entry data
            string colName = dgvCategory.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if (MessageBox.Show("Are you want to Delete this Category ?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM categoryTB WHERE ID Like '" + dgvCategory[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                  //  cn.Close();
                    MessageBox.Show("Category has been Deleted.", "Point Of Sales", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if (colName == "Edit")
            {
                CategoryModule catemoduleform = new CategoryModule(this);
                catemoduleform.lblID.Text = dgvCategory[1, e.RowIndex].Value.ToString();
                catemoduleform.txtCate.Text = dgvCategory[2, e.RowIndex].Value.ToString();
                catemoduleform.btnsave.Enabled = false;
                catemoduleform.btnupdate.Enabled = true;
                catemoduleform.ShowDialog();
            }
            loadCategory();
        }
    }

}
