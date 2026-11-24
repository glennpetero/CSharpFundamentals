namespace TrainingProperties
{
    internal class Program
    {
        //private static string PlayerName { get; set; }
        private static string playerName;

        private static string PlayerName
        {
            get 
            {
                if (playerName == null)
                {
                    playerName = "Unknown";
                }
                return playerName; 
            }
            set 
            {
                if (value.Contains("Jesus"))
                {
                    throw new Exception("You are not Jesus dude!");
                }
                playerName = value; 
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            PlayerName = "Glenn";
            Console.WriteLine($"Player name is {PlayerName}");
        }
    }
}
