using System.Runtime.CompilerServices;

namespace TrainingDictionary
{
    internal class Program
    {
        private enum ResourceType
        { 
            Stone,
            Wood,
            Gold,
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");            

            Dictionary<ResourceType, int> resourceTypeAmountDictionary = new Dictionary<ResourceType, int>()
            {
                { ResourceType.Gold, 125 },
                { ResourceType.Stone, 50 },
                { ResourceType.Wood, 25 },
            };
            //resourceTypeAmountDictionary.Add(ResourceType.Stone, 50);
            Console.WriteLine(resourceTypeAmountDictionary.Count);

            foreach (KeyValuePair<ResourceType, int> keyValuePair in resourceTypeAmountDictionary) 
            {
                Console.WriteLine($"{keyValuePair.Key}: {keyValuePair.Value}");                
            }

            foreach (ResourceType resourceTypeKeys in resourceTypeAmountDictionary.Keys) 
            {
                Console.WriteLine(resourceTypeKeys + ": " + resourceTypeAmountDictionary[resourceTypeKeys]);
            }
                       
        }
    }
}
