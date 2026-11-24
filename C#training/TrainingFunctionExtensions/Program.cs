using System.Runtime.CompilerServices;

namespace TrainingFunctionExtensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Player player = new Player("Glenn");
            Console.WriteLine(player.SayYourName());
            Console.WriteLine(PersonExtensions.SayYourName(player));
        }
    }


    public static class PersonExtensions
    {
        public static string SayYourName(this Player player)
        { 
            return $"No {player.SayYourName()} the new name is Jerry";
        }
    }



    public class Player
    {

        string name = "";
        public Player(string name)
        { 
            this.name = name;
        }

        public override string ToString()
        {
            return this.name;
        }

        public string SayYourName()
        { 
            return "My name is " + this.name;
        }
    }

}
