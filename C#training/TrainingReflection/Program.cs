using System.Reflection;

namespace TrainingReflection
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
                        
            
            Exercise exercise = new Exercise();


            // Check if class Exercise.Person exists:
            // -------------------------------------------------------------------------------------------
            // This only works IF it actually exists, else throws exception
            if (typeof(Exercise.Person) != null)
            {
                Console.WriteLine($"Exercise.Person exists!");
            }
            // This is more dynamic/safe (prints nothing if not found)
            // -------------------------------------------------------------------------------------------
            Type personType = typeof(Exercise).GetNestedType("Person");
            Console.WriteLine(personType);

            foreach (Type type in typeof(Exercise).GetNestedTypes())
            {
                Console.WriteLine(type);
            }


            // Call a function, two different ways:
            // -------------------------------------------------------------------------------------------
            // First, directly...
            Console.WriteLine("Calling functions:");
            exercise.MyFunction(85);

            // Then, by Reflection
            MethodInfo myFunctionMethodInfo = typeof(Exercise).GetMethod("MyFunction");
            myFunctionMethodInfo.Invoke(exercise, new object[]  { 16 });
            // -------------------------------------------------------------------------------------------




            // -------------------------------------------------------------------------------------------
            // Get private variables/methods/etc. with BindingFlags
            Console.WriteLine("BindingFlags:");
            foreach (Type type in typeof(Exercise).GetNestedTypes(BindingFlags.NonPublic | BindingFlags.Static))
            {
                Console.WriteLine(type);
            }

            // -------------------------------------------------------------------------------------------



            Console.WriteLine(typeof(Program).Assembly);
        }


        public class Exercise
        {
            public void MyFunction(int i)
            {
                Console.WriteLine("MyFunction" + i);
            }

            protected internal class Person
            {

            }

            private class HideMe
            { 
            
            }
        }
    }
}
