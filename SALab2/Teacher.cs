using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SALab2
{
    public class Teacher:Person
    {

        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        private static int TeacherCount = 0;

        public Teacher(string firstname, string lastname): base(firstname, lastname)
        {
            //properties of teacher
            //this.FirstName = firstname;
            //this.LastName = lastname;
            TeacherCount++;

        }

        public static int CountTeacher()
        {
            return TeacherCount;
        }

        
    }
}
