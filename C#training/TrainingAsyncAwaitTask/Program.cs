using System.Net;

namespace TrainingAsyncAwaitTask
{
    internal class Program
    {
        protected static string webServerData = "";
        //private static bool allDone = false;
        public static async Task Main()
        {
            //Console.WriteLine("Hello, World!");
            // asychronous: executes in non-linear manner, and is NOT multi-threaded (runs on main thread)

            //await ContactWebServer();

            //while (allDone == false) 
            //{
            //    if (task.IsCompleted)
            //    {
            //        allDone = true;
            //    }
            //    else
            //    {
            //        Console.WriteLine("-");
            //    }
            //} 

            //Console.WriteLine("All finished");


            string serverReturnData = await ContactWebServer();
            Console.WriteLine(serverReturnData);
            Console.WriteLine("---------------");



            // cook breakfast example

            // ---------------------
            // this is linear way, that wasted time waiting on each one to finish
            await CookEggs();
            await CookBacon();
            await MakeToast();
            Console.WriteLine("Linear is done!");
            Console.WriteLine("---------------");


            // ---------------------
            // this is non-linear way, that starts each one, then awaits the tasks to be done
            Task eggs = CookEggs();
            Task bacon = CookBacon();
            Task toast = MakeToast();
            await Task.WhenAll(eggs, bacon, toast);
            Console.WriteLine("Non-Linear is done!");
            Console.WriteLine("---------------");
        }


        public static async Task<string> ContactWebServer()
        {
            Console.WriteLine("Contacting ");
            await Task.Delay(3000);
            webServerData = "Data!";
            Console.WriteLine("Got response!");
            return "Data!";
        }



        // cooking breakfast example

        public static async Task CookEggs()
        {
            Console.WriteLine("Cooking eggs!");
            await Task.Delay(3000);
            Console.WriteLine("Eggs done!");
        }

        public static async Task CookBacon()
        {
            Console.WriteLine("Cooking bacon!");
            await Task.Delay(5000);
            Console.WriteLine("Bacon done!");
        }
        public static async Task MakeToast()
        {
            Console.WriteLine("Making toast!");
            await Task.Delay(1000);
            Console.WriteLine("Toast is done!");
        }
    }
}
