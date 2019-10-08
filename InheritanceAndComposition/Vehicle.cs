using System;

namespace InheritanceAndComposition
{
    public class Vehicle
    {
        public int Weight { get; set; }
        public int Price { get; set; }

        public void FixTires()
        {
            Console.WriteLine("All tires are changed");
        }

    }
}