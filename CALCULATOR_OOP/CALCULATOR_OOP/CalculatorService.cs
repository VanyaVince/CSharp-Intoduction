using System;
using System.Collections.Generic;

namespace CALCULATOR_OOP
{
    public class CalculatorService
    {
        public static void EraseInvalidValue(int cursorLeft, int cursorTop)
        {
            Console.SetCursorPosition(cursorLeft, Console.CursorTop - 1);
            Console.Write(new String(' ', Console.BufferWidth));
            Console.SetCursorPosition(cursorLeft, cursorTop);
        }

        public static void DisplayArgument(string message)
        {
            Console.WriteLine($"The first argument is: {message}. Enter the other");
        }

        public static void DisplayHistory(Dictionary<string, Operation> operationsHistory)
        {
            Console.Clear();

            if (operationsHistory == null)
                Console.WriteLine("No operation has been done yet.\nPress any characters");

            else
                Console.WriteLine($"Operations history:\n{operationsHistory}\nPress any characters");

            Console.ReadLine();
            Console.Clear();
        }

        public static string DisplayDashes()
        {
            return "====================";
        }

        public static void DisplayError(string message)
        {
            Console.Clear();
            Console.WriteLine($"{message}. Press anything");
            Console.ReadLine();
            Console.Clear();
        }
    }
}