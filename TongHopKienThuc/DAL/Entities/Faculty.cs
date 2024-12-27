using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("Faculty")]
    public class Faculty
    {   
        [Key]
        public string FacultyID { get; set; }
        [Required]
        [MaxLength(30)]
        public string FacultyName { get; set; }
        public ICollection<Classes> classes {  get; set; }
        public Faculty()
        {
            classes = new HashSet<Classes>();
        }
    }
}
