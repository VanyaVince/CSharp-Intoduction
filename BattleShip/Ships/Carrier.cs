using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShip.Ships
{
    public class Carrier: Ship
    {
        public Carrier()
        {
            this.Name = "Carrier";
            this.Size = 4;
            this.Type = OccupationType.Carrier;
        }
    }
}
