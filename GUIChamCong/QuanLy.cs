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
    public partial class QuanLy : Form
    {
        public QuanLy()
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
            panel2.Controls.Add(chilform);
            panel2.Tag = chilform;
            chilform.BringToFront();
            chilform.Show();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            openchildform(new NhanSu());
        }
    }
}
