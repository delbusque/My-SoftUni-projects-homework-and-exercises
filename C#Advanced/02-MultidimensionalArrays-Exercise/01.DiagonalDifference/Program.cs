using System;
using System.Linq;

namespace _01.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];
            int[,] matrixReversed = new int[size, size];


            for (int i = 0; i < size; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int[] reversed = input.Reverse().ToArray();

                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = input[j];
                }

                for (int k = 0; k < size; k++)
                {
                    matrixReversed[i, k] = reversed[k];
                }
            }


            int primarySum = 0;
            int secondarySum = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        primarySum += matrix[i, j];
                    }
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < matrixReversed.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        secondarySum += matrixReversed[i, j];
                    }
                }
            }

            int difference = Math.Abs(primarySum - secondarySum);

            Console.WriteLine(difference);
        }
    }
}
