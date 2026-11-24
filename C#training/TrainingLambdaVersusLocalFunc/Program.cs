namespace TrainingLambdaVersusLocalFunc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            // lambda function   (defined at run-time)
            Action<string> myAction = (string message) => Console.WriteLine(message);

            
            // local function (inside another function)  defined at complile-time
            void PrintMe(string message)
            { 
                Console.WriteLine($"{message}");
            };
            Action<string> myAction2 = PrintMe;

        }
    }
}
