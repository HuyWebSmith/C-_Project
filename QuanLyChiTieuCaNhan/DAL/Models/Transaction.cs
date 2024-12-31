using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.enums;

namespace DAL.Models
{
    [Table("Transaction")]
    public class Transaction
    {
        [Key]
        public string TransactionID { get; set; }
        [Required, MaxLength(100)] public string TransactionName { get; set; }
        [Required] public decimal Amount { get; set; }
        [Required] public DateTime Date { get; set; }
        public string Note { get; set; }

        
        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public User User { get; set; }

        
        public string CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public Categories Category { get; set; }
    }
}
