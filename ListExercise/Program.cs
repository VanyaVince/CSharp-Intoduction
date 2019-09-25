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
            Exercise1();
        }

        private static void Exercise1()
        {
            Console.WriteLine("Write a sequence of names or press enter to terminate the program");
            var names = new List<string>();

            while (true)
            {
                var name = Console.ReadLine();
                if (!string.IsNullOrEmpty(name))
                {
                    names.Add($"[{name}]");
                }
                
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
    }
}
