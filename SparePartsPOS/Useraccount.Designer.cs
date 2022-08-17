
namespace SparePartsPOS
{
    partial class Useraccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Useraccount));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.btnaccsave = new System.Windows.Forms.Button();
            this.btnaccclose = new System.Windows.Forms.Button();
            this.txtfullnme = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbrole = new System.Windows.Forms.ComboBox();
            this.txtrepass = new System.Windows.Forms.TextBox();
            this.txtpswrd = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 494);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 59);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Settings";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(-2, 2);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(984, 498);
            this.metroTabControl1.TabIndex = 4;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.btnaccsave);
            this.metroTabPage1.Controls.Add(this.btnaccclose);
            this.metroTabPage1.Controls.Add(this.txtfullnme);
            this.metroTabPage1.Controls.Add(this.label8);
            this.metroTabPage1.Controls.Add(this.cmbrole);
            this.metroTabPage1.Controls.Add(this.txtrepass);
            this.metroTabPage1.Controls.Add(this.txtpswrd);
            this.metroTabPage1.Controls.Add(this.txtusername);
            this.metroTabPage1.Controls.Add(this.label10);
            this.metroTabPage1.Controls.Add(this.label9);
            this.metroTabPage1.Controls.Add(this.label3);
            this.metroTabPage1.Controls.Add(this.label4);
            this.metroTabPage1.Controls.Add(this.label2);
            this.metroTabPage1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(976, 455);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Create Account";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // btnaccsave
            // 
            this.btnaccsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnaccsave.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaccsave.ForeColor = System.Drawing.Color.White;
            this.btnaccsave.Location = new System.Drawing.Point(567, 342);
            this.btnaccsave.Name = "btnaccsave";
            this.btnaccsave.Size = new System.Drawing.Size(114, 40);
            this.btnaccsave.TabIndex = 18;
            this.btnaccsave.Text = "Save";
            this.btnaccsave.UseVisualStyleBackColor = false;
            this.btnaccsave.Click += new System.EventHandler(this.btnaccsave_Click);
            // 
            // btnaccclose
            // 
            this.btnaccclose.BackColor = System.Drawing.Color.DarkGray;
            this.btnaccclose.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaccclose.Location = new System.Drawing.Point(704, 342);
            this.btnaccclose.Name = "btnaccclose";
            this.btnaccclose.Size = new System.Drawing.Size(114, 40);
            this.btnaccclose.TabIndex = 17;
            this.btnaccclose.Text = "Clear";
            this.btnaccclose.UseVisualStyleBackColor = false;
            this.btnaccclose.Click += new System.EventHandler(this.btnaccclose_Click);
            // 
            // txtfullnme
            // 
            this.txtfullnme.Location = new System.Drawing.Point(289, 274);
            this.txtfullnme.Name = "txtfullnme";
            this.txtfullnme.Size = new System.Drawing.Size(529, 30);
            this.txtfullnme.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(95, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 23);
            this.label8.TabIndex = 5;
            this.label8.Text = "Pasword ;";
            // 
            // cmbrole
            // 
            this.cmbrole.FormattingEnabled = true;
            this.cmbrole.Items.AddRange(new object[] {
            "Admin",
            "Cashier"});
            this.cmbrole.Location = new System.Drawing.Point(289, 211);
            this.cmbrole.Name = "cmbrole";
            this.cmbrole.Size = new System.Drawing.Size(529, 31);
            this.cmbrole.TabIndex = 4;
            // 
            // txtrepass
            // 
            this.txtrepass.Location = new System.Drawing.Point(289, 156);
            this.txtrepass.Name = "txtrepass";
            this.txtrepass.Size = new System.Drawing.Size(529, 30);
            this.txtrepass.TabIndex = 3;
            this.txtrepass.UseSystemPasswordChar = true;
            // 
            // txtpswrd
            // 
            this.txtpswrd.Location = new System.Drawing.Point(289, 103);
            this.txtpswrd.Name = "txtpswrd";
            this.txtpswrd.Size = new System.Drawing.Size(529, 30);
            this.txtpswrd.TabIndex = 3;
            this.txtpswrd.UseSystemPasswordChar = true;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(289, 49);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(529, 30);
            this.txtusername.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(95, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 23);
            this.label10.TabIndex = 2;
            this.label10.Text = "Role ;";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(95, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 23);
            this.label9.TabIndex = 2;
            this.label9.Text = "Full Name ;";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Role";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Re-type Password ;";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username ;";
            // 
            // Useraccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Useraccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Account";
            this.panel1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.TextBox txtfullnme;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbrole;
        private System.Windows.Forms.TextBox txtrepass;
        private System.Windows.Forms.TextBox txtpswrd;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnaccsave;
        private System.Windows.Forms.Button btnaccclose;
        public MetroFramework.Controls.MetroTabControl metroTabControl1;
    }
}