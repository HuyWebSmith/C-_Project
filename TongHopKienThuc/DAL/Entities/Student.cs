using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public string StudentId { get; set; }
        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }
        public string Sex { get; set; }
        public string Birth {  get; set; }
        [MaxLength(200)]
        public string Address { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        [MaxLength(15)]
        public string Phone { get; set; }
        public string ClassID { get; set; }

        [ForeignKey("ClassID")]
        public Classes classes { get; set; }
        
    }
}
