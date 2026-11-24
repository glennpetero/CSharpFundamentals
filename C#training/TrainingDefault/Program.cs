namespace TrainingDefault
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // default returns the zero equivalent value of an object type
            Console.WriteLine(default(int));
            Console.WriteLine(default(bool));
            Console.WriteLine(default(Program));

            int i = default;
            Console.WriteLine(i);  // 0

        }
    }
}
