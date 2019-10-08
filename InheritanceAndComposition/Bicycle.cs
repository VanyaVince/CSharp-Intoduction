using System;

namespace InheritanceAndComposition
{
    public class Bicycle
    {
        private readonly Vehicle _vehicle;

        public Bicycle(Vehicle vehicle)
        {
            _vehicle = vehicle;
        }
        public String Type { get; set; }

        public void Repair()
        {
            _vehicle.FixTires();
        }
    }
}