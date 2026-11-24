namespace TrainingExpressionBodiedMembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


        }


        // expressions are only good for one instruction

        public class Player
        {
            private string playerName;

            // property done with expressions...
            public string PlayerName
            { 
                get => playerName; 
                set => playerName = value;
            }

            // constructor done with expressions...
            public Player(string playerName) => this.playerName = playerName;


            // common function...
            public string GetPlayerName()
            { 
                return playerName;
            }
              
            
            // can be rewritten as compact lambda-like expression
            public string OtherGetPlayerName() => playerName;   // only good for single instructions

            public void SetPlayerName(string playerName) => this.playerName = playerName;
        }
    }
}
