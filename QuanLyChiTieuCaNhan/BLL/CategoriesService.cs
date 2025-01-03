using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Models;

namespace BLL
{
    public class CategoriesService
    {
        public List<Categories> getAll()
        {
            SpendingManagerDBContext context = new SpendingManagerDBContext();
            return context.Categories.ToList();
        }
        public List<Categories> GetAllByUser(int userId)
        {
            SpendingManagerDBContext _context = new SpendingManagerDBContext();
            return _context.Categories.Where(t => t.UserID == userId).ToList();
        }
        public string GetTransactionNameUser(int userId)
        {
            SpendingManagerDBContext _context = new SpendingManagerDBContext();
            return _context.Categories.Where(t => t.UserID == userId)
                       .Select(t => t.CategoryName).FirstOrDefault();

        }
        public int GetTransactionIDUser(int userId)
        {
            SpendingManagerDBContext _context = new SpendingManagerDBContext();
            return _context.Categories.Where(t => t.UserID == userId)
                       .Select(t => t.CategoryID).FirstOrDefault();

        }
    }
}
