using System.IO;

namespace WormsWorld.Entity
{
    public class World
    {
        private readonly StreamWriter _streamWriter;
        
        public World(StreamWriter streamWriter)
        {
            _streamWriter = streamWriter;
        }
        
        public void Start(string name)
        {
            Worm worm = new Worm(name, new CircleMover());
            for (int day = 0; day < 100; day++)
            {
                worm.Move(day);
                WriteHistory(worm);
            }
        }
        
        private void WriteHistory(Worm worm)
        {
            _streamWriter.Write("Worms: [");
            _streamWriter.Write(worm.Name + " (" + worm.Position.X + ", " + worm.Position.Y + ")]\n");
        }
    }
}