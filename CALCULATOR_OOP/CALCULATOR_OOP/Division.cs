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
        public object Calculate()
        {
            var zero = 0;

            //if (b.Equals(zero))
            //{
            //    DisplayError("Cannot divide by zero");
            //    return null;
            //}
            //Console.WriteLine($"{DisplayDashes()}\n{a} / {b} = {a / b}\n{DisplayDashes()}");
            //SaveOperation("Division", $"{a} / {b} = {a / b}");
            //return a / b;
            this.Result = (double)this.FirstArgument / (double)this.SecondArgument;
            Console.WriteLine($"{(double)this.FirstArgument} / {(double)this.SecondArgument} = {Result}");
            return this;
        }
    }
}