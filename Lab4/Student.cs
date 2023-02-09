using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Student : Person
    {
        private double _gpa;
        public Student(string name, int iYear, int age)
            : base(name, iYear, age) 
        {
        }
     
    }
}
