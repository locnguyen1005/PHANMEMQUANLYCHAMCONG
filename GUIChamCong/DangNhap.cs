using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUSChamCong;
using DTO;

namespace GUIChamCong
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        Thread th;
        
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        public void open(object obj)
        {
            Application.Run(new QuanLy());
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            BUS insertCB = new BUS();
            List<Congty> listcty = new List<Congty>();
            listcty = insertCB.getlistct();
            this.cbCty.DataSource = listcty;
            this.cbCty.DisplayMember = "TenCT";
            this.cbCty.ValueMember = "MaCT";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txTaikhoan.Text == "" || txMatkhau.Text == "")
                {
                    MessageBox.Show("Nhap tai khoan va mat khau");
                }
                else
                {
                    BUS dn = new BUS();
                    int macty = cbCty.SelectedIndex ;
                    macty++;
                    if (dn.checklogin(Int32.Parse(txTaikhoan.Text), txMatkhau.Text , macty))
                    {
                        Application.Exit();
                        th = new Thread(open);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();
                    }
                    else
                    {
                        MessageBox.Show("Sai thông tin");
                    }
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
