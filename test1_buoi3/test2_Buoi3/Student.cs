using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace test2_Buoi3
{
    internal class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }

        public Student(int id, string name, string phone)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
        }

        public Student()
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
        }
    }
}
    

