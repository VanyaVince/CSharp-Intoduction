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
            var lengthOfFile = Exercise1(path);
            var longestWord = Exercise2(path);
            Console.WriteLine(lengthOfFile +"\n"+ longestWord);

        }
        /*Read file and sum all word*/
        private static string Exercise1(string path)
        {
            var count = GetFile(path);
            return $"The length of the file words is: {count.Split(' ').Length}";
        }

        /*Searching the longest word in a file*/
        private static string Exercise2(string path)
        {
            var file = GetFile(path);
            var theLongestWord = "";
            foreach (var word in file.Split(' '))
            {
                theLongestWord = (theLongestWord.Length < word.Replace(",", "").Trim().Length) ? word : theLongestWord;
            }

            return $"The longest word is: {theLongestWord}";
        }

        private static string GetFile(string path)
        {
            FileInfo fi = new FileInfo(path);
            FileStream fs = fi.OpenRead();
            byte[] b = new byte[fi.Length];
            UTF8Encoding temp = new UTF8Encoding(true);

            var str = "";

            while (fs.Read(b, 0, b.Length) > 0)
                str += temp.GetString(b);

            return str;
        }
    }
}
