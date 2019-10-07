using System;

namespace Exercise1StopWatch
{
    public class UserService
    {
        public static int GetUserDecision(string str)
        {
            while (true)
            {
                if (int.TryParse(str, out int c) && c == 2 || c == 1)
                    return c;

                Console.WriteLine("Invalid value, press '2' to terminate the program or '1' start it again");

                str = Console.ReadLine();
            }
        }
    }
}