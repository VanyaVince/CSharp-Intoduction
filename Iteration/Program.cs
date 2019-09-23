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
            //Exercise3Factorial();
            Exercise4Lottery();

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
        /*summary
         compute the factorial of a number*/
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
        /*summary
         user's guessing. The random class gave as a random number from 1 to 10, user has 4 attempt to guess what is this number'*/
        private static void Exercise4Lottery()
        {
            const int attempts = 4;
            Random random = new Random();
            var randomNumber = random.Next(1, 10);
            Console.WriteLine("The computer picked a random number within the specified range from 1 to 10.");
            for (var i = attempts; i != 0; i--)
            {
                Console.WriteLine($"You got {i} more attempt(s) to guess what is this number");
                var userNumber = Convert.ToInt32(Console.ReadLine());
                if (userNumber == randomNumber)
                {
                    Console.WriteLine($"You won, the lucky number was {randomNumber}");
                    break;
                }
            }
            Console.WriteLine($"You lost, the picked number was {randomNumber}");
        }
    }
}
