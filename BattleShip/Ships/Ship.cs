namespace BattleShip.Ships
{
    public abstract class Ship
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public int Shots { get; set; }
        public OccupationType Type { get; set; }

        public bool IsKilled => this.Shots >= this.Size;
    }
}