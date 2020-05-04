using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SALab3
{
    public class Student:Person
    {
        
       // public string FirstName { get; set; }
       // public string LastName { get; set; }
        private static int studentCount = 0;
        public static int StudentCount { get => studentCount; }

        public Student(String firstname, String lastname): base(firstname,lastname)
            
        {
            //properties of student
            //this.FirstName = firstname;
            //this.LastName = lastname;
            studentCount++;
        }

        public static int CountStudents()
        {
            return StudentCount;
        }

       



    }






}

