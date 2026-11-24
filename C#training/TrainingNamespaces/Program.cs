
using GlennsIO = System.IO;  // alias for super long namespace path

namespace TrainingNamespaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            GlennsPlayer.Player player1 = new GlennsPlayer.Player();

            string test = GlennsIO.Directory.GetCurrentDirectory();
            Console.WriteLine(test);
        }
    }

    public class Player
    { 
    
    }
}


namespace GlennsPlayer
{
    public class Player
    {

    }

}
