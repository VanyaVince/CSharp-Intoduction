using System;
using System.Collections.Generic;
using System.Linq;
using BattleShip.Ships;

namespace BattleShip
{
    class ShipGeneration
    {
        private readonly List<Panel> _panelDesk;

        readonly Random _random = new Random();
        
        public ShipGeneration(GameBoard gameBoard)
        {
            this._panelDesk = gameBoard.Panels;
        }

        public void Generate(Ship ship)
        {

            var isOpen = true;

            while (isOpen)
            {
                //list with all free panels
                var allEmptyPanels = GetEmptyPanels(_panelDesk);

                ////choose one panel for start placing new ship
                var targetPanel = allEmptyPanels[_random.Next(allEmptyPanels.Count)];

                // direction of rotation
                var direction = _random.Next(1, 10) % 2 == 0;

                var affectedPanels = new List<Panel>();

                if (direction)
                {
                    //if rows are out of the board boundary
                    if (targetPanel.Coordinate.Row + ship.Size > 10)
                        continue;

                    for (int i = 0; i < ship.Size; i++)
                        affectedPanels.Add(_panelDesk.Find(x=> x.Coordinate.Row == targetPanel.Coordinate.Row + i && x.Coordinate.Column == targetPanel.Coordinate.Column));
                }
                else
                {
                    //if columns are out of the board boundary
                    if (targetPanel.Coordinate.Column + ship.Size > 10)
                        continue;

                    for (int i = 0; i < ship.Size; i++)
                        affectedPanels.Add(_panelDesk.Find(x => x.Coordinate.Row == targetPanel.Coordinate.Row && x.Coordinate.Column == targetPanel.Coordinate.Column + i));
                }

                //??????????????????????????
                //var isOccupied = affectedPanels.All(x => x.Type != OccupationType.IsFree);

                var isOccupied = false;

                //check all panels for being free
                foreach (var affectedPanel in affectedPanels)
                {
                    if (affectedPanel.Type != OccupationType.IsFree)
                        isOccupied = true;
                }

                if (isOccupied)
                    continue;
                

                foreach (var panel in affectedPanels)
                {
                    panel.Type = ship.Type;
                    panel.SetShip(ship);

                    ChangeStatus(panel.Coordinate.Row + 1, panel.Coordinate.Column);
                    ChangeStatus(panel.Coordinate.Row - 1, panel.Coordinate.Column);
                    ChangeStatus(panel.Coordinate.Row, panel.Coordinate.Column + 1);
                    ChangeStatus(panel.Coordinate.Row, panel.Coordinate.Column - 1);

                    ChangeStatus(panel.Coordinate.Row + 1, panel.Coordinate.Column + 1);
                    ChangeStatus(panel.Coordinate.Row + 1, panel.Coordinate.Column - 1);
                    ChangeStatus(panel.Coordinate.Row - 1, panel.Coordinate.Column + 1);
                    ChangeStatus(panel.Coordinate.Row - 1, panel.Coordinate.Column - 1);
                }
                isOpen = false;
            }
        }

        private void ChangeStatus(int x, int y)
        {
            foreach (var panel in this._panelDesk)
            {
                if (x > 0 && x <= Math.Sqrt(_panelDesk.Count) && y > 0 &&
                    y <= Math.Sqrt(_panelDesk.Count))
                {
                    if (panel.Coordinate.Row == x && panel.Coordinate.Column == y && panel.Type == OccupationType.IsFree)
                        panel.Type = OccupationType.IsNotAvailable;
                }
            }
        }
        private List<Panel> GetEmptyPanels(List<Panel> panels)
        {
            List<Panel> emptyPanels = new List<Panel>();

            foreach (var panel in panels)
            {
                if (panel.Type == OccupationType.IsFree)
                    emptyPanels.Add(panel);
            }

            return emptyPanels;
        }
    }

    class Coordinate
    {
        public int Row { get; set; }
        public int Column { get; set; }

        public Coordinate(int row, int column)
        {
            this.Row = row;
            this.Column = column;
        }

    }
    class Panel
    {
        public Coordinate Coordinate { get; set; }
        public OccupationType Type { get; set; }
        public Ship Ship = null;

        public void SetShip(Ship ship)
        {
             this.Ship = ship;
        }

        public Panel(int row, int column)
        {
            this.Coordinate = new Coordinate(row, column);
            this.Type = OccupationType.IsFree;
        }

        public override string ToString()
        {
            return ((char) Type) + " ";
            //return $"{Coordinate.Row}{Coordinate.Column} ";
        }
    }
    class GameBoard
    {
        public List<Panel> Panels = new List<Panel>();

        public GameBoard()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Panels.Add(new Panel(i,j));
                }
            }
        }
    }

    public class CoordinateValidation
    {
        public int Row { get; set; }
        public int Column { get; set; }
    }
    class Game
    {
        private readonly GameBoard _gameBoard;
        private readonly ShipGeneration _shipGeneration;
        private readonly List<Ship> _ships = new List<Ship>();
        public Game()
        {
            this._gameBoard = new GameBoard();
            this._shipGeneration = new ShipGeneration(this._gameBoard);
            ShipsInitialization();
        }

        public void Play()
        {
            DrawBoard();

            while (!_ships.All(x => x.IsKilled))
            {
                Console.WriteLine("Enter coordinate relatively to  'X' ");
                var row = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter coordinate relatively to  'Y' ");
                var column = Int32.Parse(Console.ReadLine());

                var panel = _gameBoard.Panels.Find(x => x.Coordinate.Row == row && x.Coordinate.Column == column);

                if (panel.Type == OccupationType.Miss || panel.Type == OccupationType.Hit)
                {
                    Console.WriteLine($"The shot, {row}:{column}, has been already done");
                    continue;
                }

                if (panel.Type == OccupationType.IsFree)
                {
                    panel.Type = OccupationType.Miss;
                    Console.WriteLine($"The shot, {row}:{column}, is failed");
                }
                else
                {
                    panel.Type = OccupationType.Hit;
                    panel.Ship.Shots++;
                    var shotResult = (panel.Ship.IsKilled) ? "destroyed" : "hit";
                    Console.WriteLine($"The shot, {row}:{column}, is {shotResult} the {panel.Ship.Name}");
                }
            }

            Console.WriteLine("Game Over");
        }
        private void DrawBoard()
        {
            foreach (var ship in _ships)
                _shipGeneration.Generate(ship);


            foreach (var panel in this._gameBoard.Panels)
            {
                if (panel.Type == OccupationType.IsNotAvailable)
                    panel.Type = OccupationType.IsFree;
                
                Console.Write(panel.ToString());

                if (panel.Coordinate.Column == 10)
                    Console.WriteLine();
            }
        }


        private void ShipsInitialization()
        {
            _ships.Add(new PatrolBoat());
            _ships.Add(new PatrolBoat());
            _ships.Add(new PatrolBoat());
            _ships.Add(new PatrolBoat());
            _ships.Add(new Submarine());
            _ships.Add(new Submarine());
            _ships.Add(new Submarine());
            _ships.Add(new Destroyer());
            _ships.Add(new Destroyer());
            _ships.Add(new Carrier());
        }
    }
}