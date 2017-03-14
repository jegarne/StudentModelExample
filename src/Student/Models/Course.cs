using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student.Models
{
    public class Course
    {
        private string name;
        private int courseId;
        private List<Student> students;

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public int CourseId
        {
            get { return courseId; }
            private set { courseId = value; }
        }

        public List<Student> Students
        {
            get { return students; }
            private set { students = value; }
        }
    }
}
