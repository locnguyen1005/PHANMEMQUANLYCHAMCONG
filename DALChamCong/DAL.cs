using DALChamCong.Model;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DALChamCong
{
    public class DAL
    {
        QLChamCongEntities db = new QLChamCongEntities();
        
        public List<Congty> GetCty()
        {
            List<Congty> listct = new List<Congty>();
            
            using (var db = new QLChamCongEntities())
            {
                var tb = from a in db.Company
                         select a;

                foreach (var i in tb)
                {
                    Congty cty1 = new Congty();
                    cty1.MaCT = i.MaCT;
                    cty1.TenCT = i.TenCT;
                    cty1.DiaChi = i.DiaChi;
                    cty1.ChiNhanh = i.ChiNhanh;
                    cty1.SLNV = i.SLNV;
                    listct.Add(cty1);
                }

            }
            return listct;
            
        }
        public List<Employee> getNV()
        {
            List<Employee> listnv = new List<Employee>();
            using (var db = new QLChamCongEntities())
            {
                var tb = from nv in db.Employee
                         select nv;
                foreach (var i in tb)
                {
                    Employee emp = new Employee();
                    emp.ID = i.ID;
                    emp.TenNV = i.TenNV;
                    emp.Matkhau = i.Matkhau;
                    emp.MaCT = i.MaCT;
                    emp.Email = i.Email;
                    emp.Tuoi = i.Tuoi;
                    emp.SDT = i.SDT;
                    emp.MaCV = i.MaCV;
                    emp.MaPB = i.MaPB;
                    emp.MaCT = i.MaCT;
                    emp.MaLuong = i.MaLuong;
                    listnv.Add(emp);
                }

            }
            return listnv;
        }

        public List<Department> GetPhongbans()
        {
            List<Department> listphongban = new List<Department>();
            using (var db = new QLChamCongEntities())
            {
                var tb = from pb in db.Department
                         select pb;
                foreach (var a in tb)
                {
                    Department phongban = new Department();
                    phongban.MaPB = a.MaPB;
                    phongban.TenPB = a.TenPB;
                    listphongban.Add(phongban);
                }
            }
            return listphongban;
        }

        public List<Userole> GetChucVus()
        {
            List<Userole> listchucvu = new List<Userole>();
            using (var db = new QLChamCongEntities())
            {
                var tb = from cv in db.Userole
                         select cv;
                foreach (var a in tb)
                {
                    Userole chucVu = new Userole();
                    chucVu.MaCV = a.MaCV;
                    chucVu.TenCV = a.TenCV;
                    listchucvu.Add(chucVu);
                }
            }
            return listchucvu;
        }

        public List<salary> GetLuongs()
        {
             List<salary> listluong = new List<salary>();
             using (var db = new QLChamCongEntities())
            {
                var tb = from luong in db.salary
                         select luong;
                foreach( var a in tb)
                {
                    salary luong = new salary();
                    luong.ID = a.ID;
                    luong.total = a.total;
                    listluong.Add(luong);
                }
                return listluong;
            }    

}


        public void themvaodata(NhanVien nv)
        {
            Employee employee = new Employee();
            employee.ID = nv.ID;
            employee.TenNV = nv.TenNV;
            employee.SDT = nv.SDT;
            employee.Email = nv.Email;
            employee.MaPB = nv.MaPB;
            employee.MaCV = nv.MaCV;
            employee.Matkhau = "1";
            db.Employee.Add(employee);
            db.SaveChanges();
        }

        public void suadata(NhanVien nv)
        {
            Employee Update = db.Employee.FirstOrDefault(e => e.ID == nv.ID);
            if (Update != null)
            {
                Update.TenNV = nv.TenNV;
                Update.SDT = nv.SDT;
                Update.Email = nv.Email;
                Update.MaPB = nv.MaPB;
                Update.MaCV = nv.MaCV;
            }
            db.SaveChanges();
        }

        public void xoakhoidata(int nv)
        {
            Employee employee = db.Employee.FirstOrDefault(p => p.ID == nv);
            db.Employee.Remove(employee);
            db.SaveChanges();
        }
    }
}
