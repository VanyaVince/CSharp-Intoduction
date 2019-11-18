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

            Result = new Matrix(((Matrix)FirstArgument).Row, ((Matrix)SecondArgument).Column);

            var multipliedMatrix = MultiplyMatrix();

            DisplayMatrix((Matrix)this.Result);

            return multipliedMatrix;
        }

        private object MultiplyMatrix()
        {
            var firstMatrix = ((Matrix)FirstArgument).Array;
            var secondMatrix = ((Matrix)SecondArgument).Array;
            var multipliedMatrix = ((Matrix)Result).Array;

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
            return this.Result;
        }

        private void DisplayMatrix(Matrix matrix)
        {
            //Console.Clear();
            Console.WriteLine($"{CalculatorService.DisplayDashes()}");

            for (int i = 0; i < matrix.Row; i++)
            {
                for (int j = 0; j < matrix.Column; j++)
                {
                    Console.WriteLine(matrix.Array[i, j]);

                    Console.SetCursorPosition((j + 1) * 9, Console.CursorTop - 1);
                }
                Console.WriteLine();
            }
            Console.WriteLine(CalculatorService.DisplayDashes());
        }

        
    }
}