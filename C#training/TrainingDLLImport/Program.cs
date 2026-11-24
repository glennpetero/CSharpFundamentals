

using System.Runtime.InteropServices;

namespace TrainingDLLImport
{
    internal class Program
    {
        [DllImport("user32.dll")]
        public static extern bool MessageBeep(uint uType);

        // pinvoke.net has info on Windows DLLs
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            MessageBeep(0);
        }
    }
}
