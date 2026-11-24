namespace TrainingSizeOf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            // sizeof()  gives you how many bytes a certain type occupies

            // cannot use on classes,  but can use Marshall.SizeOf() or unsafe{} code block wrapper

            int i = 5;
            Console.WriteLine(sizeof(int));
        }


        public class Player
        {

            public int Speed;
            public bool IsGrounded()
            {
                return true;
            }
        }
    }
}
