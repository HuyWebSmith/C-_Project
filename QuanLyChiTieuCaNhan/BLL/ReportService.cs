using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using DAL;

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
    }
}
