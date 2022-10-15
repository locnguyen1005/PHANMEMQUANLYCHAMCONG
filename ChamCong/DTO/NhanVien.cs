using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        public int ID { get; set; }
        public string TenNV { get; set; }
        public string Email { get; set; }
        public string Matkhau { get; set; }
        public Nullable<int> Tuoi { get; set; }
        public Nullable<int> SDT { get; set; }
        public Nullable<int> MaCV { get; set; }
        public Nullable<int> MaPB { get; set; }
        public Nullable<int> MaCT { get; set; }
        public Nullable<int> MaLuong { get; set; }

    }
}
