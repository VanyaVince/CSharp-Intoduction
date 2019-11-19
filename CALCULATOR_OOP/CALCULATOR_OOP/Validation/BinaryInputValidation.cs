using System;

namespace CALCULATOR_OOP
{
    public class BinaryInputValidation
    {
        public double Validate(int cursorPosition = 0)
        {
            Console.WriteLine("Enter Number");
            while (true)
            {
                if (Double.TryParse(Console.ReadLine(), out double number))
                    return number;

                CalculatorService.EraseInvalidValue(cursorPosition, Console.CursorTop - 1);
            }
        } 
    }
}