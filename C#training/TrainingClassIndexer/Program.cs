namespace TrainingClassIndexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            PlayerStats playerStats = new PlayerStats
            {
                strAmount = 12,
                dexAmount = 36,
                wisAmount = 58
            };

            int strength = playerStats[0];
            Console.WriteLine(strength);
            playerStats[0] = 44;
            Console.WriteLine(playerStats[0]);
        }


        public class PlayerStats
        {
            public enum Stat
            { 
                Str,
                Dex,
                Wis,
            }

            public int strAmount;
            public int dexAmount;
            public int wisAmount;


            public int this[int index]   // custom indexer for class
            {
                get 
                {
                    switch (index)
                    {
                        case 0: return strAmount;
                        case 1: return dexAmount;
                        case 2: return wisAmount;
                        default: throw new IndexOutOfRangeException();
                    }
                }

                // if not read-only, thes set property as usual
                set {
                    switch (index)
                    {
                        case 0: strAmount = value; break;
                        case 1: dexAmount = value; break;
                        case 2: wisAmount = value; break;
                        default: throw new IndexOutOfRangeException();
                    }
                }
            }        
        
        }

    }
}
