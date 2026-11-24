namespace TrainingRecords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // simple way to group data together into an immutable type

            Person person = new("Glenn", "Petero");
            Console.WriteLine(person);            

            PersonClass personClass = new PersonClass()
            { 
                FirstName = "Glenn",
                LastName = "Petero",
            };
            Console.WriteLine(personClass);
        }

        // this record object
        public record Person(string FirstName, string LastName);

        // is the same as this class object
        public class PersonClass
        { 
            public string FirstName { get; init; }  // immutable, no set, so cannot change
            public string LastName { get; init; }
        }
    }
}
