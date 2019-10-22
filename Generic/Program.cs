using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            var productBanana = new Product("Banana", 30.6f, DateTime.Now.AddDays(7));
            var productStrawberry = new Product("Strawberry", 30.6f, DateTime.Now.AddDays(15));
            var comparison = new Utilities<Product>();
            var theHighestProduct = comparison.Compare(productBanana, productStrawberry);
            Console.WriteLine("The most expensive product is: {0}. The expiration day is {1}", theHighestProduct.Name, theHighestProduct.Expiration);

        }
    }
}
