using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUSChamCong;
using DevExpress.ClipboardSource.SpreadsheetML;
using DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUIChamCong
{
    public partial class NhanSu : Form
    {
        int flag = 0;
        public NhanSu()
        {
            InitializeComponent();
        }
        BUS Laynhanvien = new BUS();
        public void load()
        {
            txMa.Enabled = false;
            txEmail.Enabled = false;
            txTen.Enabled = false;
            txSDT.Enabled = false;

            List<NhanVien> listnv = Laynhanvien.getlisstnv();
            List<Phongban> listphongban = Laynhanvien.busgetphongban();
            List<ChucVu> listchucvu = Laynhanvien.busgetchucvu();

            cbPB.DataSource = listphongban;
            cbPB.DisplayMember = "TenPB";
            cbPB.ValueMember = "MaPB";

            cbCV.DataSource = listchucvu;
            cbCV.DisplayMember = "TenCV";
            cbCV.ValueMember = "MaCV";
            BinGrid(listnv);
        }

        private void BinGrid(List<NhanVien> listnv)
        {
            List<Phongban> listphongban = Laynhanvien.busgetphongban();
            List<ChucVu> listchucvu = Laynhanvien.busgetchucvu();
            dgvNhansu.Rows.Clear();
            foreach (var item in listnv)
            {

                int index = dgvNhansu.Rows.Add();
                dgvNhansu.Rows[index].Cells[0].Value = item.ID;
                dgvNhansu.Rows[index].Cells[1].Value = item.TenNV;
                dgvNhansu.Rows[index].Cells[2].Value = item.SDT;
                dgvNhansu.Rows[index].Cells[3].Value = item.Email;
                foreach (var pb in listphongban)
                {
                    if (pb.MaPB == item.MaPB)
                    {
                        dgvNhansu.Rows[index].Cells[4].Value = pb.TenPB;
                    }
                }
                foreach (var cv in listchucvu)
                {
                    if (cv.MaCV == item.MaCV)
                    {
                        dgvNhansu.Rows[index].Cells[5].Value = cv.TenCV;
                    }
                }
            }
        }


        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn thoát không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }


        }

        private void NhanSu_Load(object sender, EventArgs e)
        {
            load();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            int temp = dgvNhansu.Rows.Count;
            String sma = dgvNhansu.Rows[temp - 1].Cells["Column1"].Value.ToString();
            int Manv = Int32.Parse(sma);
            int getpb = cbPB.SelectedIndex;
            int getcv = cbCV.SelectedIndex;
            nv.ID = temp + 1;
            nv.TenNV = txTen.Text;
            nv.SDT = int.Parse(txSDT.Text);
            nv.Email = txEmail.Text;
            nv.MaPB = getpb + 1;
            nv.MaCV = getcv + 1;
            List<Phongban> listphongban = Laynhanvien.busgetphongban();
            List<ChucVu> listchucvu = Laynhanvien.busgetchucvu();

            int index = dgvNhansu.Rows.Add();
            dgvNhansu.Rows[index].Cells[0].Value = nv.ID;
            dgvNhansu.Rows[index].Cells[1].Value = nv.TenNV;
            dgvNhansu.Rows[index].Cells[2].Value = nv.SDT;
            dgvNhansu.Rows[index].Cells[3].Value = nv.Email;
            foreach (var pb in listphongban)
            {
                if (pb.MaPB == nv.MaPB)
                {
                    dgvNhansu.Rows[index].Cells[4].Value = pb.TenPB;
                }
            }
            foreach (var cv in listchucvu)
            {
                if (cv.MaCV == nv.MaCV)
                {
                    dgvNhansu.Rows[index].Cells[5].Value = cv.TenCV;
                }
            }
            Laynhanvien.them(nv);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            NhanVien nv = new NhanVien();
            int getpb = cbPB.SelectedIndex;
            int getcv = cbCV.SelectedIndex;
            nv.ID = int.Parse(txMa.Text);
            nv.TenNV = txTen.Text;
            nv.SDT = int.Parse(txSDT.Text);
            nv.Email = txEmail.Text;
            nv.MaPB = getpb + 1;
            nv.MaCV = getcv + 1;
            dgvNhansu.Rows.Clear();
            Laynhanvien.sua(nv);
            load();
        }

        

        

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            txEmail.Enabled = true;
            txTen.Enabled = true;
            txSearch.Enabled = true;
            txSDT.Enabled = true;
            flag = 1;
            
        }

        private void txSearch_TextChanged(object sender, EventArgs e)
        {
            String Search = txSearch.Text.Trim();
            List<NhanVien> listSearch = new List<NhanVien>();
            List<NhanVien> listnhanvien = new List<NhanVien>();
            BUS laynhanvien = new BUS();
            listnhanvien = laynhanvien.getlisstnv();
            foreach (var item in listnhanvien)
            {
                if (item.ID.ToString().StartsWith(Search) || item.SDT.ToString().StartsWith(Search))
                {
                    listSearch.Add(item);
                }
            }

            BinGrid(listSearch);
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            int xoanv = Int32.Parse(txMa.Text);
            Laynhanvien.xoa(xoanv);
            load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                try
                {
                    DialogResult r = MessageBox.Show("Bạn có muốn thêm nhân viên?", "Thông báo", MessageBoxButtons.YesNo);
                    if (r == DialogResult.Yes)
                    {
                        NhanVien nv = new NhanVien();
                        int temp = dgvNhansu.Rows.Count;
                        String sma = dgvNhansu.Rows[temp - 1].Cells["Column1"].Value.ToString();
                        int Manv = Int32.Parse(sma);
                        int getpb = cbPB.SelectedIndex;
                        int getcv = cbCV.SelectedIndex;
                        nv.ID = temp + 1;
                        nv.TenNV = txTen.Text;
                        nv.SDT = int.Parse(txSDT.Text);
                        nv.Email = txEmail.Text;
                        nv.MaPB = getpb + 1;
                        nv.MaCV = getcv + 1;
                        List<Phongban> listphongban = Laynhanvien.busgetphongban();
                        List<ChucVu> listchucvu = Laynhanvien.busgetchucvu();
                        Laynhanvien.them(nv);
                        
                        load();
                    }
                }
                catch (Exception ex)
                {

                }
            }
            else if (flag == 2)
            {
                DialogResult r = MessageBox.Show("Bạn có sửa thông tin?", "Thông báo", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    NhanVien nv = new NhanVien();
                    int getpb = cbPB.SelectedIndex;
                    int getcv = cbCV.SelectedIndex;
                    nv.ID = int.Parse(txMa.Text);
                    nv.TenNV = txTen.Text;
                    nv.SDT = int.Parse(txSDT.Text);
                    nv.Email = txEmail.Text;
                    nv.MaPB = getpb + 1;
                    nv.MaCV = getcv + 1;
                    dgvNhansu.Rows.Clear();
                    Laynhanvien.sua(nv);
                    load();
                }
            }    
        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            txEmail.Enabled = true;
            txTen.Enabled = true;
            txSearch.Enabled = true;
            txSDT.Enabled = true;
            flag = 2;
        }

        private void dgvNhansu_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvNhansu.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvNhansu.CurrentRow.Selected = true;
                    txMa.Text = dgvNhansu.Rows[e.RowIndex].Cells["Column1"].FormattedValue.ToString();
                    txTen.Text = dgvNhansu.Rows[e.RowIndex].Cells["Column2"].FormattedValue.ToString();
                    txSDT.Text = dgvNhansu.Rows[e.RowIndex].Cells["Column3"].FormattedValue.ToString();
                    txEmail.Text = dgvNhansu.Rows[e.RowIndex].Cells["Column4"].FormattedValue.ToString();
                    cbPB.Text = dgvNhansu.Rows[e.RowIndex].Cells["Column5"].FormattedValue.ToString();
                    cbCV.Text = dgvNhansu.Rows[e.RowIndex].Cells["Column6"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbPB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

