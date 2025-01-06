using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.enums
{
    public enum CategoryType
    {
        Income,  // Tương đương 'Income' -- Loại (thu nhập/chi tiêu)
        Expense  // Tương đương 'Expense'
        // Thu nhập
      
    }
    // Danh mục thu nhập
    public enum DanhMucThuNhap
    {
        Luong,         // Lương
        KinhDoanh,     // Kinh doanh
        DauTu,         // Đầu tư
        ThuNhapTuNha,  // Thu nhập từ cho thuê nhà
        ThuNhapTuBanHang, // Thu nhập từ bán hàng
        Thuong,        // Tiền thưởng
        TroCap,        // Trợ cấp
        ThuNhapKhac    // Thu nhập khác
    }

    // Danh mục chi tiêu
    public enum DanhMucChiTieu
    {
        ThucPham,          // Thực phẩm
        TienThueNha,       // Tiền thuê nhà
        TienDienNuoc,      // Tiền điện nước
        DiLai,             // Chi phí đi lại
        GiaiTri,           // Giải trí
        MuaSam,            // Mua sắm
        ChuyenGiaDinh,     // Chi phí cho gia đình
        YTe,               // Y tế
        GiaoDuc,           // Giáo dục
        TienTho,           // Tiền thờ cúng
        DuLich,            // Du lịch
        ChiTieuKhac        // Chi tiêu khác
    }
}
