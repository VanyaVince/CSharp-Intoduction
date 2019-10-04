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
            var summary = StringUtility.SummarizeText(sentence, 25);
            Console.WriteLine(summary);
        }
    }
}
