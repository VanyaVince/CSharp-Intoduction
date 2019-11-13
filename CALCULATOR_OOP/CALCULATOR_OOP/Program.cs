using System;
using System.Collections.Generic;

namespace CALCULATOR_OOP
{
    class Program
    {
        static Dictionary<String, Operation> _operationHistory= new Dictionary<String, Operation>();
        static void Main(string[] args)
        {
            ShowMenu();

            while (true)
            {
                Console.WriteLine("Choose operation");

                var operation = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                
                switch (operation)
                    {
                        case 1:
                            IOperation addition = new Addition(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                            _operationHistory.Add("addition", (Operation)addition.Calculate());
                            break;
                        case 2:
                            IOperation subtraction = new Subtraction(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                            _operationHistory.Add("subtraction", (Operation)subtraction.Calculate());
                            break;
                        case 3:
                            IOperation multiplication = new Multiplication(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                            _operationHistory.Add("multiplication", (Operation)multiplication.Calculate());
                            break;
                        case 4:
                            IOperation division = new Division(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                            _operationHistory.Add("division", (Operation)division.Calculate());
                            break;
                        case 5:
                            Matrix matrix1 = new Matrix(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()));
                            Matrix matrix2 = new Matrix(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()));
                            IOperation matrixMultiplication = new MatrixMultiplication(matrix1, matrix2);
                            matrixMultiplication.Calculate();
                            break;
                }

                Console.WriteLine("[1] - continue, [2] - exit");
                var decision = Console.ReadLine();
                if (Int32.TryParse(decision, out int number) && number == 2)
                    break;
            }
        }

        private static void ShowMenu()
        {
            var addition = 1;
            var subtraction = 2;
            var multiplication = 3;
            var division = 4;
            var matrixMultiplication = 5;
            var calculationHistory = 6;
            var exit = "c";

            Console.WriteLine("Choose operation 'digit', according to the specification below");
            Console.WriteLine(
                $"[Sum - {addition}] [Subtraction - {subtraction}] [Multiplication - {multiplication}] [Division - {division}] " +
                $"[Matrix Multiplication - {matrixMultiplication}] [History - {calculationHistory}] [Exit - {exit}]");
            Console.WriteLine();
        }
    }
}