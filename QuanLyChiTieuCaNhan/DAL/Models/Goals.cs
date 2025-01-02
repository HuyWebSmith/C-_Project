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
    [Table("Goals")]
    public class Goals
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GoalID { get; set; }
        [Required, MaxLength(100)] public string GoalName { get; set; }
        [Required] public decimal TargetAmount { get; set; }
        [Required] public decimal CurrentAmount { get; set; } = 0.00m;
        public DateTime DueDate { get; set; }                       /* -- Ngày cần đạt được*/
        public Status Status { get; set; } = Status.InProgress;
        
        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public User User { get; set; }
    }
}
