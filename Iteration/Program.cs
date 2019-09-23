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
            Exercise1DividedBy3();
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
    }
}
