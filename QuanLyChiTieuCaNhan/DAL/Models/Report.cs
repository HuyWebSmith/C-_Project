using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    [Table("Report")]
    public class Report
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReportID { get; set; }
        [Required] public DateTime StartAReportDate { get; set; }
        [Required] public DateTime EndAReportDate { get; set; }
        [Required] public decimal TotalIncome { get; set; } = 0.00m;
        [Required] public decimal TotalExpense { get; set; } = 0.00m;
        public string ReportDetails { get; set; } = "{}";
        
        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public User User { get; set; }
    }
}
