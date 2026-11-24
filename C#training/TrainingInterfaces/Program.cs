namespace TrainingInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            IAttackable attackablePlayer = new Player();
            IAttackable attackableEnemy = new Enemy();
            //By declaring your variables as the interface type, you treat different concrete classes identically
            //based on what they can DO, rather than what they ARE.

            AttackObject(attackablePlayer);
            AttackObject(attackableEnemy);

            Console.WriteLine($"attackablePlayer is a Player = {(attackablePlayer is Player)}");
            Console.WriteLine($"attackablePlayer is a Player = {(attackablePlayer.GetType() == typeof(Player))}");

            Player player = attackablePlayer as Player;  // as operator needs a reference type
            // Player player = (Player)attackable;  // could also cast it, like this... 
            player.SayHello();


            if (attackablePlayer is Player)
            { 
            
            }

            switch (attackablePlayer)
            {
                case Player player1 when player1.Health > 0:
                    player1.SayHello();
                    break;
                default:
                    break;
            }

        }

        public static void AttackObject(IAttackable attackable)
        {
            attackable.Damage();
        }

        // NOTE: everything needs to be public in an interface
        // and no fields are allowed because interfaces cannot store data...
        // but you CAN have functions/properties/events
                

        public interface IAttackable
        {
            public void Damage()
            {
                Console.WriteLine("Damage");  // you CAN implement default implementation
            }
        }

        public interface IMovable
        { 
        
        }

        public interface IHasInventory
        { 
        
        }

        public class Player : IAttackable, IMovable, IHasInventory 
        {
            public int Health { get; set; }
            
            public void Damage()
            { 
                Console.WriteLine("Player Damage!");
            }

            public void SayHello()
            { 
                Console.WriteLine("Hello!");
            }
        }

        public class Enemy : IAttackable, IMovable 
        {
            //public void Damage()
            //{
            //    Console.WriteLine("Enemy Damage!");
            //}
        }
    }
}
