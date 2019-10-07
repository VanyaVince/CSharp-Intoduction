using System;
using System.Threading;

namespace Exercise1StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new StopWatch();
            var counter = 0;


            while (true)
            {
                stopWatch.Start(DateTime.Now);

                Console.WriteLine("The program has been started. Enter '2' to terminate and get the duration between start and finish or '1' to launch it again");

                if (UserService.GetUserDecision(Console.ReadLine()) == 2)
                {
                    stopWatch.End(DateTime.Now);

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
