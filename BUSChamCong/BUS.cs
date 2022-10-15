using DALChamCong.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALChamCong;
using System.Runtime.CompilerServices;
using DTO;
using System.Text.RegularExpressions;

namespace BUSChamCong
{
    public class BUS
    {
        public bool checklogin(int ID, string mk, int macty)
        {
            
            List<Employee> listemp = new List<Employee>();
            DAL dn = new DAL();
            listemp = dn.getNV();
            foreach (var nv in listemp)
            {
                if (nv.ID == ID && nv.Matkhau == mk && nv.MaCT == macty)
                {
                    return true;
                }
            }
            return false;
        }

        public List<NhanVien> getlisstnv()
        {
            DAL dalnhanvien = new DAL();
            
            List<NhanVien> listnc = new List<NhanVien>();
            List<Employee> listemp = new List<Employee>();

            listemp = dalnhanvien.getNV();

            foreach(var i in listemp)
            {
                NhanVien add = new NhanVien();

                add.ID = i.ID;
                add.TenNV = i.TenNV;
                add.Matkhau = i.Matkhau;
                add.MaCT = i.MaCT;
                add.Email = i.Email;
                add.Tuoi = i.Tuoi;
                add.SDT = i.SDT;
                add.MaCV = i.MaCV;
                add.MaPB = i.MaPB;
                add.MaCT = i.MaCT;
                add.MaLuong = i.MaLuong;
                listnc.Add(add);
            }    
            return listnc;
        }
        public List<Congty> getlistct()
        {
            List<Congty> list = new List<Congty>();
            DAL dalcongty = new DAL();
            list = dalcongty.GetCty();
            return list;
        }

        public List<Phongban> busgetphongban()
        {
            DAL dalnhanvien = new DAL();
            List<Phongban> listpb = new List<Phongban>();
            List<Department> listdpm = new List<Department>();
            listdpm = dalnhanvien.GetPhongbans();
            foreach (var a in listdpm)
            {
                Phongban phongban = new Phongban();
                phongban.MaPB = a.MaPB;
                phongban.TenPB = a.TenPB;
                listpb.Add(phongban);
            }
            return listpb;
        }

        public List<ChucVu> busgetchucvu()
        {
            DAL dal = new DAL();
            ChucVu addcv = new ChucVu();
            List<Userole> listdpm = new List<Userole>();
            List<ChucVu> listchucvu = new List<ChucVu>();
            listdpm = dal.GetChucVus();
            foreach (var cv in listdpm)
            {
                ChucVu chucVu = new ChucVu();
                chucVu.MaCV = cv.MaCV;
                chucVu.TenCV = cv.TenCV;
                listchucvu.Add(chucVu);
            }
            return listchucvu;
        }

        public List<Bangluong> busgetbangluong()
        {
            DAL dal = new DAL();
            ChucVu addbl = new ChucVu();
            List<salary> listslr = new List<salary>();
            List<Bangluong> listbl = new List<Bangluong>();
            listslr = dal.GetLuongs();
            foreach (var bl in listslr)
            {
                Bangluong bangLuong = new Bangluong();
                bangLuong.ID = bl.ID;
                bangLuong.total = bl.total;
                listbl.Add(bangLuong);
            }
            return listbl;
        }






        public void them(NhanVien nv)
        {
            NhanVien nhanvien = new NhanVien();
            nhanvien.ID = nv.ID;
            nhanvien.TenNV = nv.TenNV;
            nhanvien.SDT = nv.SDT;
            nhanvien.Email = nv.Email;
            nhanvien.MaPB = nv.MaPB;
            nhanvien.MaCV = nv.MaCV;
            nhanvien.MaPB = nv.MaPB;
            DAL dalthem = new DAL();
            dalthem.themvaodata(nhanvien);
        }

        public void sua(NhanVien nv)
        {
            NhanVien nhanvien = new NhanVien();
            nhanvien.ID = nv.ID;
            nhanvien.TenNV = nv.TenNV;
            nhanvien.SDT = nv.SDT;
            nhanvien.Email = nv.Email;
            nhanvien.MaPB = nv.MaPB;
            nhanvien.MaCV = nv.MaCV;
            nhanvien.MaPB = nv.MaPB;
            DAL dalsua = new DAL();
            dalsua.suadata(nhanvien);
        }

        public void xoa(int xoanv)
        {
            try
            {
                List<Employee> listemp = new List<Employee>();
                DAL dn = new DAL();
                listemp = dn.getNV();
                foreach (var nv in listemp)
                {
                    if (nv.ID == xoanv)
                    {
                        dn.xoakhoidata(xoanv);
                    }
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}
