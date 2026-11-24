using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;

namespace TrainingDynamic
{
    internal class Program
    {
        private static string jsonUserData =
            """
            {
                "id": 42,
                "name": "Jane Doe",
                "is_active": true,
                "roles": ["Admin", "User"],
                "profile": {
                    "email": "jane.doe@example.com",
                    "age": 28
                }
            }
            """;


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            var v = 58; // evaluated at complile-time and infers type

            dynamic d;  // evaluated at run-time

            dynamic objD = new object();
            //objD.TestMeStupid();  // can write anything pretty much, and hope it works at run-time

            // helpful with JSON data that may change over time
            dynamic jsonDynamic = JObject.Parse(jsonUserData);
            Console.WriteLine(jsonDynamic.id);
        }

        private static dynamic Test()   // can be return type also
        {
            return new { name = "Glenn", health = 100 };
        }
    }
}
