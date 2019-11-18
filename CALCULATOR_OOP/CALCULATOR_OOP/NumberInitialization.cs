using System;

namespace CALCULATOR_OOP
{
    public class NumberInitialization
    {
        public static object GetNumber()
        {
            while (true)
            {
                if (Double.TryParse(Console.ReadLine(), out double number))
                    return number;

                CalculatorService.EraseInvalidValue(Console.CursorLeft, Console.CursorTop - 1);
            }
        }
    }
}