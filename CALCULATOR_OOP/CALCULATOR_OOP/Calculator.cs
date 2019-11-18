namespace CALCULATOR_OOP
{
    public class Calculator
    {
        public object Execute(IOperation operation)
        {
            return operation.Calculate();
        }
    }
}