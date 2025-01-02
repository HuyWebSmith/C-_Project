using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    [Table("Budget")]
    public class Budget
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BudgetID { get; set; }
        [Required] public decimal AmountLimit { get; set; } /*-- Hạn mức ngân sách*/
        [Required] public DateTime StartDate { get; set; }
        [Required] public DateTime EndDate { get; set; }
        
        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public User User { get; set; }

        
        public int CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public Categories Category { get; set; }
    }
}
