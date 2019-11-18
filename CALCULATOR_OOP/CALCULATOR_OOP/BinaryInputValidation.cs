using System;

namespace CALCULATOR_OOP
{
    public class BinaryInputValidation
    {

        private bool flag = true;
        public object Validate(int lineDeletion, int cursorPosition = 0)
        {
            while (flag)
            {
                if (Double.TryParse(Console.ReadLine(), out double number))
                    return number;

                CalculatorService.EraseInvalidValue(cursorPosition, Console.CursorTop - lineDeletion);
            }
            return null;
        } 
    }
}