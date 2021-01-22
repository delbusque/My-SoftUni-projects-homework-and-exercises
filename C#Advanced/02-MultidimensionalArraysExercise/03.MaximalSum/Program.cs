using System;
using System.Linq;
using System.Numerics;

namespace _03.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[size[0], size[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int maxSum = int.MinValue;
            int[,] maxMatrix = new int[3, 3];

            if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
            {
                maxMatrix = matrix;
                int currSum = 0;

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        currSum += matrix[i, j];
                    }
                }
                maxSum = currSum;
            }
            
            else
            {
                for (int row = 0; row < matrix.GetLength(1) - 3; row++)
                {
                    for (int col = 0; col < matrix.GetLength(1) - 3; col++)
                    {

                        int currSum = matrix[row, col];
                        currSum += matrix[row, col + 1];
                        currSum += matrix[row, col + 2];
                        currSum += matrix[row + 1, col];
                        currSum += matrix[row + 1, col + 1];
                        currSum += matrix[row + 1, col + 2];
                        currSum += matrix[row + 2, col];
                        currSum += matrix[row + 2, col + 1];
                        currSum += matrix[row + 2, col + 2];

                        if (currSum >= maxSum)
                        {
                            maxSum = currSum;

                            int[,] currMatrix = {
                        { matrix[row, col], matrix[row, col+1], matrix[row, col+2] },
                        { matrix[row+1, col], matrix[row+1, col+1], matrix[row+1, col+2] },
                        { matrix[row+2, col], matrix[row+2, col+1], matrix[row+2, col+2] }
                    };

                            maxMatrix = currMatrix;
                        }
                    }
                }
            }          

            Console.WriteLine($"Sum = {maxSum}");

            for (int row = 0; row < maxMatrix.GetLength(0); row++)
            {          
                for (int col = 0; col < maxMatrix.GetLength(1); col++)
                {
                    Console.Write($"{maxMatrix[row, col]} ");
                }

                Console.WriteLine();
            }
            
        }
    }
}
