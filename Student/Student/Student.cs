using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1
{
    internal class Student
    {
        private int id;
        private String name;
        private int age;

            
        public Student()
        {

        }
        public Student(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        //property
        public int ID {  get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }


        public override string ToString()
        {
            return id + " " + name + " " + age;
        }
    }
}
