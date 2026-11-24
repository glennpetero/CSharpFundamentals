using System.Runtime.CompilerServices;

namespace TrainingConstantsAndReadOnly
{
    internal class Program
    {
        private const int LAYOFF_AGE = 58;  // const is static by nature to the class
                                            // const often must be a primitive type

        private readonly Player player1 = new Player();  // readonly allows any type, cannot be changed after set
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            
        }

        public class Player
        { 
        
        }
    }
}
