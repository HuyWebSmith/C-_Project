using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace BLL
{
    public class FacultyService
    {
        public List<Faculty> GetAll()
        {
            StudentDBContext _context = new StudentDBContext();
            return _context.Facultys.ToList();
        }

        public void InsertUpFaculty(Faculty faculty)
        {
            StudentDBContext _context = new StudentDBContext();
            _context.Facultys.AddOrUpdate(faculty);
            _context.SaveChanges();
        }
    }
}
