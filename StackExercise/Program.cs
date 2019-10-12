using System;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StackExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

//            stack.Push(null);

            for (int i = 0; i < 5; i++)
                stack.Push("Object: " + (i + 1));

            for (int i = 0; i < 5; i++)
            {
                var lastItem = stack.Pop();
                Console.WriteLine(lastItem);
            }

            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                stack.Push(DateTime.Now);
            }

            for (int i = 0; i < 5; i++)
            {
                var lastItem = stack.Pop();
                Console.WriteLine(lastItem);
            }
        }
    }
}
