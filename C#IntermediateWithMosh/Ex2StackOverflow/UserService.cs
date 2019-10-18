using System;

namespace Ex2StackOverflow
{
    public class UserService
    {
        public  static string GetUserDecision(string str)
        {
            while (true)
            {
                if (str != null && (str == "like" || str == "dislike" || str == "exit"))
                    return str;

                Console.WriteLine("Invalid value, re-try again");
                str = Console.ReadLine();
            }
        }
    }
}