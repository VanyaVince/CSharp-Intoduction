using System;
using System.Collections.Generic;

namespace CALCULATOR_OOP.Service
{
    public class CalculatorService
    {
        public static void EraseInvalidValue(int cursorLeft, int cursorTop)
        {
            Console.SetCursorPosition(cursorLeft, Console.CursorTop - 1);
            Console.Write(new String(' ', Console.BufferWidth));
            Console.SetCursorPosition(cursorLeft, cursorTop);
        }


        public static string DisplayDashes()
        {
            return "====================";
        }

        public static void ShowMenu()
        {
            var addition = 1;
            var subtraction = 2;
            var multiplication = 3;
            var division = 4;
            var matrixMultiplication = 5;
            var calculationHistory = 6;
            var exit = "ctrl + C";

            Console.WriteLine("Choose operation 'digit', according to the specification below");
            Console.WriteLine(
                $"[Sum - {addition}][Subtraction - {subtraction}][Multiplication - {multiplication}][Division - {division}] " +
                $"[Matrix Multiplication - {matrixMultiplication}][History - {calculationHistory}][Exit - {exit}]");
            Console.WriteLine();

            Console.WriteLine("Choose operation");

        }
    }
}