namespace CALCULATOR_OOP
{
    public class Calculator
    {
        public Operation Execute(IOperation operation)
        {
            return operation.Calculate();
        }
    }
}