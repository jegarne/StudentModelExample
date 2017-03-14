using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student.Models
{
    public class Student
    {
        private string name;
        private int studentId;
        private int numberOfCredits = 0;
        private double gpa = 0;

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public int StudentId
        {
            get { return studentId; }
            private set { studentId = value; }
        }

        public int NumberOfCredits
        {
            get { return numberOfCredits; }
            set { numberOfCredits = value; }
        }

        public double Gpa
        {
            get { return gpa; }
            set { gpa = value; }
        }
        
        //public string Name { get; set;}
        //public int StudentId { get; set; }
        //public int Credits { get; set; } = 0;
        //public double GPA { get; set; } = 0;
    }
}
