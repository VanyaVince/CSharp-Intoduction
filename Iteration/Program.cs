using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise1DividedBy3();
            //Exercise2SumNumbers();
            Exercise3Factorial();

        }
        /*summary
        display the count of all characters(numbers) that are divisible by 3 with no remainder */
        private static void Exercise1DividedBy3()
        {
            var count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }

            Console.WriteLine(count);
        }
        /*summary
         sum the numbers that the user entered*/
        private static void Exercise2SumNumbers()
        {
            var count = 0;
            while (true)
            {
                Console.WriteLine("Please enter a number");
                var number = Console.ReadLine();

                if (string.IsNullOrEmpty(number))
                {
                    Console.WriteLine("The sum of the entered numbers is: " + count);
                    break;
                }
                else
                    Console.WriteLine("@Echo: " + number);
                count += Convert.ToInt32(number);
            }
        }

        private static void Exercise3Factorial()
        {
            var count = 1;
            Console.WriteLine("Enter a number in order to compute the factorial");
            var number = Convert.ToInt32(Console.ReadLine());
            for (var i = number; i >= 1; i--)
            {
                count *= i ;
                //Console.WriteLine(count);
            }
            Console.WriteLine("Factorial is: " + count);
        }
    }
}
