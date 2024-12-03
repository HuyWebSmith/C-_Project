using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab01_02
{
    internal class Program
    {
        static List<Student> studentsList = new List<Student>();
        static public void addStudent(List<Student> studentsList)
        {
            Console.WriteLine("=== Nhập thông tin sinh viên ===");
            Student student = new Student();
            student.Input();
            studentsList.Add(student);
            Console.WriteLine("Nhập thành công");
        }

        static void Display(List<Student> studentsList)
        {
            
            foreach (Student student in studentsList)
            {
                student.Show();
            }
        }

        // case 3 : danh sach sinh vien khoa CNTT
        static void DisplayByFaculty(List<Student> studentsList,string faculty)
        {
            Console.WriteLine("=== Danh sach sinh vien theo khoa {0} ===",faculty);
            var student = studentsList.Where(s => s.faculty.Equals(faculty, StringComparison.OrdinalIgnoreCase));
            Display(student.ToList());
        }

        //case 4 : danh sach sinh vien co diem tB lon hon 5
        static void DisplayScoreHigher5(List<Student> studentsList)
        {
            Console.WriteLine("=== Danh sach sinh viên có điểm trung bình lớn hơn 5 ===");
            var higherScore = studentsList.Where(hScore => hScore.score > 5.0);
            Display(higherScore.ToList());
        }

        //case 5 : Sap Xep theo diem tb tang dan
        static void SortScore(List<Student> studentsList)
        {
            Console.WriteLine("=== Danh sach sinh viên theo thứ tự tăng dần ===");
            var increaseScore = studentsList.OrderBy(inScore => inScore.score).ToList();
            Display(increaseScore);
        }

        //case 6 : danh sach sinh vien khoa CNTT ,danh sach sinh vien co diem tB lon hon 5
        static void DisplayByFacultyAndScoreHigher5(List<Student> studentsList, string faculty, double minTB)
        {
            Console.WriteLine("=== Danh sach sinh vien theo khoa {0} va diem trung binh lon hon {1}===", faculty,minTB);
            var students = studentsList.Where(s => s.faculty.Equals(faculty, StringComparison.OrdinalIgnoreCase) && s.score > minTB);
            Display(students.ToList());
        }

        //case 7 : danh sach sinh vien khoa CNTT ,danh sach sinh vien co diem lon nhat
        static void DisplayByFacultyAndMaxScore(List<Student> studentsList, string faculty)
        {
            Console.WriteLine("=== Danh sach sinh vien theo khoa {0} va diem trung binh lon nhất", faculty);
            var students = studentsList.Where(sv => (sv.faculty == "CNTT" && studentsList.Max(st1 => st1.score) == sv.score))
            .ToList();
            Display(students);
        }

        //case 8 : hay cho biet so luong cua tung xep loai trong danh sach
        static void Soluongxep(List<Student> studentsList)
        {
            Console.WriteLine("=== Danh sach sinh vien theo tung loai");
            var xuatSac = studentsList.Count(xuatsac => xuatsac.score >= 9 && xuatsac.score <= 10);
            var Gioi = studentsList.Count(gioi => gioi.score >= 8 && gioi.score < 9);
            var Kha = studentsList.Count(kha => kha.score >= 7 && kha.score < 8);
            var TB = studentsList.Count(tb => tb.score >= 5 && tb.score < 7);
            var Yeu = studentsList.Count(yeu => yeu.score >= 4 && yeu.score < 5);
            var Kem = studentsList.Count(kem => kem.score < 4);
            Console.WriteLine("Xuất sắc: {0} , Giỏi: {1} , Khá: {2} , Trung bình:{3} , Yếu:{4} , Kém:{5}",xuatSac,Gioi,Kha,TB,Yeu,Kem);
        }

        //case 9 : tim kiem sinh vien theo ho
        static void FirstNameSearch(List<Student> studentsList)
        {
            Console.WriteLine("Nhap Ho: ");
            String firstN = Console.ReadLine();   
            var firstName = studentsList.Where(fname => fname.name.ToLower().Contains(firstN.ToLower().Trim())).ToList();
            firstName.ForEach(x =>x.Show());
            
        }

        //case 10 : tim kiem sinh vien theo ten
        static void LastNameSearch(List<Student> studentsList)
        {
            Console.WriteLine("Nhap Ten: ");
            String name = Console.ReadLine();
            var Name = studentsList.Where(fname => fname.name.ToLower().Contains(name.ToLower())).ToList();
            Name.ForEach(x => x.Show());

        }

        static void Main(string[] args)
        {
            
            bool exit = false;
            while (!exit)
            {
                Console.InputEncoding = Encoding.UTF8;
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("=== MENU ===");
                Console.WriteLine("1. Thêm sinh viên");
                Console.WriteLine("2. Hiển thị danh sách sinh viên");
                Console.WriteLine("3. Hiển thị danh sách sinh viên khoa CNTT");
                Console.WriteLine("4. Hiển thị danh sách sinh viên có điểm trung bình hơn 5");
                Console.WriteLine("5. Hiển thị danh sách sinh viên theo thứ tự tăng dần");
                Console.WriteLine("6. Hiển thị danh sách sinh viên có điểm trung bình hơn 5 và khoa CNTT");
                Console.WriteLine("7. Hiển thị danh sách sinh viên có điểm trung bình lon nhat và khoa CNTT");
                Console.WriteLine("8. Hiển thị danh sách soó sinh viên Xuất sắc  Giỏi KHá Trung bình Yếu Kém");
                Console.WriteLine("9. Tìm theo Họ");
                Console.WriteLine("10. Tìm theo Tên");
                Console.WriteLine("0. Thoát");
                Console.WriteLine("Chọn chức năng: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: 
                        addStudent(studentsList); 
                        break;
                    case 2:
                        Console.WriteLine("=== Danh sách sinh viên đã thêm ===");
                        Display(studentsList);
                        break;
                    case 3:
                        DisplayByFaculty(studentsList, "CNTT");
                        break;
                    case 4:
                        DisplayScoreHigher5(studentsList);
                        break;
                    case 5:
                        SortScore(studentsList);
                        break;
                    case 6:
                        DisplayByFacultyAndScoreHigher5(studentsList,"CNTT" , 5);
                        break;
                    case 7:
                        DisplayByFacultyAndMaxScore(studentsList, "CNTT");
                        break;
                    case 8:
                        Soluongxep(studentsList);
                        break;
                    case 9:
                        FirstNameSearch(studentsList);
                        break;
                    case 10:
                        LastNameSearch(studentsList);
                        break;
                    case 0:
                        exit = true;
                        Console.WriteLine("Thoát chương trình");
                        break;
                    default:
                        Console.WriteLine("Không hợp lệ!!");
                        break;
                }
            }
        }
    }
}
