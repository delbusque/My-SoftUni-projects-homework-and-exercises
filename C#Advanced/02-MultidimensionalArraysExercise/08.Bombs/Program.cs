using System;
using System.Linq;
using System.Collections.Generic;

namespace _08.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            short size = short.Parse(Console.ReadLine());
            short[,] field = new short[size, size];

            for (int row = 0; row < size; row++)
            {
                short[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(short.Parse).ToArray();

                for (int col = 0; col < size; col++)
                {
                    field[row, col] = input[col];
                }
            }

            string[] bombsInput = Console.ReadLine().Split();

            for (int i = 0; i < bombsInput.Length; i++)
            {
                short[] bomb = bombsInput[i].Split(",", StringSplitOptions.RemoveEmptyEntries).Select(short.Parse).ToArray();
                short row = bomb[0];
                short col = bomb[1];

                if (field[row,col] > 0)
                {
                    if (col - 1 >= 0 && field[row, col - 1] > 0)
                    {
                        field[row, col - 1] -= field[row, col];
                    }
                    if (col+1 <= field.GetLength(1)-1 && field[row, col + 1] > 0)
                    {
                        field[row, col + 1] -= field[row, col];
                    }
                    if (row-1 >= 0 && col-1 >= 0 && field[row - 1, col - 1] > 0)
                    {
                        field[row - 1, col - 1] -= field[row, col];
                    }
                    if (row-1 >= 0 && field[row - 1, col] > 0)
                    {
                        field[row - 1, col] -= field[row, col];
                    }
                    if (row-1 >= 0 && col + 1 <= field.GetLength(1)-1 && field[row - 1, col + 1] > 0)
                    {
                        field[row - 1, col + 1] -= field[row, col];
                    }
                    if (row+1 <= field.GetLength(0)-1 && col-1 >= 0 && field[row + 1, col - 1] > 0)
                    {
                        field[row + 1, col - 1] -= field[row, col];
                    }
                    if (row+1 <= field.GetLength(0)-1 && field[row + 1, col] > 0)
                    {
                        field[row + 1, col] -= field[row, col];
                    }
                    if (row+1 <= field.GetLength(0) && col+1 <= field.GetLength(1)-1 && field[row + 1, col + 1] > 0)
                    {
                        field[row + 1, col + 1] -= field[row, col];
                    }  
                    
                    field[row, col] -= field[row, col];
                }
                
            }

            int sum = 0;
            int count = 0;

            foreach (var item in field)
            {
                if (item > 0)
                {
                    sum += item;
                    count++;
                }
            }

            Console.WriteLine($"Alive cells: {count}");
            Console.WriteLine($"Sum: {sum}");

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"{field[i,j]} ");
                }

                Console.WriteLine();
            }          
        }
    }
}
