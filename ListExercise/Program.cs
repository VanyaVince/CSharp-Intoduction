using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise1();
            //Exercise2();
            Exercise3();
        }
        /*display on the console people who like your post*/
        private static void Exercise1()
        {
            Console.WriteLine("Write a sequence of names or press enter to terminate the program");
            var names = new List<string>();

            while (true)
            {
                var name = Console.ReadLine();
                if (!string.IsNullOrEmpty(name))
                    names.Add($"[{name}]");
                else
                {
                    var arrayNames = names.ToArray();
                    var result = "";
                    switch (arrayNames.Length)
                    {
                        case 0:
                            break;

                        case 1:
                            result = string.Join(", ", arrayNames, 0, arrayNames.Length);
                            Console.WriteLine($"{result} likes your post");
                            break;

                        case 2:
                            result = string.Join(",", arrayNames, 0, arrayNames.Length);
                            Console.WriteLine($"{result} like your post");
                            break;

                        default:
                            result = string.Join(",", arrayNames, 0, 2);
                            Console.WriteLine($"{result} and {arrayNames.Length - 2} more other(s) people like your post");
                            break;
                    }
                    break;
                }
            }
        }
        /*reverse*/
        private static void Exercise2()
        {
            Console.WriteLine("Write your name and get the reverse");
            var name = Console.ReadLine();
            while (true)
            {
                if (!string.IsNullOrEmpty(name))
                {
                    var ch = name.ToCharArray();
                    Array.Reverse(ch);
                    var reverse = string.Join("", ch);
                    Console.WriteLine($"The reverse of {name} is {reverse}");
                    break;
                }
                else
                    Console.WriteLine("Invalid value");
            }
        }

        private static void Exercise3()
        {
            Console.WriteLine("Write 5 unique numbers");
            var numbers = new List<int>();
            while (numbers.Count != 5)
            {
                Console.WriteLine($"You need to enter {(5 - numbers.Count)} number(s)");
                var userCharacter = int.Parse(Console.ReadLine());
                if (!numbers.Contains(userCharacter))
                    numbers.Add(userCharacter);
                else
                    Console.WriteLine($"{userCharacter} is already entered, each number should be unique. Do it again");
            }
            numbers.Sort();
            var result = string.Join(", ", numbers);
            Console.WriteLine($"The entered, sorted numbers are: {result}");
        }
    }
}
