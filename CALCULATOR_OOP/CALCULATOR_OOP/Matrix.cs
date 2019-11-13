using System.Data;

namespace CALCULATOR_OOP
{
    public class Matrix
    {
        public int Row { get; }

        public int Column { get; }

        public double[,] Array { get; }

        public Matrix(int row, int column)
        {
            this.Row = row;
            this.Column = column;
            this.Array = new double[row, column];
        }
    }
}