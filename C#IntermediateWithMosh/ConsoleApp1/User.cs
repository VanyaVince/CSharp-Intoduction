using System;

namespace ConsoleApp1
{
    public class User
    {
        public String Login { get; set; }
        public String Password { get; set; }

        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}