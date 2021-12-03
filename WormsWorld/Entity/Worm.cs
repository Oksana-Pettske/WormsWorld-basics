namespace WormsWorld.Entity
{
    public class Worm
    {
        public readonly string Name;
        public Cell Position;

        private readonly CircleMover _mover;

        public Worm(string name, CircleMover mover)
        {
            Name = name;
            Position.X = 0;
            Position.Y = 0;
            _mover = mover;
        }
        
        public void Move(int day)
        {
            _mover.Move(this, day);
        }
    }
}