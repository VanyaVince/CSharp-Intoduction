using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Vince\source\repos\ConsoleApp1\users.json";
            Logger logger = new Logger(new User("Vanya", "Tarakan123".Trim()), new FileCheck(path));
            logger.Log();
        }
    }
}
