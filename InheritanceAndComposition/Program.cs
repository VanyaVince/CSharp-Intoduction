using System;

namespace InheritanceAndComposition
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            var bicycle = new Bicycle(new Vehicle());

            car.Model = "Volkswagen";
            car.Weight = 10;
            car.Price = 55;

            Console.WriteLine($"The vehicle {car.Model} has been delivered with tire issues. Weight is {car.Weight}, price: {car.Price}");
            car.FixTires();
            Console.WriteLine();

            bicycle.Type = "two-wheel";
            Console.WriteLine($"{bicycle.Type} has been delivered");
            bicycle.Repair();
        }
    }
}
