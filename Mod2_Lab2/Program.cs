using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee1 = new TechnicalEmployee("Jon");
            var employee2 = new TechnicalEmployee("Adarsha");
            var employee3 = new BusinessEmployee("Max");

            Console.WriteLine(employee1.employeeStatus() + "..." +
                employee2.employeeStatus() + "..." +
                employee3.employeeStatus());
        }
    }
}
