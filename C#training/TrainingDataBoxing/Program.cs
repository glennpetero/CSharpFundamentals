namespace TrainingDataBoxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int i = 58;   // value type, stored directly on the Stack
            object o = i; // this is data boxing, converting a value type into a ref type (pointing to Heap)
            int j = (int)o; // unbox from ref type to a value type

        }
    }
}
