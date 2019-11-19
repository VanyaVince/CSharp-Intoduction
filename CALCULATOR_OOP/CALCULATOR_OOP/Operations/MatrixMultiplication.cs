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

        public Operation Calculate()
        {
            //new multiplicative matrix
            Result = new Matrix(((Matrix)FirstArgument).Row, ((Matrix)SecondArgument).Column);
            MultiplyMatrix();
            ((Matrix)Result).DisplayMatrix();

            return this;
        }

        private void MultiplyMatrix()
        {
            var firstMatrix = ((Matrix)FirstArgument);
            var secondMatrix = ((Matrix)SecondArgument);
            var multipliedMatrix = ((Matrix)Result).Array;

            for (int rowFirstMatrix = 0; rowFirstMatrix < firstMatrix.Row; rowFirstMatrix++)
            {
                for (int columnSecondMatrix = 0; columnSecondMatrix < secondMatrix.Column; columnSecondMatrix++)
                {
                    double result = 0;

                    for (int item = 0; item < firstMatrix.Column; item++)
                    {
                        result += firstMatrix.Array[rowFirstMatrix, item] * secondMatrix.Array[item, columnSecondMatrix];
                    }
                    multipliedMatrix[rowFirstMatrix, columnSecondMatrix] = result;
                }
            }
        }
    }
}