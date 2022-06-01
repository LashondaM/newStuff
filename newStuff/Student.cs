using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newStuff
{
    internal class Student
    {
        public string Name { get; set; }
        public string Major { get; set; }
        public double Gpa { get; set; }

        public Student(string name, string major, double gpa)
        {
            Name = name;
            Major = major;
            Gpa = gpa;
        }

        public bool HasHonors()
        {
            if(Gpa >= 3.5)
            {
                return true;
            }

            return false;
        }
    }
}
