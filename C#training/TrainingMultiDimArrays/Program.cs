using System.Runtime.CompilerServices;

namespace TrainingMultiDimArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //int[,] intArray = new int[5,6];
            //Console.WriteLine(intArray.Length);
            //Console.WriteLine(intArray.GetLength(0));
            //Console.WriteLine(intArray.GetLength(1));

            // Multi-dimensional Arrays
            int[,] intArray = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            int ctr = 0;
            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    //intArray[i,j] = ctr++;
                    //ctr+=1;
                    intArray[i, j] = ctr+=1;
                    Console.WriteLine($"{i}, {j}: {intArray[i, j]}");
                    //Console.WriteLine(i + ", " + j + ": " + intArray[i, j]);
                }                
            }

            // Array of arrays  (can have jagged arrays, which can have different sizes)
            Console.WriteLine("");
            ctr = 0;
            int[][] intArrayOfArrays = new int[2][];
            for (int i = 0; i < intArrayOfArrays.Length; i++)
            {
                intArrayOfArrays[i] = new int[3];
                for (int j = 0; j < intArrayOfArrays[i].Length; j++)
                {                    
                    intArrayOfArrays[i][j] = ctr+=1;
                    Console.WriteLine($"{i}, {j}: {intArrayOfArrays[i][j]}");
                }
            }
        }
    }
}
