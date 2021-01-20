using System;
using System.Linq;

namespace _05.SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[size[0], size[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] row = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            int maxSum = int.MinValue;
            int[,] maxMatrix = new int[2,2];

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int currSum = matrix[row, col];
                    currSum += matrix[row, col + 1];
                    currSum += matrix[row + 1, col];
                    currSum += matrix[row + 1, col + 1];

                    if (currSum > maxSum)
                    {
                        maxSum = currSum;

                        int[,] currMatrix = {
                            { matrix[row, col], matrix[row, col + 1] },
                            { matrix[row + 1, col], matrix[row + 1, col + 1] }
                        };

                        maxMatrix = currMatrix;
                    }
                }
            }

            for (int i = 0; i < maxMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < maxMatrix.GetLength(1); j++)
                {
                    Console.Write("{0} ", maxMatrix[i, j]);
                }

                Console.WriteLine();
            }
            Console.WriteLine(maxSum);
        }
    }
}
