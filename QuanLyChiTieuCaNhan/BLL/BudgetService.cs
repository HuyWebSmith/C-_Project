using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Models;

namespace BLL
{
    public class BudgetService
    {
        public List<Budget> GetAllByUser(int userId)
        {
            SpendingManagerDBContext _context = new SpendingManagerDBContext();
            return _context.Budgets.Where(t => t.UserID == userId).ToList();
        }

        public bool InsertBudget(Budget budget)
        {
            try
            {
                SpendingManagerDBContext _context = new SpendingManagerDBContext();
                _context.Budgets.Add(budget);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm giao dịch: {ex.Message}");
                return false;
            }
        }

        public bool DeleteBudget(int budgetID)
        {
            try
            {
                SpendingManagerDBContext _context = new SpendingManagerDBContext();
                var budget = _context.Budgets.FirstOrDefault(t => t.BudgetID == budgetID);
                if (budget != null)
                {
                    _context.Budgets.Remove(budget);
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

        public bool UpdateTransaction(Budget budget)
        {
            try
            {
                SpendingManagerDBContext _context = new SpendingManagerDBContext();
                var budgets = _context.Budgets.FirstOrDefault(t => t.BudgetID == budget.BudgetID);
                if (budgets != null)
                {
                    budgets.BudgetID = budget.BudgetID;
                    budgets.StartDate = budget.StartDate;
                    budgets.EndDate = budget.EndDate;
                    budgets.AmountLimit = budget.AmountLimit;
                    budgets.CategoryID = budget.CategoryID;
                    budgets.UserID = budget.UserID;

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

        public decimal? GetBudgetByCategoryAndUser(int categoryId, int userId)
        {
            try
            {
                SpendingManagerDBContext _context = new SpendingManagerDBContext();
                var totalAmount = _context.Budgets
                .Where(b => b.CategoryID == categoryId && b.UserID == userId)
                .Sum(b => (decimal?)b.AmountLimit); // Ép kiểu sang nullable decimal
                if (totalAmount == 0)
                {
                    return null;
                }

                return totalAmount;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy ngân sách: {ex.Message}");
            }
        }

    }
}
