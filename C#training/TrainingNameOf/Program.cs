namespace TrainingNameOf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // get the name of a Type or Field or Function, without hardcoding strings

            string playerClassName = "Player";  // hardcoded and fragile

            playerClassName = nameof(Player);

            Console.WriteLine(nameof(Player));
            Console.WriteLine(nameof(Player.speed));
            Console.WriteLine(nameof(Player.IsGrounded));


            Player player = new Player();
            player.SetSpeed(0);

        }

        class Player
        {
            public int speed;

            public bool IsGrounded()
            {
                return true;
            }

            public void SetSpeed(int speed)
            {
                if (speed == 0)
                {
                    Console.WriteLine("ERROR: " + nameof(speed) + " must not be 0");
                }
                this.speed = speed;
            }
        }
    }
}
