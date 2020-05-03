using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SALab1
{
    public class Student
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private static int studentCount = 0;
        public static int StudentCount { get => studentCount; }

        public Student(String firstname, String lastname)
        {
            //properties of student
            this.FirstName = firstname;
            this.LastName = lastname;
            studentCount++;
        }

        public static int CountStudents()
        {
            return StudentCount;
        }

        public string StudentFirstName()
        {
            return this.FirstName;

        }

        public string StudentLasttName()
        {
            return this.LastName;

        }



    }






}

