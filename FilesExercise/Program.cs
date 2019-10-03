using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Vince\Desktop\ITechArt'QA Automation'.txt";
            FileInfo fi = new FileInfo(path);
            FileStream fs = fi.OpenRead();
            byte[] b = new byte[fi.Length];
            UTF8Encoding temp = new UTF8Encoding(true);
            var str = "";

            while (fs.Read(b, 0, b.Length) > 0)
            {
                str += temp.GetString(b);
            }

            Console.WriteLine($"The length of the file words is: {str.Split(' ').Length}");
        }
    }
}
