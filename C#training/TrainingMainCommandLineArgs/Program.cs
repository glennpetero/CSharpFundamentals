namespace TrainingMainCommandLineArgs
{
    internal class Program
    {
        // must be static and named 'Main' and ONLY entry point into program
        static void Main(string[] args)  
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine(args.Length);
            foreach (var arg in args)
            {
                Console.WriteLine($"{arg}");
            }

            // all args are actually string, so convert as needed
            //int.TryParse(args[0], out var value );



            // ALSO, can get command line args using:
            string[] alsoArgs = Environment.GetCommandLineArgs();
        }
    }
}
