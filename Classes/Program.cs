using System;
using System.Runtime.InteropServices;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();
            person.Name = "Vince";
            person.Introduce("Vanya");
            person.Orders.Add(new Orders());
            person.Orders.Add(new Orders());
            Console.WriteLine("The number of purchases that user did " + person.Orders.Count);

            var person1 = Person.Parse("Vince");
            person1.Introduce("Vanya");

            person1.ShowYears(1999, 2000, 2005, 2010);

            int age;
            Person.Initialize(out age);
            var person2 = new Person("Vanya", age);
            Console.WriteLine(person2);
        }

        static void CheckingOfNumber()
        {
            var number = 0;
            Console.WriteLine("Write a number");
            var parse = int.TryParse(Console.ReadLine(), out number);
            if (parse)
            {
                Console.WriteLine("Parse is completed successfully");
            }
            else
            {
                Console.WriteLine("Something goes wrong");
            }
        }
    }
}
