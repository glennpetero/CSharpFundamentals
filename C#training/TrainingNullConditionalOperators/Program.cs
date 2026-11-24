using System.Threading.Tasks.Sources;

namespace TrainingNullConditionalOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // simplifies null checking logic on nullable types

            Player player = new Player();
            Console.WriteLine(player?.GetPlayerName());
            Console.WriteLine(player?.playerName);
            player?.target?.TakeDamage();


            List<string> playerNameList = new List<string> { "Glenn" };
            Console.WriteLine(playerNameList?[0]);
        }


        public class Player
        {
            public event EventHandler OnDamaged;

            public string playerName;
            public Player target;

            public void TakeDamage()
            {
                OnDamaged?.Invoke(this, EventArgs.Empty);   // ? is the null conditional operator
                                                            // if OnDamaged is not null, runs code to right of ?
            }

            public string GetPlayerName() => playerName;




        }

    }
}
