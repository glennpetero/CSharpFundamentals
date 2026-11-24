namespace TrainingOtherCollectionTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Stack: First In Last Out (FILO) or LIFO (last in first out) great for Undo logic      
            Stack<string> nameStack = new Stack<string>();
            nameStack.Push("A");
            nameStack.Push("B");
            nameStack.Push("C");
            Console.WriteLine(nameStack.Pop());  // C

            // Queue: First In First Out (FIFO) great for processing in chronological order
            Queue<string> nameQueue = new Queue<string>();
            nameQueue.Enqueue("A");
            nameQueue.Enqueue("B");
            nameQueue.Enqueue("C");
            Console.WriteLine(nameQueue.Dequeue());  // A

            // Hashset: all elements HAVE to be unique
            HashSet<string> nameHashSet = new HashSet<string>();
            nameHashSet.Add("A");
            nameHashSet.Add("B");
            nameHashSet.Add("C");
            Console.WriteLine(nameHashSet.Count);


            // iterating collection by type (string), NOT HashSet<string>
            foreach (string name in nameHashSet)
            {
                Console.WriteLine(name);
            }            
        }
    }
}
