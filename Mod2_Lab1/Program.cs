using System;

namespace Mod2_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee1 = new Employee("Jon", 2000);
            var employee2 = new TechnicalEmployee("Adarsha");
            var employee3 = new BusinessEmployee("Max");

            Console.WriteLine(employee1.employeeStatus()+ "..." +
                employee2.employeeStatus()+ "..." +
                employee3.employeeStatus());
        }
    }
}
