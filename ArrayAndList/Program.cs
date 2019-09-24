using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndList
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 1000, 74, 868, 9, 65 };

            /*Array.Length*/
            var lengthOfArray = numbers.Length;
            Console.WriteLine("The length is: " + numbers.Length);

            /*Array.IndexOf()*/
            var index = Array.IndexOf(numbers, 1000);
            Console.WriteLine("The index of 1000 is: " + index);

            /*Array.Clear()*/
            Array.Clear(numbers, 0, 2);

            Console.WriteLine("Effect of clear method:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            /*Array.Copy()*/
            var anotherArray = new int[3];
            Array.Copy(numbers, 2, anotherArray, 0, 3);
            Console.WriteLine("The values of copied array:");
            foreach (var i in anotherArray)
            {
                Console.WriteLine(i);
            }
            /*Array.Sort()*/
            Console.WriteLine("The values of sorted array:");
            Array.Sort(anotherArray);
            foreach (var i in anotherArray)
            {
                Console.WriteLine(i);
            }
            /*Array.Reverse()*/
            Console.WriteLine("The values of reversed array:");
            Array.Reverse(anotherArray);
            foreach (var i in anotherArray)
            {
                Console.WriteLine(i);
            }
        }
    }
}
