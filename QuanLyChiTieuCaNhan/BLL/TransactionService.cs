using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.enums;
using DAL.Models;

namespace BLL
{
    public class TransactionService
    {
        public List<Transaction> GetAllByUser(int userId)
        {
            SpendingManagerDBContext _context = new SpendingManagerDBContext();
            return _context.Transactions.Where(t => t.UserID == userId).ToList();
        }
        
        public decimal GetTotalAmountIncome(int userId)
        {
            SpendingManagerDBContext _context = new SpendingManagerDBContext();
            return _context.Transactions.Where(t => t.UserID == userId && t.Category.CategoryType == CategoryType.Income).Sum(t => t.Amount);
        }

        public decimal GetTotalAmountExpense(int userId)
        {
            SpendingManagerDBContext _context = new SpendingManagerDBContext();
            return _context.Transactions.Where(t => t.UserID == userId && t.Category.CategoryType == CategoryType.Expense).Sum(t => t.Amount);
        }

    }
}
