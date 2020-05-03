using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//constructors and Static members

namespace Mod1_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            //instantiating an object of car() class by using type inference called Car1
            var Car1 = new Car();
            
            Car1.Color = "White";
            Car1.Year = 2010;
            Car1.Mileage = 11000;

            var Car2 = new Car("Red", 2008);
            int carCount = Car.CountCars();

            Console.WriteLine($"There are {carCount} cars on inventory right now");
                }
    }

    //declaring Car
    public class Car
    {
        //properties of car
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        // If car's mileage is unknown we still need to add the car to inventory-- how do we do it?
        //use constructor for instantiating Car() with available properties only

        public Car(String color, int year)
        {
            //properties of car
            this.Color = color;
            this.Year = year;
            instances++;
        }

        public Car(int year, int mileage)
        {
            this.Year = year;
            this.Mileage = mileage;
            instances++;
        }
        //to add a static property to our Car() Class.It is crucial for car dealerships to keep track of how many cars are on inventory.
        private static int instances = 0;

        public Car()
        {
            instances++;
        }

        public static int CountCars()
        {
            return instances;
        }

    }

}
