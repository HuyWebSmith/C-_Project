using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            try
            {
                SpendingManagerDBContext _context = new SpendingManagerDBContext();
                return _context.Transactions.Where(t => t.UserID == userId && t.Category.CategoryType == CategoryType.Income).Sum(t => t.Amount);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public decimal GetTotalAmountExpense(int userId)
        {
            try
            {
                SpendingManagerDBContext _context = new SpendingManagerDBContext();
                return _context.Transactions.Where(t => t.UserID == userId && t.Category.CategoryType == CategoryType.Expense).Sum(t => t.Amount);
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public decimal GetTotalExpensesByCategoryAndUser(int categoryID, int userId)
        {
            SpendingManagerDBContext _context = new SpendingManagerDBContext();
            return _context.Transactions.Where(t => t.UserID == userId 
            && t.Category.CategoryType == CategoryType.Expense
            && t.Category.CategoryID == categoryID).Sum(t => t.Amount);
        }
        public decimal GetTotalInComeByCategoryAndUser(int categoryID, int userId)
        {
            SpendingManagerDBContext _context = new SpendingManagerDBContext();
            return _context.Transactions.Where(t => t.UserID == userId
            && t.Category.CategoryType == CategoryType.Income
            && t.Category.CategoryID == categoryID).Sum(t => t.Amount);
        }
        public bool InsertTransaction(Transaction transaction)
        {
            try
            {
                SpendingManagerDBContext _context = new SpendingManagerDBContext();
                _context.Transactions.Add(transaction);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm giao dịch: {ex.Message}");
                return false;
            }
        }

        public bool DeleteTransaction(int transactionId)
        {
            try
            {
                SpendingManagerDBContext _context = new SpendingManagerDBContext();
                var transaction = _context.Transactions.FirstOrDefault(t => t.TransactionID == transactionId);
                if (transaction != null)
                {
                    _context.Transactions.Remove(transaction);
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
        public bool UpdateTransaction(Transaction transaction)
        {
            try
            {
                SpendingManagerDBContext _context = new SpendingManagerDBContext();
                var transactions = _context.Transactions.FirstOrDefault(t => t.TransactionID == transaction.TransactionID);
                if (transactions != null)
                {
                    transactions.CategoryID = transaction.CategoryID;
                    transactions.TransactionID = transaction.TransactionID;
                    transactions.TransactionName = transaction.TransactionName;
                    transactions.Amount = transaction.Amount;
                    transactions.Date = transaction.Date;
                    transactions.Note = transaction.Note;

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
