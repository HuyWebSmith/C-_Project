using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH.lab02_02
{
    public class Student
    {
        private string tenDangNhap;
        private string matKhau;
        private string hoTen;
        private string sdt;
        private string chuyenNganh;

        public Student(string tenDangNhap, string matKhau, string hoTen, string sdt, string chuyenNganh)
        {
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
            HoTen = hoTen;
            Sdt = sdt;
            ChuyenNganh = chuyenNganh;
        }

        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string ChuyenNganh { get => chuyenNganh; set => chuyenNganh = value; }

    }
}
