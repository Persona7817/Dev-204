using System;
using System.Collections.Generic;

namespace SALab2
{
    public class Degree


    {
        private string degreeName;

        public string DegreeName { get => degreeName; set => degreeName = value; }
        internal List<Course> CourseAvail { get; set; } = new List<Course>();

        public Degree(String degreename)
        {

            this.DegreeName = degreename;
        }

        public Degree(string degreename, List<Course> CoursesAvail)
        {
            this.DegreeName = degreename;
            this.CourseAvail = CourseAvail;
        }
        // public string Name()
        //{
        //  return this.DegreeName;
        //}

        public void AddCourse(Course course)
        {

            CourseAvail.Add(course);
        }
    }

}
