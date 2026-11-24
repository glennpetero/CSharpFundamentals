namespace TrainingLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ctr = 0;
            string[] names = new string[]
            {
                "A", "B", "C", "D"
            };

            List<string> places = new List<string> 
            { 
                "here", "there", "everywhere"
            };

            while (ctr < 3)
            {
                Console.WriteLine($"Loop {ctr}");
                ctr++;
            }

            ctr = 0;
            do
            {                
                Console.WriteLine($"Do Loop {ctr}");
                ctr++;
            } while (ctr < 3);

            for (int i = 0; i < 3; i++) 
            {
                Console.WriteLine($"For Loop {i}");
            }
            
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"For Loop Array {names[i]}");
            }

            foreach (string name in names)
            {
                Console.WriteLine($"ForEach Loop Array {name}");
            }

            foreach (string place in places)
            {
                Console.WriteLine($"ForEach Loop List {place}");
            }
        }
    }
}
