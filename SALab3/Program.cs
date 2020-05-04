using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SALab3
{
    class Program
    {
        static void Main(string[] args)
        {
            UProgram program1 = new UProgram(" Information Technology");
            Student Student1 = new Student("John", "Doe");
            Student Student2 = new Student("Jane", "Doe");
            Student Student3 = new Student("Max","Doe");

            Student1.Read("student.txt");
            Student1.Write("Student.txt");
            Student1.Read("Student.txt");
            //Student1.Dispose();

            Teacher Teacher1 = new Teacher("Adam","King");
            Course course1 = new Course("Programming with C#");
            Course course2 = new Course("OS");
            Teacher Teacher2 = new Teacher("Kylie","Patterson");
            course1.AddTeacher(Teacher1);
            course2.AddTeacher(Teacher2);
            course1.AddStudent(Student1);
            course1.AddStudent(Student2);
            course2.AddStudent(Student3);
            Degree degree1 = new Degree("Bachelor");
            degree1.AddCourse(course1);
            program1.AddDegree(degree1);

            Console.WriteLine("The Program is {0} and its degrees are:", program1.UprogName);

            foreach (Degree d in program1.DegreeAvail)
            {
                Console.WriteLine("\t {0}", d.DegreeName);
            }

            Console.WriteLine();
            Console.WriteLine("The first degree is {0} and its available courses are:", degree1.DegreeName);

            foreach (Course c in degree1.CourseAvail)
            {
                Console.WriteLine("\t {0}", c.CourseName);
            }

            Console.WriteLine();
            Console.WriteLine("Total number of students: {0}", Student.StudentCount);

        }
    }
}
