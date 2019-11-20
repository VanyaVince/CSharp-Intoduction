using System;
using CALCULATOR_OOP.Service;

namespace CALCULATOR_OOP.Validation
{
    public class BinaryInputValidation
    {
        public double Validate()
        {
            Console.WriteLine("Enter Number");
            while (true)
            {
                if (Double.TryParse(Console.ReadLine(), out double number))
                    return number;

                CalculatorService.EraseInvalidValue(0, Console.CursorTop - 1);
            }
        } 
    }
}