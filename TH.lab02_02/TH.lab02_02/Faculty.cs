using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH.lab02_02
{
    public class Faculty
    {
        private string maNganh;
        private string tenNganh;
        

        public Faculty()
        {

        }

        public Faculty(string maNganh, string tenNganh, string tenDangNhap, string matKhau, string hoTen, string sdt, string chuyenNganh)
        {
            MaNganh = maNganh;
            TenNganh = tenNganh;
            
        }

        public string MaNganh { get => maNganh; set => maNganh = value; }
        public string TenNganh { get => tenNganh; set => tenNganh = value; }
    }
}
