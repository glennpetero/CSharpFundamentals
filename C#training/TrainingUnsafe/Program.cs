namespace TrainingUnsafe
{
    internal unsafe class Program
    {
        static unsafe void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            unsafe 
            { 
                int* intArrayPointer = stackalloc int[10];
            }
        }
    }
}
