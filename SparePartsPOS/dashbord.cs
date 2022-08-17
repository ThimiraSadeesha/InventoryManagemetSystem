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
    public partial class dashbord : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        Dbconnect dbcon = new Dbconnect();
        

        public dashbord()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
        }

        private void dashbord_Load(object sender, EventArgs e)
        {
            string sdate = DateTime.Now.ToShortDateString();
            lblpro.Text = dbcon.ExtractData("SELECT COUNT (*) FROM productTB").ToString("#,##0");
            lblstock.Text = dbcon.ExtractData("SELECT COUNT (*) FROM StockinTB").ToString("#,##0");
            lbldalysale.Text = dbcon.ExtractData("SELECT COUNT (*) FROM TBCartnew").ToString("#,##0");
            lblincome.Text=dbcon.ExtractData("SELECT SUM (total) FROM TBCartnew").ToString("#,##0");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbldalysale_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //private void dash_bordload(object)


    }

}
