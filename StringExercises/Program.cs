using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            exercise1();
        }
        /*Write a program and ask the user to enter a few numbers separated by a hyphen.
         Work out if the numbers are consecutive. 
         For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".*/
        private static void exercise1()
        {
            Console.WriteLine("Please, write a few numbers separated by a hyphen");

            while (true)
            {
                var userString = Console.ReadLine();
                /*If string is null, start over*/
                if (string.IsNullOrEmpty(userString))
                {
                    Console.WriteLine("Sorry but the sequence of numbers is entered incorrectly, re-try again using a hyphen sign ");
                    continue;
                }
                
                var ifOnlyNumbers = string.Join("", userString.Split('-'));

                if (int.TryParse(ifOnlyNumbers, out int c))
                {
                    var numbers = userString.Split('-').Select(int.Parse).ToList();
                    var isConsecutive = true;
                    for (int i = 0; i < numbers.Count - 1; i++)
                    {
                        if (Math.Abs(numbers[i] - numbers[i + 1]) != 1)
                        {
                            Console.WriteLine($"The sequence of numbers '{userString}' is 'Not Consecutive'");
                            isConsecutive = false;
                            break;
                        }
                    }
                    if (isConsecutive)
                        Console.WriteLine($"The sequence of numbers '{userString}' is 'Consecutive'");
                    break;
                }
                /*if userString consists of letter*/
                else
                    Console.WriteLine("Sorry but the sequence of numbers is entered incorrectly, re-try again using a hyphen sign");
            }
        }
    }
}
