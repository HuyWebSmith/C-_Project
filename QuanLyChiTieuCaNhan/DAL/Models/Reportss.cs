using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Reportss
    {
        public int ReportID { get; set; }
        public DateTime StartAReportDate { get; set; }
        public DateTime EndAReportDate { get; set; }
        public decimal TotalIncome { get; set; } = 0.00m;
        public decimal TotalExpense { get; set; } = 0.00m;
        public string ReportDetails { get; set; } = "{}";
    }
}
