namespace TrainingValueVersusReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // one works as a copy, the other as a reference
            // value types: contain their data   (Symbol types like int, float, bool, enum, struct, etc)
            // reference types: stores pointer to their data  (class, object, array, string)

            // Note: Value types cannot be NULL!


            // You are working with a COPY or a REFERENCE


            MyClass myClass = new MyClass();
            myClass.a = 7;
            MyClass mySecondClass = new MyClass();
            mySecondClass = myClass;
            mySecondClass.a = 5;

            Console.WriteLine($"Class: {myClass.a}");   // 5  because we have ONE object in memory with two pointers


            int a = 7;
            int b = a;   // b = 7 now...
            b = 5;       // b = 5 now...

            Console.WriteLine($"Value: {a}");   // 7  because a and b point to TWO separate objects in memory



            MyStruct myStruct = new MyStruct();
            myStruct.a = 7;
            MyStruct mySecondStruct = new MyStruct();
            mySecondStruct = myStruct;  // creates a COPY of the data
            mySecondStruct.a = 5;

            Console.WriteLine($"Struct: {myStruct.a}");  // 7  because struct is value type



            MyClass aClass = new MyClass();
            aClass.a = 7;
            MyStruct aStruct = new MyStruct();
            aStruct.a = 7;

            MyFunction(aClass, aStruct);
            Console.WriteLine(aClass.a + " " + aStruct.a);
        }

        private static void MyFunction(MyClass myClass, MyStruct myStruct)
        {
            myClass.a = 5;   // modifying reference (pointing to ref of original data value)
            myStruct.a = 5;  // modifying value
        }


        private class MyClass
        {
            public int a;
        }

        private struct MyStruct
        {
            public int a;
        }
    }
}
