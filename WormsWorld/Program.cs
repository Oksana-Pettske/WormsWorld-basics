using System.IO;
using WormsWorld.Entity;

namespace WormsWorld
{
    class Program
    {
        static void Main()
        {
            StreamWriter streamWriter = new StreamWriter("AboutWorms.txt");
            World world = new World(streamWriter);
            world.Start("John");
            streamWriter.Close();
        }
    }
}