using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("Class")]
    public class Classes
    {
        [Key]
        public string ClassID { get; set; }
        [Required]
        [MaxLength(30)]
        public string ClassName { get; set; }
        public string FacultyID { get; set; }
        [ForeignKey("FacultyID")]
        public Faculty faculty { get; set; }
        public ICollection<Student> students { get; set; }
        public Classes()
        {
            students = new HashSet<Student>();
        }
    }
}
