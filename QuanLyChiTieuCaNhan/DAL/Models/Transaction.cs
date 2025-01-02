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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransactionID { get; set; }
        [Required, MaxLength(100)] public string TransactionName { get; set; }
        [Required] public decimal Amount { get; set; }
        [Required] public DateTime Date { get; set; }
        public string Note { get; set; }

        
        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public User User { get; set; }

        
        public int CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public Categories Category { get; set; }
    }
}
