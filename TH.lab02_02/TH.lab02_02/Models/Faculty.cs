using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH.lab02_02.Models
{
    [Table("Faculty")]
    public class Faculty
    {
        
        public string maNganh;
        public string tenNganh;


        public Faculty()
        {

        }

        public Faculty(string maNganh, string tenNganh)
        {
            MaNganh = maNganh;
            TenNganh = tenNganh;

        }

        [Key]
        public string MaNganh { get => maNganh; set => maNganh = value; }
        public string TenNganh { get => tenNganh; set => tenNganh = value; }
    }
}
