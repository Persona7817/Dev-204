using System;
namespace SALab2
{
    public class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }


        public Person(string firstname, String lastname)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
        }
    }
}
