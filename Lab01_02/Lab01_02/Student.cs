using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    internal class Student
    {
        static List<Student> studentsList = new List<Student>();
        public string studentID { get ; set ; }
        public string name { get; set ; }
        public double score { get; set ; }
        public string faculty { get; set ; }

        public Student() {}
        public Student(string studentID, string name , float score , string faculty) 
        { 
            this.studentID = studentID;
            this.name = name;   
            this.score = score; 
            this.faculty = faculty;
        }

        public void Input()
        {
            Console.InputEncoding = Encoding.UTF8;  
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập MSSV: ");
            studentID = Console.ReadLine();
            Console.WriteLine("Nhập Họ tên sinh viên: ");
            name = Console.ReadLine();
            Console.WriteLine("Nhập Điểm: ");
            score = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhập Khoa: ");
            faculty = Console.ReadLine();
        }

        public void Show()
        {
            Console.WriteLine("MSSV: {0} , Họ tên: {1} , Điểm: {2} , Khoa:{3}",studentID, name, score, faculty);
        }
    }
}
