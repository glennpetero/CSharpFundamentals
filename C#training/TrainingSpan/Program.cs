namespace TrainingSpan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] numberArray = new int[] { 1, 2, 33, 14, 25, 6, 7, 8 };
            PrintArray(numberArray);

            // to sort only the 'middle of the array, you could create 
            // a new array with a subset of the original 

            // but better, is Span<T>  (no memory allocation, just point to original data in memory)
            Span<int> intSpan = new Span<int>(numberArray, 1, numberArray.Length - 2);
            intSpan.Sort();
            PrintArray(numberArray);

            intSpan.Fill(58);
            PrintArray(numberArray);

            // can use ReadOnlySpan<> if truly readononly
            string str = "58,12";
            ReadOnlySpan<char> charSpan = str;
            int number1 = int.Parse(charSpan.Slice(0, 2));
            int number2 = int.Parse(charSpan.Slice(3, 2));
            Console.WriteLine(number1 + " " + number2);

            // Use Split() here?
        }


        private static void PrintArray(int[] array)
        {
            Console.WriteLine("Start Print");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("End Print");
        }
    }
}
