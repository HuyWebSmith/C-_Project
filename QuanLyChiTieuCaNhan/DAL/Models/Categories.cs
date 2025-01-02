using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.enums;
using DAL.Models;

namespace DAL
{
    [Table("Categories")]
    public class Categories
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryID { get; set; }
        [Required, MaxLength(100)] public string CategoryName { get; set; }
        public CategoryType CategoryType { get; set; }
        
        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public User User { get; set; }
        public virtual ICollection<Transaction> transactions { get; set; }
        public virtual ICollection<Budget> budgets { get; set; }
        public Categories()
        {
            transactions = new HashSet<Transaction>();
            budgets = new HashSet<Budget>();
        }
    }
}
