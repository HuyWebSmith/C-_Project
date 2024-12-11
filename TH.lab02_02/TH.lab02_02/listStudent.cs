using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH.lab02_02
{
    public class ListStudent
    {

        List<Student> listStudents;

        public ListStudent(List<Student> listStudents)
        {
            ListStudents = listStudents;
        }

        public List<Student> ListStudents { get => listStudents; set => listStudents = value; }

        private ListStudent()
        {
            listStudents = new List<Student>();
            
        }
    }
}
