using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangHoa
{
    [Table("Huy_96_DanhSachCuaHang")]
    public class Huy_96_DanhSachCuaHang
    {
        [Key]
        public string MaCuaHang { get; set; }
        public string TenCuaHang { get; set; }
        public string DiaChiCuaHang { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string HoTenNhanVienQuanLy { get; set; }
        public string SDTNhanVienQuanLy { get; set; }
    }
}
