namespace TrainingTuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Tuple
            var myTuple = ("Glenn", 58);
            Console.WriteLine(myTuple);
            Console.WriteLine(myTuple.Item1);
            Console.WriteLine(myTuple.Item2);


            string playerName = "Glenn";
            int playerId = 58;
            var anotherTuple = (playerName, playerId);
            Console.WriteLine(anotherTuple.playerName);
            anotherTuple.playerName = "Seth";
            Console.WriteLine(anotherTuple.playerName);

            (string playerName, int id) andAnotherTuple = ("Heather", 55);

            var tuple = GetMyTuple();
            Console.WriteLine(tuple);
            (string name, int id) = tuple;
            Console.WriteLine(name);

            //  these are System.ValueTuple<T> types  (value type and mutable)

            // System.Tuple is a ref type and read-only
        }

        public static (string name, int id) GetMyTuple()
        {
            return ("Glenn", 58);
        }
    }
}
