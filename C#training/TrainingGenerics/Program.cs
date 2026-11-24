namespace TrainingGenerics
{
    internal class Program
    {
        
        // Generics help to make your code type-safe 
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            MyList<int> myListInt = new MyList<int>();
            myListInt.field = 5;
            Console.WriteLine(myListInt.SomeFunction());

            MyList<bool> myListBool = new MyList<bool>();
            myListBool.field = false;
            Console.WriteLine(myListBool.SomeFunction());

            TestFunction("G");
            TestFunction(true);
            TestFunction(5.546);
        }

        protected static void TestFunction<T>(T param1)
        { 
            Console.WriteLine(param1);
        }

        private class MyList<T>   // works with structs too
        {
            public T field;

            public T SomeFunction()
            {
                return default;  // default because we do not know if is nullable type
            }
        }


        private class MyListClassOnly<T> where T : class   // only class can be used
        {
            public T field;

            public T SomeFunction()
            {
                return null;  // can be null because we KNOW is nullable return type (class)
            }
        }


        private interface MyINterface<T>
        {
            T MyFunction();
        }
    }
}
