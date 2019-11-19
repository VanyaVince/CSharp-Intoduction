using System;

namespace CALCULATOR_OOP
{
    public class Addition : Operation, IOperation
    {
        public Addition(double firstArgument, double secondArgument)
        {
            this.FirstArgument = firstArgument;
            this.SecondArgument = secondArgument;
        }

        public Operation Calculate()
        {
            this.Result = (double)this.FirstArgument + (double)this.SecondArgument;
            Console.WriteLine($"{(double)this.FirstArgument} + {(double)this.SecondArgument} = {Result}");
            return this;
        }
    }
}