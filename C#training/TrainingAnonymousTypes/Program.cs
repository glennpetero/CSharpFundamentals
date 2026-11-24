namespace TrainingAnonymousTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // typical way to create a type
            Player player = new Player
            {
                playerName = "Glenn",  // this is a Property, not a Field
                id = 1
            };
            Console.WriteLine(player);

            // create an anonymous type   (these are always read-only immutable types)
            var player2 = new { Name = "Glenn", Id = 1 };  // use var as there is no type
            Console.WriteLine(player2);

            Console.WriteLine(player2.GetType());

            // NOTE: anonymous types can also contain other anonymous types

            // can also be an array   
            var playerDataArray = new[]
            {
                new { Name = "Heather", Id = 72 },
                new { Name = "Seth", Id = 23 }
            };

            // great for LINQ queries...
            
        }

        public class Player
        {
            public string playerName;
            public int id;
        }
    }
}
