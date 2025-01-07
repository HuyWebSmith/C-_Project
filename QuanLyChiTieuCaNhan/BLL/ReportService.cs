using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using DAL;
using DAL.enums;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace BLL
{
    public class ReportService
    {
        public List<Report> getAll()
        {
            SpendingManagerDBContext context = new SpendingManagerDBContext();
            return context.Reports.ToList();
        }

        public List<Report> GetAllByUser(int userId)
        {
            SpendingManagerDBContext _context = new SpendingManagerDBContext();
            return _context.Reports.Where(t => t.UserID == userId).ToList();
        }

        public decimal GetTotalIncome(int userID, DateTime startDate, DateTime endDate)
        {
            SpendingManagerDBContext _context = new SpendingManagerDBContext();

            // Lấy tổng thu nhập từ các giao dịch của người dùng
            var totalIncome = _context.Users
                .Where(u => u.UserID == userID) // Lọc theo userID
                .SelectMany(u => u.transactions) // Lấy danh sách giao dịch
                .Where(t => t.Date >= startDate && t.Date <= endDate && t.Category.CategoryType == CategoryType.Income) // Điều kiện lọc
                .Sum(t => (decimal?)t.Amount) ?? 0m; // Tính tổng hoặc trả về 0 nếu không có

            return totalIncome;
        }

        public decimal GetTotalExpense(int userID, DateTime startDate, DateTime endDate)
        {
            SpendingManagerDBContext _context = new SpendingManagerDBContext();

            // Lấy tổng chi tiêu từ các giao dịch của người dùng
            var totalExpense = _context.Users
                .Where(u => u.UserID == userID) // Lọc theo userID
                .SelectMany(u => u.transactions) // Lấy danh sách giao dịch
                .Where(t => t.Date >= startDate && t.Date <= endDate && t.Category.CategoryType == CategoryType.Expense) // Điều kiện lọc
                .Sum(t => (decimal?)t.Amount) ?? 0m; // Tính tổng hoặc trả về 0 nếu không có

            return totalExpense;
        }
        public void InsertReport(Report report)
        {
            SpendingManagerDBContext _context = new SpendingManagerDBContext();
            _context.Reports.Add(report);
            _context.SaveChanges();
        }

        public bool DeleteReport(int reportID)
        {
            try
            {
                SpendingManagerDBContext _context = new SpendingManagerDBContext();
                var report = _context.Reports.FirstOrDefault(t => t.ReportID == reportID);
                if (report != null)
                {
                    _context.Reports.Remove(report);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        


    }
}
