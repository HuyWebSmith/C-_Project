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
        Expense,  // Tương đương 'Expense'
        // Thu nhập
        Salary,           // Lương
        Bonus,            // Thưởng
        InvestmentIncome, // Thu nhập từ đầu tư
        Freelance,        // Thu nhập tự do

        // Chi tiêu
        Food,             // Ăn uống
        Entertainment,    // Giải trí
        Housing,          // Tiền nhà
        Transportation,   // Di chuyển
        Utilities,        // Hóa đơn tiện ích
        Health,           // Chăm sóc sức khỏe
        Education,        // Giáo dục
        Shopping,         // Mua sắm
        Miscellaneous     // Chi tiêu khác
    }
}
