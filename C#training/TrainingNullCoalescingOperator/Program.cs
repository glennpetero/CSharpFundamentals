using System.Net.Http.Headers;

namespace TrainingNullCoalescingOperator
{
    internal class Program
    {

        private static string playerName;
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int playerNameLength;
            string defaultPlayerName = "DEFAULT";

            // this throws error when null
            //playerNameLength = GetStringLength(playerName);

            // could add null if else logic...
            if (playerName == null)
            {
                playerNameLength = GetStringLength("");
            }
            else
            {
                playerNameLength = GetStringLength(playerName);                
            }

            // but better way, null coalescing operator:
            playerNameLength = GetStringLength(playerName ?? "");
            // if playerName is not null, uses that, else, uses ""

            playerNameLength = GetStringLength(playerName ?? defaultPlayerName ?? "");
            // uses first null value from left to right, else uses ""

            Console.WriteLine(playerNameLength);


            
            Player player = null;
            player ??= new Player();  // null coalescing assignment operator
            Console.WriteLine(player.ToString());


            Console.WriteLine(player?.GetPlayerName() ?? "Unknown player");

        }


        private static int GetStringLength(string str)
        { 
            return str.Length;
        }


        private class Player
        {
            public string GetPlayerName() => "";
            
        }
    }
}
