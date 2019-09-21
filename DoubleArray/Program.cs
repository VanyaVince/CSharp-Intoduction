using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var array1 = new int[6];
            var array2 = new int[6];

            for (var i = 0; i < array1.Length; i++)
            {
                array1[i] = i + 1;
                for (var j = 0; j < array2.Length; j++)
                {
                    array2[j] = j + 1;
                    Console.Write(string.Format("{0}{1} ", array1[i], array2[j] ));
                    if (j == 5)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
