using System;

namespace ConsoleApp1
{
    public class Logger
    {
        private readonly ICheck _iCheck;
        private readonly User _user;

        public Logger(User user, ICheck iCheck)
        {
            this._iCheck = iCheck;
            this._user = user;
        }
        public void Log()
        {
            if (this._iCheck.IfExist(this._user.Login))
                Console.WriteLine("This name has already been used");

            else
            {
                this._iCheck.Record(this._user);
                Console.WriteLine("User {0} has been logged", _user.Login);
            }
        }

    }
}