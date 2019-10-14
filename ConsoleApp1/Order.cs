using System;

namespace ConsoleApp1
{
    public class Order
    {
        public Shipment Shipment { get; set; }
        public int Cost { get; set; }
        public DateTime DatePlaced { get; set; }

        public Order()
        {
        }
    }
}