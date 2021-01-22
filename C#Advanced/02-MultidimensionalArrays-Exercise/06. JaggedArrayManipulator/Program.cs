using System;
using System.Linq;

namespace _06._JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            double[][] jagged = new double[rows][];

            for (int i = 0; i < jagged.Length; i++)
            {
                jagged[i] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse).ToArray();               
            }

            for (int row = 0; row < rows - 1; row++)
            {
                double[] first = jagged[row];
                double[] second = jagged[row+1];

                if (first.Length == second.Length)
                {
                    jagged[row] = first.Select(x => x * 2).ToArray();
                    jagged[row+1] = second.Select(x => x * 2).ToArray();
                }
                else
                {
                    jagged[row] = first.Select(x => x / 2).ToArray();
                    jagged[row+1] = second.Select(x => x / 2).ToArray();
                }
            }

            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "End")
            {
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);

                if (row < jagged.Length && row >= 0)
                {
                    if (col < jagged[row].Length && col >= 0)
                    {
                        if (command[0] == "Add")
                        {
                            jagged[row][col] += value;
                        }
                        else if (command[0] == "Subtract")
                        {
                            jagged[row][col] -= value;
                        }
                    }   
                }

                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            for (int i = 0; i < jagged.Length; i++)
            {
                Console.WriteLine(string.Join(" ", jagged[i]));
            }
        }
    }
}
