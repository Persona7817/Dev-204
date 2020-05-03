using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SALab1
{
    public class Course

    {
        public string CourseName { get; set; }
        internal List<Teacher> Teachers { get; set; } = new List<Teacher>();
        internal List<Student> Students { get; set; } = new List<Student>();

        public Course(string courseName)
        {

            this.CourseName = courseName;

        }

        public Course(string courseName, List<Teacher> teachers, List<Student> students)
        {
            this.CourseName = courseName;
            this.Teachers = teachers;
            this.Students = students;
        }


        public void AddTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
        }
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
    }
}
