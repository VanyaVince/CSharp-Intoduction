using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummarizingText
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "We will look at a variety of different topics that are directly related to programming, and by the end, you should be able to answer questions like:";
            Console.WriteLine(Summarize(sentence, 33));
            
        }

        private static string Summarize(string str, int maxLength = 25)
        {
            var result = "";

            if (str.Length < maxLength)
                return $"Invalid value. The length of string are less then {maxLength}";

            for (int i = 0; i < maxLength; i++)
                result += str[i];

            return result.Trim() + "...";
        }
    }
}
