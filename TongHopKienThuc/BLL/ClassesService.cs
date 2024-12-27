using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace BLL
{
    public class ClassesService
    {
        public List<Classes> GetAll()
        {
            StudentDBContext _context = new StudentDBContext();
            return _context.Classes.ToList();   
        }

    }
}
