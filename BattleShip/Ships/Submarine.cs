using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShip.Ships
{
    public class Submarine: Ship
    {
        public Submarine()
        {
            this.Name = "Submarine";
            this.Size = 2;
            this.Type = OccupationType.Submarine;
        }
    }
}
