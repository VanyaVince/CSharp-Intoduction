using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            /*DataTime object shows a specific day(as the matter of the fact - my birthday).
             It has a bunch of methods forming them to a string */
            var dateTime = new DateTime(1994,8, 5, 16, 00 ,00);
            Console.WriteLine("LongDateString: " + dateTime.ToLongDateString());
            Console.WriteLine("ShortDateString: " + dateTime.ToShortDateString());
            Console.WriteLine("LongTimeString: " + dateTime.ToLongTimeString());
            Console.WriteLine("ShortTimeString: " + dateTime.ToShortTimeString());

            Console.WriteLine();
            /*The static method now has a bunch of methods as well letting us display the properties that we need the most on the console. Once you declared it can't be changed. It's immutable*/
            var now = DateTime.Now;
            Console.WriteLine("Method \"now\"  of DateTime object:");
            Console.WriteLine("Hour is: " + now.Hour + "th");
            Console.WriteLine("Minute is: " + now.Minute + "th");
            Console.WriteLine("Second is: " + now.Second + "th");
            Console.WriteLine("Millisecond is: " + now.Millisecond + "th");
            Console.WriteLine($"Today: {now}");
            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);
            Console.WriteLine($"Tomorrow: {tomorrow}");
            Console.WriteLine($"Yesterday: {yesterday}");

            /*now.ToString has a lot of overloads, can provide with a specific date form, custom date and time format*/
            Console.WriteLine($"Using the specifier the current day is: {now:yyyy-MM-dd}");
        }
    }
}
