﻿using System;

namespace CALCULATOR_OOP
{
    public class Addition : Operation, IOperation
    {
        public Addition(object firstArgument, object secondArgument)
        {
            this.FirstArgument = firstArgument;
            this.SecondArgument = secondArgument;
        }

        public object Calculate()
        {
            this.Result = (double)this.FirstArgument + (double)this.SecondArgument;
            Console.WriteLine($"{(double)this.FirstArgument} + {(double)this.SecondArgument} = {Result}");
            return this;
        }
    }
}