using System;
using CALCULATOR_OOP.Service;

namespace CALCULATOR_OOP.Validation
{
    public class MatrixDimensionValidation
    {
        public int Validate()
        {
            Console.WriteLine("Enter Matrix dimension");
            while (true)
            {
                if (Int32.TryParse(Console.ReadLine(), out int number) && number > 0)
                    return number;

                CalculatorService.EraseInvalidValue(Console.CursorLeft, Console.CursorTop - 1);
            }
        }
    }
}