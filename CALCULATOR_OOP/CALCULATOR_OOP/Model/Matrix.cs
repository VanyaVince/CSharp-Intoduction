using System;
using System.Data;

namespace CALCULATOR_OOP
{
    public class Matrix
    {
        public int Row { get; }

        public int Column { get; }

        public bool IsEmpty { get; set; }
        public double[,] Array { get; set; }

        public Matrix(int row, int column)
        {
            this.Row = row;
            this.Column = column;
            this.Array = new double[row, column];
        }


        public void FillOutMatrix()
        {
            Console.WriteLine(
                $"{CalculatorService.DisplayDashes()}\nFilling the matrix out one by one. The measures of matrix are [{Row}, {Column}]");

            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    var cursorPointerHorizontally = (j + 1) * 9;

                    if (Double.TryParse(Console.ReadLine(), out double number))
                    {
                        Array[i, j] = number;
                        Console.SetCursorPosition(cursorPointerHorizontally, Console.CursorTop - 1);
                    }
                    else
                    {
                        j--;
                        cursorPointerHorizontally = (j + 1) * 9;
                        CalculatorService.EraseInvalidValue(cursorPointerHorizontally, Console.CursorTop - 1);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine(CalculatorService.DisplayDashes());
        }

        public void DisplayMatrix()
        {
            //Console.Clear();
            Console.WriteLine($"{CalculatorService.DisplayDashes()}");

            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    Console.WriteLine(Array[i, j]);

                    Console.SetCursorPosition((j + 1) * 9, Console.CursorTop - 1);
                }
                Console.WriteLine();
            }
            Console.WriteLine(CalculatorService.DisplayDashes());
        }


    }
}