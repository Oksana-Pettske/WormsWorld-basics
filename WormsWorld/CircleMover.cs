using WormsWorld.Entity;

namespace WormsWorld
{
    public class CircleMover 
    {
        private readonly Cell[] _cells = {
            new Cell(0, 1),
            new Cell(1, 1),
            new Cell(1, 0),
            new Cell(1, -1),
            new Cell(0, -1),
            new Cell(-1, -1),
            new Cell(-1, 0),
            new Cell(-1, 1)
        };
        
        public void Move(Worm worm, int day)
        {
            worm.Position = _cells[day % _cells.Length];
        }
    }
}