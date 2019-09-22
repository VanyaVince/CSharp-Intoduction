using System;

namespace If_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1_EnterNumber();
            Task2_FindMaxValue();
            Task3_LandscapeOrPortrait();
            Task4_SpeedLimit();
        }
        private static void Task1_EnterNumber()
        {
            Console.WriteLine("Please enter a number from 1 to 10");
            var number = Int32.Parse(Console.ReadLine());
            if (number >= 1 && number <= 10)
                Console.WriteLine("The entered number is valid");
            else
                Console.WriteLine("The entered number is invalid");
        }
        private static void Task2_FindMaxValue()
        {
            Console.WriteLine("Please enter the first number");
            var firstNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            var secondNumber = Int32.Parse(Console.ReadLine());
            var max = (firstNumber > secondNumber) ? firstNumber : secondNumber;
            Console.WriteLine("The max is : " + max);
        }
        private static void Task3_LandscapeOrPortrait()
        {
            Console.WriteLine("Please enter height in px");
            var height = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter width in px");
            var width = Int32.Parse(Console.ReadLine());
            if (height > width)
                Console.WriteLine("It's portrait");
            else
                Console.WriteLine("It's Landscape");
        }
        private static void Task4_SpeedLimit()
        {
            Console.WriteLine("Please enter the speed limit");
            var speedLimit = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is your current speed?");
            var currentSpeed = Int32.Parse(Console.ReadLine());
            if (currentSpeed <= speedLimit)
                Console.WriteLine("You are doing well");
            else
            {
                var demeritPoint = (currentSpeed - speedLimit) / 5;
                var result = (demeritPoint >= 12) ? string.Format("Demerit Points of yours are {0}, the license are suspended", demeritPoint) : string.Format("You got {0} demerit points", demeritPoint);
                Console.WriteLine(result);
            }
        }
    }
}
