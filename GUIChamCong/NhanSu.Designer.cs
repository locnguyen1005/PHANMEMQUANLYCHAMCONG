namespace GUIChamCong
{
    partial class NhanSu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanSu));
            this.dgvNhansu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsthem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tssua = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.txMa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txSDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPB = new System.Windows.Forms.ComboBox();
            this.cbCV = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhansu)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNhansu
            // 
            this.dgvNhansu.AllowUserToAddRows = false;
            this.dgvNhansu.AllowUserToDeleteRows = false;
            this.dgvNhansu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhansu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvNhansu.Location = new System.Drawing.Point(2, 103);
            this.dgvNhansu.Name = "dgvNhansu";
            this.dgvNhansu.ReadOnly = true;
            this.dgvNhansu.Size = new System.Drawing.Size(907, 345);
            this.dgvNhansu.TabIndex = 0;
            this.dgvNhansu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhansu_CellClick_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã nhân viên";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên nhân viên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "SDT";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Email";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Phòng ban";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Chức vụ";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsthem,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.tssua,
            this.toolStripSeparator3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(960, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsthem
            // 
            this.tsthem.Image = ((System.Drawing.Image)(resources.GetObject("tsthem.Image")));
            this.tsthem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsthem.Name = "tsthem";
            this.tsthem.Size = new System.Drawing.Size(57, 22);
            this.tsthem.Text = "Thêm";
            this.tsthem.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(47, 22);
            this.toolStripButton2.Text = "Xóa";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tssua
            // 
            this.tssua.Image = ((System.Drawing.Image)(resources.GetObject("tssua.Image")));
            this.tssua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssua.Name = "tssua";
            this.tssua.Size = new System.Drawing.Size(46, 22);
            this.tssua.Text = "Sửa";
            this.tssua.Click += new System.EventHandler(this.toolStripButton3_Click_1);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(56, 22);
            this.toolStripButton4.Text = "Đóng";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // txMa
            // 
            this.txMa.Location = new System.Drawing.Point(118, 35);
            this.txMa.Name = "txMa";
            this.txMa.Size = new System.Drawing.Size(117, 20);
            this.txMa.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã nhân viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Têm nhân viên";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txTen
            // 
            this.txTen.Location = new System.Drawing.Point(118, 70);
            this.txTen.Name = "txTen";
            this.txTen.Size = new System.Drawing.Size(117, 20);
            this.txTen.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(241, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "SDT";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txSDT
            // 
            this.txSDT.Location = new System.Drawing.Point(324, 36);
            this.txSDT.Name = "txSDT";
            this.txSDT.Size = new System.Drawing.Size(100, 20);
            this.txSDT.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(241, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txEmail
            // 
            this.txEmail.Location = new System.Drawing.Point(324, 71);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(100, 20);
            this.txEmail.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(434, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Phòng ban";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbPB
            // 
            this.cbPB.FormattingEnabled = true;
            this.cbPB.Location = new System.Drawing.Point(517, 28);
            this.cbPB.Name = "cbPB";
            this.cbPB.Size = new System.Drawing.Size(121, 21);
            this.cbPB.TabIndex = 12;
            this.cbPB.SelectedIndexChanged += new System.EventHandler(this.cbPB_SelectedIndexChanged);
            // 
            // cbCV
            // 
            this.cbCV.FormattingEnabled = true;
            this.cbCV.Location = new System.Drawing.Point(517, 70);
            this.cbCV.Name = "cbCV";
            this.cbCV.Size = new System.Drawing.Size(121, 21);
            this.cbCV.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(435, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Chức vụ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txSearch
            // 
            this.txSearch.Location = new System.Drawing.Point(809, 31);
            this.txSearch.Name = "txSearch";
            this.txSearch.Size = new System.Drawing.Size(100, 20);
            this.txSearch.TabIndex = 15;
            this.txSearch.TextChanged += new System.EventHandler(this.txSearch_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(644, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Xác nhận";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(730, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tìm kiếm";
            // 
            // NhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 460);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbCV);
            this.Controls.Add(this.cbPB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txSDT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txMa);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvNhansu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NhanSu";
            this.Text = "NhanSu";
            this.Load += new System.EventHandler(this.NhanSu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhansu)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNhansu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsthem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tssua;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.TextBox txMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txSDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbPB;
        private System.Windows.Forms.ComboBox cbCV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox txSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
    }
}