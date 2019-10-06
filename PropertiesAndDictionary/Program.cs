using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var school = new School(number: 150)
            {
                ["5A"] = "Marina", ["5B"] = "Keck", ["5C"] = "Sunny", ["5D"] = "Michael"
            };

            Console.WriteLine($"The name of 5A class teacher, school number of {school.Number} is {school["5A"]}");

            Console.WriteLine();

            school.ReadAllTeachers();

            Console.WriteLine();
            school["5A"] = "Mary";
            Console.WriteLine($"The name of 5A class teacher, school number of {school.Number} is {school["5A"]}");

            Console.WriteLine();

            school.ReadAllTeachers();
        }
    }
}
