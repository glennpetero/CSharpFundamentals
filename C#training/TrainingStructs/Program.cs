namespace TrainingStructs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            PlayerClass playerClass = new PlayerClass();
            playerClass.a = 1;
            PlayerStruct playerStruct = new PlayerStruct();
            playerStruct.a = 1;

            TestFunctionClass(playerClass);
            TestFunctionStruct(playerStruct);

            Console.WriteLine($"playerClass {playerClass.a}");
            Console.WriteLine($"playerStruct {playerStruct.a}");
        }


        // NOTE: a struct cannot implement or inherit from a class

        private static void TestFunctionStruct(PlayerStruct playerStruct)
        {
            playerStruct.a = 2;
        }

        private static void TestFunctionClass(PlayerClass playerClass)
        {
            playerClass.a = 2;
        }

        public class PlayerClass
        {
            public int a;
        }

        public struct PlayerStruct 
        {
            public int a;
        }

    }
}
