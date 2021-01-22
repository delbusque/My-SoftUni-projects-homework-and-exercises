using System;
using System.Linq;

namespace _06.Jagged_ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = int.Parse(Console.ReadLine());
            int[][] jagged = new int[r][];

            for (int i = 0; i < jagged.Length; i++)
            {
                jagged[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();             
            }

            string[] commands = Console.ReadLine().Split();

            while (commands[0] != "END")
            {
                int row = int.Parse(commands[1]);
                int col = int.Parse(commands[2]);
                int value = int.Parse(commands[3]);

                if (row <= jagged.Length-1 && row >= 0 && col <= jagged[row].Length-1 && col >= 0)
                {
                    if (commands[0] == "Add")
                    {
                        jagged[row][col] += value;
                    }

                    else if (commands[0] == "Subtract")
                    {
                        jagged[row][col] -= value;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }

                commands = Console.ReadLine().Split();
            }

            foreach (int[] row in jagged)
            {
                Console.WriteLine(string.Join(" ", row));
            }     
        }
    }
}
