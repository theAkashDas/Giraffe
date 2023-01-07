using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Student
    {
        string name;
        string major;
        private double gpa;
        public Student(string name, string major, double gpa)
        {
            this.name = name;
            this.major = major;
            Gpa = gpa;
        }
        public bool hasPassed()
        {
            return this.gpa > 3;
        }
        public double Gpa
        {
            get { return this.gpa; }
            set 
            {
                if(value <= 5 && value >= 0)
                    this.gpa = value;
                else
                    this.gpa = 0;
            }
        }
    }
}
