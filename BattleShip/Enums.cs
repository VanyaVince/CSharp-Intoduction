namespace BattleShip
{
    public enum OccupationType
    {
        IsFree = '*',
        IsNotAvailable,
        Carrier = 'C',
        Destroyer = 'D',
        Submarine = 'S',
        PatrolBoat = 'P',
        Hit = 'X',
        Miss = 'M'
    }
}