using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of stairs");
            var input = int.Parse(Console.ReadLine());
            var count = GetCount(input + 1, input);
            Console.WriteLine("output: {0}", count);
        }

        private static int GetCount(int prevLevel, int stair)
        {
            if (stair == 0)
                return 1;

            var count = 0;
            // ReSharper disable once LoopVariableIsNeverChangedInsideLoop
            for (int level = 1; level < prevLevel; level++)
            {
                if ((stair - level) < 0)
                    return count;

                count += GetCount(level, stair - level);
            }

            return count;
        }
    }
}
