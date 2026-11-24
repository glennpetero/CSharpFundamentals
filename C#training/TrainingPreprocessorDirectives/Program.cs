#define TESTING   // or DEBUG  is helpful, right?  :)

namespace TrainingPreprocessorDirectives
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
#if TESTING   // if 'TESTING' is defined in the file (above), then run this    
              //  has else and elif too
            Console.WriteLine("Testing");
#endif
        }
    }
}
