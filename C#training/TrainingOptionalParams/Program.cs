namespace TrainingOptionalParams
{
    internal class Program
    {
        private enum Location
        { 
            Home,
            Work,
            Church,
            Pub,
        }

        const string CITY = "ATL";
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            DoSomething("Glenn", city: "NYC");  // pass in params in any order with (paramName: value)
        }

        private static void DoSomething(
            string name, 
            Location address = default, 
            string city = CITY) 
        {
            Console.WriteLine($"Name: {name} and Address: {address} and city: {city}");
        }
    }
}
