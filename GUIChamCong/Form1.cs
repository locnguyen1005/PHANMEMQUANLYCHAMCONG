using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIChamCong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Form currentchildform;
        private void openchildform(Form chilform)
        {
            if (currentchildform != null)
            {
                currentchildform.Close();
            }
            currentchildform = chilform;
            chilform.TopLevel = false;
            chilform.FormBorderStyle = FormBorderStyle.None;
            chilform.Dock = DockStyle.Fill;
            panel3.Controls.Add(chilform);
            panel3.Tag = chilform;
            chilform.BringToFront();
            chilform.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            openchildform(new DangNhap());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Bạn có muốn thoát?", "Thong báo", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex) { }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
