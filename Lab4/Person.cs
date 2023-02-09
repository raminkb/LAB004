using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Person
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public double Grade { get; set; }
        public Person(string name, int year, double grade)
        {
            this.Name = name;
            this.Year = 2023 - year;
            this.Grade = grade;
        }

        /* public double getGPA() {
            return this.iGPA;
        }
      public int getAge() 
        { 
         return this.age;
        }
        public int getbYear()
        {
            return this.iYear;
        }
        public string getName()
        {
            return this.name;
        } */
    }
}
