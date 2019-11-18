using System;

namespace BattleShip
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            
            //if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                game.Play();
        }
    }
}
