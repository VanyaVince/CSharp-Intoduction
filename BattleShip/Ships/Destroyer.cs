using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShip.Ships
{
    public class Destroyer: Ship
    {
        public Destroyer()
        {
            this.Name = "Destroyer";
            this.Size = 3;
            this.Type = OccupationType.Destroyer;
        }
    }
}
