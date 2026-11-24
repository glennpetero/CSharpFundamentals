namespace TrainingSingletonPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Singleton Pattern: single instance of something
            Console.WriteLine(GameManager.Instance);
        }

        public class GameManager
        { 
            // this is private so that ONLY this class can create/get it
            private static GameManager instance; 

            public static GameManager Instance
            {
                get 
                {
                    if (instance == null)  // lazy instantiation (only create when needed, once)
                    { 
                        instance = new GameManager();
                    }
                    return instance; 
                } 
            }

            // constructor is private too, so can't be created outside as new object
            private GameManager()
            { 
            
            }

        }
    }
}
