using System;

namespace Generic
{
    public class Product : IComparable
    {
        public float Price { get; set; }
        public String Name { get; set; }

        public Product()
        {
        }
        public Product(string name, float price)
        {
            Price = price;
            Name = name;
        }
        public int CompareTo(Object obj)
        {
            Product product = obj as Product;
            if (product != null)
                return this.Price.CompareTo(product.Price);
            throw new ArgumentException("Object is not a Product");
        }

    }
}