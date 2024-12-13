using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_03
{
    public class Student
    {
        private string mSSV;
        private string ten;
        private string khoa;
        private float diem;

        public Student(string mSSV, string ten, string khoa, float diem)
        {
            this.mSSV = mSSV;
            this.ten = ten;
            this.khoa = khoa;
            this.diem = diem;
        }
        public Student()
        {
            
        }

        public string MSSV { get => mSSV; set => mSSV = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Khoa { get => khoa; set => khoa = value; }
        public float Diem { get => diem; set => diem = value; }
    }

}
