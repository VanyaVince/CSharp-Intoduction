using System;

namespace CALCULATOR_OOP
{
    public class Division: Operation, IOperation
    {
        public Division(object firstArgument, object secondArgument)
        {
            this.FirstArgument = firstArgument;
            this.SecondArgument = secondArgument;
        }
        public Operation Calculate()
        {
            var zero = 0;

            if (((double)SecondArgument).Equals(zero))
            {
                Console.WriteLine("Cannot divide by zero");
                return null;
            }
            
            this.Result = (double)this.FirstArgument / (double)this.SecondArgument;
            Console.WriteLine($"{(double)this.FirstArgument} / {(double)this.SecondArgument} = {Result}");
            return this;
        }
    }
}