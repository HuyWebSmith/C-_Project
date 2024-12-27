using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace BLL
{
    public class StudentService
    {
        public List<Student> GettAll()
        {
            StudentDBContext _context = new StudentDBContext();
            return _context.Students.ToList();
        }

        public List<Student> GetAllNoHasClass()
        {
            StudentDBContext _context = new StudentDBContext();
            return _context.Students.Where(p => p.ClassID == null).ToList();
        }

        public List<Student> GetAllNoHasClass(string FacultyID)
        {
            StudentDBContext _context = new StudentDBContext();
            return _context.Students.Where(p => p.ClassID == null
            && p.classes.faculty.FacultyID == null).ToList();
        }

        public void InsertUpStudent(Student student)
        {
            StudentDBContext _context = new StudentDBContext();
            _context.Students.AddOrUpdate(student);
            _context.SaveChanges();
        }
    }
}
