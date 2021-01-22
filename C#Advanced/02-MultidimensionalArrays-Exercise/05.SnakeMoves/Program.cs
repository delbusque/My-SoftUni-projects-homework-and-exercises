using System;
using System.Linq;

namespace _05.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string snake = Console.ReadLine();

            char[,] snakeMatrix = new char[size[0], size[1]];

            int currLetter = 0;


            for (int row = 0; row < snakeMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < snakeMatrix.GetLength(1); col++)
                {

                    if (row % 2 == 0)
                    {
                        snakeMatrix[row, col] = snake[currLetter];

                        currLetter++;

                        if (currLetter == snake.Length)
                        {
                            currLetter = 0;
                        }
                    }
                    else
                    {
                        snakeMatrix[row, snakeMatrix.GetLength(1)-1 - col] = snake[currLetter];

                        currLetter++;

                        if (currLetter == snake.Length)
                        {
                            currLetter = 0;
                        }
                    }
                }

            }

            for (int row = 0; row < size[0]; row++)
            {
                for (int col = 0; col < size[1]; col++)
                {
                    Console.Write(string.Join("", snakeMatrix[row, col]));
                }
                Console.WriteLine();
            }
        }
    }
}
