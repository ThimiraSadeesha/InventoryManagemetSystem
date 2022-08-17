using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SparePartsPOS
{
    public partial class MainForm : Form
    {

       SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        Dbconnect dbcon = new Dbconnect();
        public MainForm()
        {
            InitializeComponent();
            customizeDesing();
             cn = new SqlConnection(dbcon.myConnection());
            cn.Open();
            //MessageBox.Show("Database is Connected");
          
        }
        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm !=null)
               activeForm.Close();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                lblTitle.Text = childForm.Text;
            panelmain.Controls.Add(childForm);
            panelmain.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            
        }

        #region panel_slide
        private void customizeDesing()
        {
            panel_Stocks.Visible = false;
           
        }
        private void hideSubmenu()
        {
            if (panel_Stocks.Visible  == true)
                panel_Stocks.Visible = false;
           


        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
            
        }
        #endregion panel_slide
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_Stocks);
            
            

            
        }

        private void btnstff_Click(object sender, EventArgs e)
        {
            openChildForm(new Useraccount());
            //showSubmenu(panel_Staff);
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            openChildForm(new supplier());
           // showSubmenu(panel_customer);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            openChildForm(new Stockin());
            // showSubmenu(panel_transaction);
        }

        private void btnbrand_Click(object sender, EventArgs e)
        {
            openChildForm(new ManagestckFrom());
            hideSubmenu();
        }

        private void btnadctegry_Click(object sender, EventArgs e)
        {
            openChildForm(new Category());
            hideSubmenu();
        }

        private void btnaddstck_Click(object sender, EventArgs e)
        {
            openChildForm(new Product());
            hideSubmenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Log Out Application ?", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Hide();
                login Log = new login();
                Log.Show();
            }
        }

        private void btnDshbord_Click(object sender, EventArgs e)
        {
            openChildForm(new dashbord());
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application ?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }

        private void button13_Click(object sender, EventArgs e)
        {
            openChildForm(new dashbord());
        }
    }
}
