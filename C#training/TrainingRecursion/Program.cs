namespace TrainingRecursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int number = 0;
            while (number < 5)
            {
                number++;

            }
            Console.WriteLine(number);

            Console.WriteLine("");
            Console.WriteLine(RecursionIncrementer(0, 5, 1));


            //PrintDirectoryTree("C:\\Driver");

        }

        private static int RecursionIncrementer(int number, int numberMax, int incrementAmount)
        {
            //if (number < numberMax)
            //{
            //    return RecursionIncrementer(number + incrementAmount, numberMax, incrementAmount);
            //}
            //else
            //{
            //    return number;
            //}

            //return (number < numberMax) 
            //    ? RecursionIncrementer(number + incrementAmount, numberMax, incrementAmount) 
            //    : number;

            return (number < numberMax) switch
            {
                true => RecursionIncrementer(number + incrementAmount, numberMax, incrementAmount),
                false => number
            };
        }


        private static void PrintDirectoryTree(string path, int indentLevel = 0)
        {
            var dirInfo = new DirectoryInfo(path);
            Console.WriteLine($"{new string(' ', indentLevel * 4)}📁 {dirInfo.Name}");

            // Base cases are handled implicitly if arrays are empty
            foreach (var file in dirInfo.GetFiles())
            {
                Console.WriteLine($"{new string(' ', (indentLevel + 1) * 4)}📄 {file.Name}");
            }

            foreach (var subDir in dirInfo.GetDirectories())
            {
                // Recursive step
                PrintDirectoryTree(subDir.FullName, indentLevel + 1);
            }
        }


        void FloodFill(char[,] grid, int row, int col, char targetChar, char fillChar)
        {
            // Base cases: Out of bounds or already filled/blocked
            if (row < 0 || row >= grid.GetLength(0) || col < 0 || col >= grid.GetLength(1)) return;
            if (grid[row, col] != targetChar) return;

            // Change the current pixel
            grid[row, col] = fillChar;

            // Recursive steps (4 directions)
            FloodFill(grid, row + 1, col, targetChar, fillChar); // Down
            FloodFill(grid, row - 1, col, targetChar, fillChar); // Up
            FloodFill(grid, row, col + 1, targetChar, fillChar); // Right
            FloodFill(grid, row, col - 1, targetChar, fillChar); // Left
        }


        void RocketLaunch(int count)
        {
            if (count == 0)
            {
                Console.WriteLine("🚀 BLASTOFF!");
                return; // Base case reached
            }

            Console.WriteLine($"T-minus {count}..."); // Executes on the way IN (Winding)

            RocketLaunch(count - 1);                  // The recursive jump

            Console.WriteLine($"Safe altitude check for step {count}."); // Executes on the way OUT (Unwinding)
        }

    }
}
