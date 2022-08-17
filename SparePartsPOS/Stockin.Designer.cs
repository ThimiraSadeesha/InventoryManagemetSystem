
namespace SparePartsPOS
{
    partial class Stockin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stockin));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnstccksave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.cmbsupplier = new System.Windows.Forms.ComboBox();
            this.txtrefaddrs = new System.Windows.Forms.TextBox();
            this.lblsupplierid = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtconpersn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkclickhere = new System.Windows.Forms.LinkLabel();
            this.linkgenrate = new System.Windows.Forms.LinkLabel();
            this.dtstockin = new System.Windows.Forms.DateTimePicker();
            this.txtstockinby = new System.Windows.Forms.TextBox();
            this.txtrefno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvstockin = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstockin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.btnstccksave);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 490);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 63);
            this.panel1.TabIndex = 4;
            // 
            // btnstccksave
            // 
            this.btnstccksave.BackColor = System.Drawing.Color.DimGray;
            this.btnstccksave.FlatAppearance.BorderSize = 0;
            this.btnstccksave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstccksave.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstccksave.ForeColor = System.Drawing.Color.White;
            this.btnstccksave.Location = new System.Drawing.Point(841, 10);
            this.btnstccksave.Name = "btnstccksave";
            this.btnstccksave.Size = new System.Drawing.Size(114, 40);
            this.btnstccksave.TabIndex = 19;
            this.btnstccksave.Text = "Save";
            this.btnstccksave.UseVisualStyleBackColor = false;
            this.btnstccksave.Click += new System.EventHandler(this.btnstccksave_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = " Stock in Module";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(982, 226);
            this.metroTabControl1.TabIndex = 5;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.cmbsupplier);
            this.metroTabPage1.Controls.Add(this.txtrefaddrs);
            this.metroTabPage1.Controls.Add(this.lblsupplierid);
            this.metroTabPage1.Controls.Add(this.label7);
            this.metroTabPage1.Controls.Add(this.txtconpersn);
            this.metroTabPage1.Controls.Add(this.label6);
            this.metroTabPage1.Controls.Add(this.label5);
            this.metroTabPage1.Controls.Add(this.linkclickhere);
            this.metroTabPage1.Controls.Add(this.linkgenrate);
            this.metroTabPage1.Controls.Add(this.dtstockin);
            this.metroTabPage1.Controls.Add(this.txtstockinby);
            this.metroTabPage1.Controls.Add(this.txtrefno);
            this.metroTabPage1.Controls.Add(this.label4);
            this.metroTabPage1.Controls.Add(this.label3);
            this.metroTabPage1.Controls.Add(this.label2);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(974, 183);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Stock In";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // cmbsupplier
            // 
            this.cmbsupplier.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsupplier.FormattingEnabled = true;
            this.cmbsupplier.Location = new System.Drawing.Point(654, 14);
            this.cmbsupplier.Name = "cmbsupplier";
            this.cmbsupplier.Size = new System.Drawing.Size(297, 30);
            this.cmbsupplier.TabIndex = 18;
            this.cmbsupplier.SelectedIndexChanged += new System.EventHandler(this.cmbsupplier_SelectedIndexChanged);
            this.cmbsupplier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbsupplier_KeyPress);
            // 
            // txtrefaddrs
            // 
            this.txtrefaddrs.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrefaddrs.Location = new System.Drawing.Point(654, 106);
            this.txtrefaddrs.Multiline = true;
            this.txtrefaddrs.Name = "txtrefaddrs";
            this.txtrefaddrs.Size = new System.Drawing.Size(297, 29);
            this.txtrefaddrs.TabIndex = 17;
            // 
            // lblsupplierid
            // 
            this.lblsupplierid.AutoSize = true;
            this.lblsupplierid.BackColor = System.Drawing.Color.White;
            this.lblsupplierid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsupplierid.Location = new System.Drawing.Point(499, 151);
            this.lblsupplierid.Name = "lblsupplierid";
            this.lblsupplierid.Size = new System.Drawing.Size(52, 22);
            this.lblsupplierid.TabIndex = 16;
            this.lblsupplierid.Text = "lblID";
            this.lblsupplierid.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(499, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "Address :";
            // 
            // txtconpersn
            // 
            this.txtconpersn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconpersn.Location = new System.Drawing.Point(654, 58);
            this.txtconpersn.Multiline = true;
            this.txtconpersn.Name = "txtconpersn";
            this.txtconpersn.Size = new System.Drawing.Size(297, 29);
            this.txtconpersn.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(499, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Contac Person :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(499, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Supplier :";
            // 
            // linkclickhere
            // 
            this.linkclickhere.AutoSize = true;
            this.linkclickhere.BackColor = System.Drawing.Color.White;
            this.linkclickhere.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkclickhere.LinkColor = System.Drawing.SystemColors.ControlDark;
            this.linkclickhere.Location = new System.Drawing.Point(140, 147);
            this.linkclickhere.Name = "linkclickhere";
            this.linkclickhere.Size = new System.Drawing.Size(242, 21);
            this.linkclickhere.TabIndex = 10;
            this.linkclickhere.TabStop = true;
            this.linkclickhere.Text = "[Click here to browse Product]";
            this.linkclickhere.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkclickhere_LinkClicked);
            // 
            // linkgenrate
            // 
            this.linkgenrate.AutoSize = true;
            this.linkgenrate.BackColor = System.Drawing.Color.White;
            this.linkgenrate.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkgenrate.LinkColor = System.Drawing.SystemColors.ControlDark;
            this.linkgenrate.Location = new System.Drawing.Point(353, 19);
            this.linkgenrate.Name = "linkgenrate";
            this.linkgenrate.Size = new System.Drawing.Size(88, 21);
            this.linkgenrate.TabIndex = 9;
            this.linkgenrate.TabStop = true;
            this.linkgenrate.Text = "[Genarate]";
            this.linkgenrate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkgenrate_LinkClicked);
            // 
            // dtstockin
            // 
            this.dtstockin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtstockin.Location = new System.Drawing.Point(144, 103);
            this.dtstockin.Name = "dtstockin";
            this.dtstockin.Size = new System.Drawing.Size(297, 30);
            this.dtstockin.TabIndex = 7;
            // 
            // txtstockinby
            // 
            this.txtstockinby.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstockinby.Location = new System.Drawing.Point(144, 58);
            this.txtstockinby.Multiline = true;
            this.txtstockinby.Name = "txtstockinby";
            this.txtstockinby.Size = new System.Drawing.Size(297, 29);
            this.txtstockinby.TabIndex = 6;
            // 
            // txtrefno
            // 
            this.txtrefno.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrefno.Location = new System.Drawing.Point(144, 15);
            this.txtrefno.Multiline = true;
            this.txtrefno.Name = "txtrefno";
            this.txtrefno.Size = new System.Drawing.Size(197, 29);
            this.txtrefno.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Stock in Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Stock In By :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reference No :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvstockin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 226);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 264);
            this.panel2.TabIndex = 6;
            // 
            // dgvstockin
            // 
            this.dgvstockin.AllowUserToAddRows = false;
            this.dgvstockin.BackgroundColor = System.Drawing.Color.White;
            this.dgvstockin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvstockin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvstockin.ColumnHeadersHeight = 30;
            this.dgvstockin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvstockin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column9,
            this.Column10,
            this.Column8,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Delete});
            this.dgvstockin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvstockin.EnableHeadersVisualStyles = false;
            this.dgvstockin.GridColor = System.Drawing.Color.DarkGray;
            this.dgvstockin.Location = new System.Drawing.Point(0, 0);
            this.dgvstockin.Name = "dgvstockin";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvstockin.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvstockin.RowHeadersVisible = false;
            this.dgvstockin.RowHeadersWidth = 51;
            this.dgvstockin.RowTemplate.Height = 24;
            this.dgvstockin.Size = new System.Drawing.Size(982, 264);
            this.dgvstockin.TabIndex = 4;
            this.dgvstockin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvstockin_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "No";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 53;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Id";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Visible = false;
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column10.HeaderText = "Reference#";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 109;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.HeaderText = "ProCode";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 90;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Description";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Qty";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 57;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "Stock in date";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 117;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "Stock in by";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 104;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "Supplier";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 87;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Width = 6;
            // 
            // Stockin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Stockin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stockin";
            this.panel1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvstockin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkclickhere;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvstockin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        public System.Windows.Forms.Button btnstccksave;
        public System.Windows.Forms.ComboBox cmbsupplier;
        public System.Windows.Forms.TextBox txtrefaddrs;
        public System.Windows.Forms.TextBox txtconpersn;
        public System.Windows.Forms.DateTimePicker dtstockin;
        public System.Windows.Forms.TextBox txtstockinby;
        public System.Windows.Forms.TextBox txtrefno;
        public System.Windows.Forms.Label lblsupplierid;
        public System.Windows.Forms.LinkLabel linkgenrate;
    }
}