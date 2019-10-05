using System;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"D:\MyITechArt'QA Automation'.txt";
            try
            {
                File.Copy(@"C:\Users\Vince\Desktop\ITechArt'QA Automation'.txt", path, true);
                //File.Delete(path);
                if (!File.Exists(path))
                    Console.WriteLine("The file was copied and then deleted successfully");
                var file = File.ReadAllText(path);
                Console.WriteLine($"The file has next text \n{file}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
