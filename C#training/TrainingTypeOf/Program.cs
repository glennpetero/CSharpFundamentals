namespace TrainingTypeOf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // trying to get the System.Type object of an instance
            System.Type systemTypeOfPlayer = typeof(Player);
            Console.WriteLine(systemTypeOfPlayer);

            Player player = new Player();
        }

        public class Player
        {
            static Player()
            {
                Console.WriteLine("static Player");
            }
        }
    }
}
