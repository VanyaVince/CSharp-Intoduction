using System;
using System.Collections.Generic;

namespace CALCULATOR_OOP
{
    class Program
    {
        private static readonly BinaryInputValidation Validation = new BinaryInputValidation();
        //private static NumberInitialization input =  new NumberInitialization();

        private static readonly MatrixDimensionValidation MatrixValidation = new MatrixDimensionValidation();

        //static Dictionary<String, Operation> _operationHistory= new Dictionary<String, Operation>();

        private static readonly List<String> OperationHistory = new List<string>();
        

        private static readonly Calculator Calculator = new Calculator();

        private static bool _lastOperationMode = false;

        private static object _lastBinaryOperation = null;
        private static object _lastMatrixOperation = null;

        //private static object _lastMatrixOperation = null;
        static void Main(string[] args)
        {
            while (true)
            {
                ShowMenu();

                var typeOperation = Int32.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

                
                //var firstArgument = (_lastOperationMode) ? ((Operation)_lastBinaryOperation).Result : Validation.Validate(1);

                switch (typeOperation)
                    {
                        case 1:
                            _lastBinaryOperation = Calculator.Execute(new Addition((_lastOperationMode) ? ((Operation)_lastBinaryOperation).Result : Validation.Validate(1), Validation.Validate(1)));
                            OperationHistory.Add("addition");
                            _lastOperationMode = true;
                            break;
                        case 2:
                            _lastBinaryOperation = Calculator.Execute(new Subtraction((_lastOperationMode) ? ((Operation)_lastBinaryOperation).Result : Validation.Validate(1), Validation.Validate(1)));
                            OperationHistory.Add("subtraction");
                            break;
                        case 3:
                            _lastBinaryOperation = Calculator.Execute(new Multiplication((_lastOperationMode) ? ((Operation)_lastBinaryOperation).Result : Validation.Validate(1), Validation.Validate(1)));
                            OperationHistory.Add("multiplication");
                            break;
                        case 4:
                            _lastBinaryOperation = Calculator.Execute(new Division((_lastOperationMode) ? ((Operation)_lastBinaryOperation).Result : Validation.Validate(1), Validation.Validate(1)));
                            OperationHistory.Add("division");
                            break;
                        case 5:
                            Matrix matrixA = null;
                            Matrix matrixB = null;
                            int rowA = 0;
                            int columnA = 0;

                            if (_lastOperationMode && _lastMatrixOperation != null)
                            {
                                rowA = ((Matrix)_lastMatrixOperation).Row;
                                columnA = ((Matrix)_lastMatrixOperation).Column;
                            }
                            else
                            {
                                rowA = MatrixValidation.Validate(1);
                                columnA = MatrixValidation.Validate(1);
                            }

                            var rowB = MatrixValidation.Validate(1);
                            var columnB = MatrixValidation.Validate(1);
                            

                            if (columnA != rowB)
                            {
                                Console.WriteLine("Inconsistent matrix dimensions. Multiplication is forbidden");
                                break;
                            }

                            if (!_lastOperationMode && _lastMatrixOperation == null)
                            {
                                matrixA = new Matrix(rowA, columnA);
                                matrixA.FillOutMatrix();
                            }
                            else
                            {
                                matrixA = (Matrix)_lastMatrixOperation;
                            }

                            matrixB = new Matrix(rowB, columnB);
                            matrixB.FillOutMatrix();

                            _lastMatrixOperation = Calculator.Execute(new MatrixMultiplication(matrixA, matrixB));
                            OperationHistory.Add("Matrix Multiplication");
                            _lastOperationMode = true;
                        break;
                        case 6:
                            foreach (var itemsHistory in OperationHistory)
                                Console.WriteLine(itemsHistory); 
                            break;
                }
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

            Console.WriteLine("Choose operation");

        }
    }
}