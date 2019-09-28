using System;

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


            /*timeSpan*/
            Console.WriteLine();
            var time = new TimeSpan(1,2,3);
            //display only minutes
            Console.WriteLine("TimeSpan in minutes: " + time.Minutes);
            //display timeSpan as only minutes "TotalMinutes"
            Console.WriteLine("TimeSpan in TotalMinutes: " + time.TotalMinutes);
            //add, subtract time to (from) the current timeSpan
            Console.WriteLine("Add a few minutes to current timeSpan: " + time.Add(TimeSpan.FromMinutes(8)).TotalMinutes);
            Console.WriteLine("Subtract a few minutes from current timeSpan: " + time.Subtract(TimeSpan.FromMinutes(2)).TotalMinutes);

            //convert from String to timeSpan
            var parseTimeSpan = TimeSpan.Parse("20:05:59");
            Console.WriteLine($"Converted string to timeSpan {parseTimeSpan}");
        }
    }
}
