using System;
using System.Linq;

namespace _04.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string[,] matrix = new string[size[0], size[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            string[] commands = Console.ReadLine().Split();

            while (commands[0] != "END")
            {
                if (commands[0] == "swap" && commands.Length == 5)
                {
                    int row = int.Parse(commands[1]);
                    int col = int.Parse(commands[2]);
                    int rowSwap = int.Parse(commands[3]);
                    int colSwap = int.Parse(commands[4]);

                    if (row <= matrix.GetLength(0) - 1 && col <= matrix.GetLength(1) - 1 && rowSwap <= matrix.GetLength(0) - 1 && colSwap <= matrix.GetLength(1) - 1)                  
                    {
                        string temp = matrix[row, col];

                        matrix[row, col] = matrix[rowSwap, colSwap];
                        matrix[rowSwap, colSwap] = temp;

                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                Console.Write($"{matrix[i, j]} ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                commands = Console.ReadLine().Split();
            }
        }
    }
}
