using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Student
    {
        public string IdName { get; set; }
        public int Age { get; set; }

        public string Degree { get; set; }

        public Student(string idName, int age, string degree)
        {
            IdName = idName;
            Age = age;
            Degree = degree;
        }
    }
}
