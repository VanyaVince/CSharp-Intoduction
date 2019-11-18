using System;

namespace CALCULATOR_OOP
{
    public class MatrixDimensionValidation
    {
        public int Validate(int lineDeletion)
        {
            Console.WriteLine("Enter Matrix dimension");
            while (true)
            {
                if (Int32.TryParse(Console.ReadLine(), out int number) && number > 0)
                    return number;

                CalculatorService.EraseInvalidValue(Console.CursorLeft, Console.CursorTop - lineDeletion);
            }
        }
    }
}