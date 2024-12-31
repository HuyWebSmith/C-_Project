using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL
{
    [Table("User")]
    public class User
    {
        [Key]
        public string UserID { get; set; }
        [Required, MaxLength(100)] public string Username { get; set; }
        [Required, MaxLength(100)] public string Password { get; set; }
        [MaxLength(100)] public string FullName { get; set; }
        [MaxLength(100)] public string Email { get; set; }
        [MaxLength(15)] public string Phone { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public virtual ICollection<Categories> categories { get; set; }
        public virtual ICollection<Transaction> transactions { get; set; }
        public virtual ICollection<Budget> budgets { get; set; }
        public virtual ICollection<Goals> goals { get; set; }
        public virtual ICollection<Report> reports { get; set; }
        public User() 
        { 
            categories = new HashSet<Categories>();
            transactions = new HashSet<Transaction>();
            budgets = new HashSet<Budget>();
            goals = new HashSet<Goals>();
            reports = new HashSet<Report>();
        }
    }
}
