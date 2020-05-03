using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SALab1
{
    public class Teacher
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        private static int TeacherCount = 0;

        public Teacher(string firstname, string lastname)
        {
            //properties of teacher
            this.FirstName = firstname;
            this.LastName = lastname;
            TeacherCount++;

        }

        public static int CountTeacher()
        {
            return TeacherCount;
        }

        public string TeacherFirstName()
        {
            return this.FirstName;

        }

        public string TeacherLasttName()
        {
            return this.LastName;

        }

    }
}
