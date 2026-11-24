namespace TrainingMultiThreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // cores = threads

            Thread workerThread = new Thread(new ThreadStart(CalculatePathfinding));
            
            workerThread.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main thread work..." + i);
                Thread.Sleep(500);
            }
                        
            workerThread.Join();

            Console.WriteLine("Main thread done...");
        }


        private static void CalculatePathfinding()
        {
            Console.WriteLine("Calculating Pathfinding...");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Calculating Pathfinding..." + i);
                Thread.Sleep(600);
            }
            
            Console.WriteLine("Pathfinding done!");
        }

    }
}
