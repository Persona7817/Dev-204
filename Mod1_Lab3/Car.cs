using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mod1_Lab3
{
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
