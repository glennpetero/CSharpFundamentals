namespace TrainingFunctionParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            PrintName("Glenn", "Brian", "Garrey");
        }

        // to allow for multiple parameters in the function... 
        // must be array, and must be last param
        private static void PrintName(params string[] name)
        { 
            Console.WriteLine($"{name.Length}");
        }
    }
}
