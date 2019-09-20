using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    public enum ShippingMethod
    {
        Monday, 
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    class Program
    {
        static void Main(string[] args)
        {
            var friday = ShippingMethod.Friday;
            Console.WriteLine(friday);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            var method = "something";
            var result = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), method);

            string str = "2";
            int i = int.Parse(str);
            Console.WriteLine(i);
            
        }
    }
}
