using System.Collections;

namespace TrainingIEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Player player = new Player();
            PlayerStats playerStats = new PlayerStats();
            foreach (Stat stat in playerStats)
            {
                Console.WriteLine(stat);
            }
        }

        public class PlayerStats : IEnumerable<Stat>
        { 
            public Stat dex = new Stat { name = "Dexterity", value = 12 };
            public Stat str = new Stat { name = "Strength", value = 28 };
            public Stat wis = new Stat { name = "Wisdom", value = 35 };

            public IEnumerator<Stat> GetEnumerator()
            {
                return new PlayerStatEnumerator(this);

                // can use yield if it is a fixed set, like this demo is, and not create PlayerStatEnumerator class
                //yield return dex;  
                //yield return str;
                //yield return wis;
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            public class PlayerStatEnumerator : IEnumerator<Stat>
            {
                private PlayerStats playerStats;
                private int index;

                public PlayerStatEnumerator(PlayerStats playerStats)
                { 
                    this.playerStats = playerStats;
                    index = -1;
                }
                
                public Stat Current
                {
                    get 
                    {
                        switch (index)
                        {
                            case 0: return playerStats.dex;
                            case 1: return playerStats.str;
                            case 2: return playerStats.wis;
                            default: return playerStats.dex;
                        }
                    }
                }

                object IEnumerator.Current => Current;

                public void Dispose()
                {
                    
                }

                public bool MoveNext()
                {
                    index++;
                    if (index > 2)
                    {
                        index = -1;
                    }
                    return index != -1;
                }

                public void Reset()
                {
                    index = -1;
                }
            }
        }

        public class Stat
        {
            public string name;
            public int value;

            public override string ToString()
            {
                return $"{name}: {value}";
            }
        }
        
        private class Player
        { 
        
        }
    }
}
