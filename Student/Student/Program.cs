using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "Nguyen Quang Huy", 13));
            students.Add(new Student(2, "Tran Tuan Anh", 30));
            students.Add(new Student(3, "ALe Xuan Duong", 18));
            students.Add(new Student(4, "Nguyen Huu Thang", 16));
            students.Add(new Student(5, "ALe Trung Dung", 23));

            //a. In toàn bộ danh sách học sinh
            Console.WriteLine("\nToàn bộ danh sách học sinh: ");
            foreach (var x in students)
            {
                Console.WriteLine(x.ToString());
            }

            //b.Tìm và in ra học sinh có tuổi từ 15 đến 18
            var findAge = students.Where(student => student.Age >= 15 && student.Age <= 18)
                .Select(student => new { student.ID, student.Name , student.Age });
            Console.WriteLine("\nHoc sinh có tuoi tu 15 den 18: ");
            foreach (var x in findAge)
            {
                Console.WriteLine(x.ToString());
            }

            //c.Tìm và in ra học sinh có tên bắt đầu bằng "A"
            var nameStartWithA = students.Where(student => student.Name.StartsWith("A"))
                .Select(student => new { student.ID,student.Name, student.Age });

            Console.WriteLine("\nHoc sinh có ten bat dau bang A: ");
            foreach (var x in nameStartWithA)
            {
                Console.WriteLine(x.ToString());
            }

            //d. Tổng tuỏi các học sinh
            var sumAge = students.Sum(student => student.Age);
            Console.WriteLine($"\nTong so tuoi cua cac hoc sinh: {sumAge}");

            //e.Tìm học sinh có số tuỏi lớn nhất
            var maxAge = students.Max(student => student.Age);
            Console.WriteLine($"\nHoc sinh co so tuoi lon nhat: {maxAge}");

            //f.Sap xep va in ra so tuoi tang dang
            var increaseAge = students.OrderBy(student => student.Age)
                .Select(student => new { student.ID, student.Name, student.Age });
            Console.WriteLine($"\nSap xep theo thu tu tuoi tang dan");
            foreach (var x in increaseAge)
            {
                Console.WriteLine(x.ToString());
            }
        }
    }
}
