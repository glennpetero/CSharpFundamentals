namespace TrainingIDisposable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            /*
            FileStream fileStream = File.Open("myfile.txt", FileMode.Open);
            fileStream.Read(new Span<byte>());
            fileStream.Dispose();   // need to displose to reclaim memory 
            */

            // instead, try 'using'
            using (FileStream fileStream = File.Open("myfile.txt", FileMode.Open))
            {
                fileStream.Read(new Span<byte>());
            }
            // automatically calls IDisposable after closing brace


        }

        // or inherit and use in your class type
        public class SaveSystem : IDisposable
        {
            public void Dispose()
            { 
            
            }
        }

    }
}
