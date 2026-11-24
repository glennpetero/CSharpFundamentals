using System.Diagnostics;

namespace TrainingAssertsTests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Player player = new Player(null);
        }


        public class Player
        {
            private string playerName;

            public Player(string playerName)
            {                
                this.playerName = playerName;
            }
        }
    }



    // check out MSTest in .NET for unit testing framework
    // NUnit and xUnit
}
