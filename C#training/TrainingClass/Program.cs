using System.Diagnostics;

namespace TrainingClass
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Player player1 = new Player("Glenn");
            player1.SayHello();
            Player player2 = new Player("Heather");
            player2.SayHello();
        }

        private class Player
        {
            private string name = "-";

            public Player(string name)
            {
                this.name = name;
                Console.WriteLine($"Creating player {name}");
            }

            public void SayHello()
            {
                Console.WriteLine($"Hello {name}!");                    
            }          

        }
    }
}
