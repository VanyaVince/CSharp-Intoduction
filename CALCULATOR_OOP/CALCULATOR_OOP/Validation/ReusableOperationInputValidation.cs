using System;

namespace CALCULATOR_OOP
{
    public class ReusableOperationInputValidation
    {
        public int Validate()
        {
            while (true)
            {
                if (Int32.TryParse(Console.ReadLine(), out int number) && number == 1 || number == 2)
                    return number;

                CalculatorService.EraseInvalidValue(Console.CursorLeft, Console.CursorTop - 1);
            }
        }
    }
}