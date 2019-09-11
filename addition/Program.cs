using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addition
{
    class Program
    {
        static int firstNumber;
        static int secondNumber;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number");
            firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(firstNumber + " + " + secondNumber + " = " + (firstNumber + secondNumber));
            

        }

        private static void addition (int a, int b)
        {
            Console.WriteLine(a + " + " + b + " = " + a + b);
        }
    }
}
