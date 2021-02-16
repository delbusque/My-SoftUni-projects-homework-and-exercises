using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] square = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[,] garden = new int[square[0], square[1]];

            string input = Console.ReadLine();
            while (input != "Bloom Bloom Plow")
            {
                int[] current = input.Split().Select(int.Parse).ToArray();
                int currRow = current[0];
                int currCol = current[1];
                bool validRow = currRow >= 0 && currRow < square[0];
                bool validCol = currCol >= 0 && currCol < square[1];

                if (validRow && validCol)
                {
                    garden[currCol, currCol] = 1;
                }
                else
                {
                    Console.WriteLine("Invalid coordinates.");
                }

                input = Console.ReadLine();
            }

            Dictionary<int, int> planted = new Dictionary<int, int>();
            
            for (int row = 0; row < garden.GetLength(0); row++)
            {
                for (int col = 0; col < garden.GetLength(1); col++)
                {
                    if (garden[row, col] == 1)
                    {
                        planted.Add(row, col);
                    }
                }
            }

            foreach (var flo in planted)
            {
                for (int i = flo.Value + 1; i < garden.GetLength(0); i++)
                {
                    garden[flo.Key, i] += 1;
                }
                for (int i = flo.Value - 1; i >= 0; i--)
                {
                    garden[flo.Key, i] += 1;
                }

                for (int i = flo.Key + 1; i < garden.GetLength(1); i++)
                {
                    garden[i, flo.Value] += 1;
                }
                for (int i = flo.Key - 1; i >= 0; i--)
                {
                    garden[i, flo.Value] += 1;
                }


            }

            for (int row = 0; row < garden.GetLength(0); row++)
            {
                for (int col = 0; col < garden.GetLength(1); col++)
                {
                    Console.Write($"{string.Join(" ", garden[row, col])} ");
                }
                Console.WriteLine();
            }
        }
    }
}
