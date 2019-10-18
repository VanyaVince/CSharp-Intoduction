using System;
using System.Threading;

namespace Exercise1StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new StopWatch();

            while (true)
            {
                stopWatch.Start();

                Console.WriteLine("The program has been started. Enter '2' to terminate and get the duration between start and finish or '1' to launch it again");

                if (UserService.GetUserDecision(Console.ReadLine()) == 2)
                {
                    stopWatch.End();

                    var interval = stopWatch.GetDuration();

                    // ReSharper disable once UseFormatSpecifierInInterpolation
                    Console.WriteLine($"The duration is: {interval.ToString(@"hh\:mm\:ss")}");

                    Console.WriteLine();

                    Console.WriteLine("Enter '1' to launch the program again or '2' to terminate it");

                    if (UserService.GetUserDecision(Console.ReadLine()) == 2)
                        break;
                }
            }
        }
    }
}
