using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] field = new char[n, n];
            int snakeRow = -1;
            int snakeCol = -1;          
            
            int lairOneRow = - 1;
            int lairOneCol = - 1;
            int lairTwoRow = -1;
            int lairTwoCol = -1;
            
            for (int row = 0; row < n; row++)
            {
                string curRow = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    field[row, col] = curRow[col];

                    if (curRow[col] == 'S')
                    {
                        snakeRow = row;
                        snakeCol = col;
                    }
                    else if (curRow[col] == 'B')
                    {
                        if (lairOneRow == -1)
                        {
                            lairOneRow = row;
                            lairOneCol = col;
                        }
                        else
                        {
                            lairTwoRow = row;
                            lairTwoCol = col;
                        }
                    }
                }
            }

            int foodQuantity = 0;
            bool outOfBounds = false;

            while (true)
            {
                if (outOfBounds)
                {
                    Console.WriteLine("Game over!");
                    break;
                }

                if (foodQuantity == 10)
                {
                    Console.WriteLine("You won! You fed the snake.");
                    break;
                }
                
                string command = Console.ReadLine();

                switch (command)
                {
                    case "down":
                        field[snakeRow, snakeCol] = '.';
                        snakeRow++;

                        if (snakeRow > field.GetLength(0) - 1)
                        {                           
                            outOfBounds = true;
                            break;
                        }

                        if (field[snakeRow, snakeCol] == '*')
                        {
                            foodQuantity++;
                            field[snakeRow, snakeCol] = 'S';
                           
                        }
                        else if (field[snakeRow, snakeCol] == 'B')
                        {                            
                            if (field[snakeRow, snakeCol] == field[lairOneRow, lairOneCol])
                            {
                                field[snakeRow, snakeCol] = '.';
                                snakeRow = lairTwoRow;
                                snakeCol = lairTwoCol;                          
                            }
                            else if (field[snakeRow, snakeCol] == field[lairTwoRow, lairTwoCol])
                            {
                                field[snakeRow, snakeCol] = '.';
                                snakeRow = lairOneRow;
                                snakeCol = lairOneCol;
                            }                            
                        }

                        break;

                    case "up":
                        field[snakeRow, snakeCol] = '.';
                        snakeRow--;

                        if (snakeRow < 0)
                        {
                            outOfBounds = true;
                            break;
                        }

                        if (field[snakeRow, snakeCol] == '*')
                        {
                            foodQuantity++;
                            field[snakeRow, snakeCol] = 'S';
                          
                        }
                        else if (field[snakeRow, snakeCol] == 'B')
                        {
                            if (field[snakeRow, snakeCol] == field[lairOneRow, lairOneCol])
                            {
                                field[snakeRow, snakeCol] = '.';
                                snakeRow = lairTwoRow;
                                snakeCol = lairTwoCol;                             
                            }
                            else if (field[snakeRow, snakeCol] == field[lairTwoRow, lairTwoCol])
                            {
                                field[snakeRow, snakeCol] = '.';
                                snakeRow = lairOneRow;
                                snakeCol = lairOneCol;
                            }
                        }
                        
                        break;

                    case "left":
                        field[snakeRow, snakeCol] = '.';
                        snakeCol--;

                        if (snakeCol < 0)
                        {
                            outOfBounds = true;
                            break;
                        }

                        if (field[snakeRow, snakeCol] == '*')
                        {
                            foodQuantity++;
                            field[snakeRow, snakeCol] = 'S';
                        }
                        else if (field[snakeRow, snakeCol] == 'B')
                        {
                            if (field[snakeRow, snakeCol] == field[lairOneRow, lairOneCol])
                            {
                                field[snakeRow, snakeCol] = '.';
                                snakeRow = lairTwoRow;
                                snakeCol = lairTwoCol;                               
                            }
                            else if (field[snakeRow, snakeCol] == field[lairTwoRow, lairTwoCol])
                            {
                                field[snakeRow, snakeCol] = '.';
                                snakeRow = lairOneRow;
                                snakeCol = lairOneCol;
                            }
                        }                        
                        break;

                    case "right":
                        field[snakeRow, snakeCol] = '.';
                        snakeCol++;

                        if (snakeCol > field.GetLength(1) - 1)
                        {
                            outOfBounds = true;
                            break;
                        }

                        if (field[snakeRow, snakeCol] == '*')
                        {
                            foodQuantity++;
                            field[snakeRow, snakeCol] = 'S';                           
                        }

                        else if (field[snakeRow, snakeCol] == 'B')
                        {
                            if (field[snakeRow, snakeCol] == field[lairOneRow, lairOneCol])
                            {
                                field[snakeRow, snakeCol] = '.';
                                snakeRow = lairTwoRow;
                                snakeCol = lairTwoCol;                              
                            }

                            else if (field[snakeRow, snakeCol] == field[lairTwoRow, lairTwoCol])
                            {
                                field[snakeRow, snakeCol] = '.';
                                snakeRow = lairOneRow;
                                snakeCol = lairOneCol;
                            }
                        }
                        break;
                }
            }

            Console.WriteLine($"Food eaten: {foodQuantity}");

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(field[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
