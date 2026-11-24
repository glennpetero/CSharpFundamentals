namespace TrainingTryCatchFinally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            try
            {
                throw new Exception("Player Exception");
                
                int a = 0;
                int b = 1 / a;  // divide by zero!
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("DivideByZeroException");
                //return;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                Console.WriteLine(exception.StackTrace);
                throw;  // raise the exception up to calling object
            }
            finally
            {
                Console.WriteLine("Finally done!");
            }

            Console.WriteLine("Made it to the end!");           

        }
    }
}
