using System;

namespace CALCULATOR_OOP
{
    public class MatrixMultiplication: Operation, IOperation
    {
        public MatrixMultiplication(Matrix firstMatrix, Matrix secondMatrix)
        {
            this.FirstArgument = firstMatrix;
            this.SecondArgument = secondMatrix;
        }
        public object Calculate()
        {
            DrawMatrix(((Matrix)FirstArgument).Array);
            DrawMatrix(((Matrix)SecondArgument).Array);

            //var matrixA = new Matrix(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            //var matrixB = new Matrix(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

            var multipliedMatrix = new Matrix(((Matrix)FirstArgument).Row, ((Matrix)SecondArgument).Column);
            MultiplyMatrix(((Matrix) FirstArgument).Array, ((Matrix) SecondArgument).Array, multipliedMatrix.Array);

            DisplayMatrix(multipliedMatrix.Array);

            return multipliedMatrix;
        }

        private double[,] MultiplyMatrix(double[,]firstMatrix, double[,]secondMatrix, double[,]multipliedMatrix)
        {
            for (int rowFirstMatrix = 0; rowFirstMatrix <= firstMatrix.GetUpperBound(0); rowFirstMatrix++)
            {
                for (int columnSecondMatrix = 0; columnSecondMatrix <= secondMatrix.GetUpperBound(1); columnSecondMatrix++)
                {
                    double result = 0;

                    for (int item = 0; item <= firstMatrix.GetUpperBound(1); item++)
                    {
                        result += firstMatrix[rowFirstMatrix, item] * secondMatrix[item, columnSecondMatrix];
                    }

                    multipliedMatrix[rowFirstMatrix, columnSecondMatrix] = result;
                }
            }
            return multipliedMatrix;
        }

        private static void DisplayMatrix(double[,] array)
        {
            //Console.Clear();
            //Console.WriteLine($"{DisplayDashes()}\n{message}:");

            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= array.GetUpperBound(1); j++)
                {
                    Console.WriteLine(array[i, j]);

                    Console.SetCursorPosition((j + 1) * 9, Console.CursorTop - 1);
                }
                Console.WriteLine();
            }
            //Console.WriteLine(DisplayDashes());
        }

        private static void DrawMatrix(double[,] matrix)
        {
            //Console.WriteLine(
            //    $"{DisplayDashes()}\nFilling the matrix out one by one. The measures of matrix are [{matrix.GetUpperBound(0) + 1}, {matrix.GetUpperBound(1) + 1}]");

            for (int i = 0; i <= matrix.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= matrix.GetUpperBound(1); j++)
                {
                    var cursorPointerHorizontally = (j + 1) * 9;

                    if (Double.TryParse(Console.ReadLine(), out double number))
                    {
                        matrix[i, j] = number;
                        Console.SetCursorPosition(cursorPointerHorizontally, Console.CursorTop - 1);
                    }
                    else
                    {
                        j--;
                        cursorPointerHorizontally = (j + 1) * 9;
                        //EraseInvalidValue(cursorPointerHorizontally, Console.CursorTop - 1);
                    }
                }
                Console.WriteLine();
            }
            //Console.WriteLine(DisplayDashes());
        }
    }
}