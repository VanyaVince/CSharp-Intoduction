using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummarizingText
{
    public class StringUtility
    {
        public static string SummarizeText(string str, int maxLength = 25)
        {
            var totalLengthOfWords = 0;
            var wordsCount = 0;

            if (str.Length <= maxLength)
                return str.Trim() + "...";

            var summaryWords = str.Split(' ');
            foreach (var summaryWord in summaryWords)
            {
                wordsCount += 1;
                totalLengthOfWords += summaryWord.Length;
                if (totalLengthOfWords >= maxLength)
                    break;
            }

            var summary = string.Join(" ", summaryWords , 0, wordsCount);
            return summary + "...";
        }
    }
}
