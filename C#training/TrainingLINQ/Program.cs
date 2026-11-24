using System.Linq;

namespace TrainingLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<Player> playerList = new List<Player>
            {
                new Player { playerName = "Code Monkey", team = "Red" },
                new Player { playerName = "Iron Man", team = "Blue" },
                new Player { playerName = "Black Widow", team = "Red" },
                new Player { playerName = "Captain America", team = "Blue" },
            };

            // LINQ works on anything IEnumberable or IQueryable

            List<Player> redPlayerList = playerList
                .Where(player => player.team == "Red")
                .ToList();
            foreach (Player player in redPlayerList) { Console.WriteLine(player); }


            // another syntax for this...
            // NOTE: does not execute UNTIL the foreach/access happens later
            IEnumerable<Player> bluePlayersList =
                from player in playerList
                where player.team == "Blue"
                select player;
            foreach (Player player in bluePlayersList) { Console.WriteLine(player); }


        }


        public class Player
        {
            public string playerName;
            public string team;

            public override string ToString()
            {
                return playerName + " " + team;
            }
        }
    }
}
