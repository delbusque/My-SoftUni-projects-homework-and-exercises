using System;
using System.Collections.Generic;

namespace _02.Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int commands = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            for (int row = 0; row < size; row++)
            {
                string currRow = Console.ReadLine();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = currRow[col];
                }
            }

            while (commands > 0)
            {

                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        if (matrix[row, col] == 'f')
                        {
                            string command = Console.ReadLine();
                            commands--;

                            switch (command)
                            {
                                case "right":

                                    if (col == size - 1)
                                    {
                                        if (matrix[row, 0] == 'F')
                                        {
                                            matrix[row, col] = '-';
                                            matrix[row, 0] = 'f';
                                            PlayerWon(size, matrix);
                                        }
                                        else if (matrix[row, 0] == '-')
                                        {
                                            matrix[row, col] = '-';
                                            matrix[row, 0] = 'f';
                                        }
                                        else if (matrix[row, 0] == 'B')
                                        {
                                            matrix[row, col] = '-';
                                            matrix[row, 1] = 'f';
                                        }
                                        else if (matrix[row, 0] == 'T')
                                        {
                                            matrix[row, col] = 'f';
                                        }
                                    }
                                    else
                                    {
                                        if (matrix[row, col + 1] == 'F')
                                        {
                                            matrix[row, col] = '-';
                                            matrix[row, col + 1] = 'f';
                                            PlayerWon(size, matrix);
                                        }
                                        else if (matrix[row, col + 1] == '-')
                                        {
                                            matrix[row, col] = '-';
                                            matrix[row, col + 1] = 'f';
                                        }
                                        else if (matrix[row, col + 1] == 'B')
                                        {
                                            matrix[row, col] = '-';
                                            if (col + 2 <= size - 1)
                                            {
                                                matrix[row, col + 2] = 'f';
                                            }
                                            else
                                            {
                                                matrix[row, 0] = 'f';
                                            }
                                        }
                                        else if (matrix[row, col + 1] == 'T')
                                        {
                                            matrix[row, col] = 'f';
                                        }
                                    }
                                    break;

                                case "left":

                                    if (col == 0)
                                    {
                                        if (matrix[row, size - 1] == 'F')
                                        {
                                            matrix[row, col] = '-';
                                            matrix[row, size - 1] = 'f';
                                            PlayerWon(size, matrix);
                                        }
                                        else if (matrix[row, size - 1] == '-')
                                        {
                                            matrix[row, col] = '-';
                                            matrix[row, size - 1] = 'f';
                                        }
                                        else if (matrix[row, size - 1] == 'B')
                                        {
                                            matrix[row, col] = '-';
                                            matrix[row, size - 2] = 'f';
                                        }
                                        else if (matrix[row, size - 1] == 'T')
                                        {
                                            matrix[row, col] = 'f';
                                        }
                                    }
                                    else
                                    {
                                        if (matrix[row, col - 1] == 'F')
                                        {
                                            matrix[row, col] = '-';
                                            matrix[row, col - 1] = 'f';
                                            PlayerWon(size, matrix);
                                        }
                                        else if (matrix[row, col - 1] == '-')
                                        {
                                            matrix[row, col] = '-';
                                            matrix[row, col - 1] = 'f';
                                        }
                                        else if (matrix[row, col - 1] == 'B')
                                        {
                                            matrix[row, col] = '-';

                                            if (col - 2 >= 0)
                                            {
                                                matrix[row, col - 2] = 'f';
                                            }
                                            else
                                            {
                                                matrix[row, size - 1] = 'f';
                                            }

                                        }
                                        else if (matrix[row, col - 1] == 'T')
                                        {
                                            matrix[row, col] = 'f';
                                        }
                                    }
                                    break;

                                case "down":

                                    if (row == size - 1)
                                    {
                                        if (matrix[0, col] == 'F')
                                        {
                                            matrix[row, col] = '-';
                                            matrix[0, col] = 'f';
                                            PlayerWon(size, matrix);
                                        }
                                        else if (matrix[0, col] == '-')
                                        {
                                            matrix[row, col] = '-';
                                            matrix[0, col] = 'f';
                                        }
                                        else if (matrix[0, col] == 'B')
                                        {
                                            matrix[row, col] = '-';
                                            matrix[1, col] = 'f';
                                        }
                                        else if (matrix[0, col] == 'T')
                                        {
                                            matrix[row, col] = 'f';
                                        }
                                    }
                                    else
                                    {
                                        if (matrix[row + 1, col] == 'F')
                                        {
                                            matrix[row, col] = '-';
                                            matrix[row + 1, col] = 'f';
                                            PlayerWon(size, matrix);
                                        }
                                        else if (matrix[row + 1, col] == '-')
                                        {
                                            matrix[row, col] = '-';
                                            matrix[row + 1, col] = 'f';
                                        }
                                        else if (matrix[row + 1, col] == 'B')
                                        {
                                            matrix[row, col] = '-';

                                            if (row + 2 <= size - 1)
                                            {
                                                matrix[row + 2, col] = 'f';
                                            }
                                            else
                                            {
                                                matrix[0, col] = 'f';
                                            }
                                        }
                                        else if (matrix[row + 1, col] == 'T')
                                        {
                                            matrix[row, col] = 'f';
                                        }
                                    }
                                    break;

                                case "up":

                                    if (row == 0)
                                    {
                                        if (matrix[size - 1, col] == 'F')
                                        {
                                            matrix[row, col] = '-';
                                            matrix[size - 1, col] = 'f';
                                            PlayerWon(size, matrix);
                                        }
                                        else if (matrix[size - 1, col] == '-')
                                        {
                                            matrix[row, col] = '-';
                                            matrix[size - 1, col] = 'f';
                                        }
                                        else if (matrix[size - 1, col] == 'B')
                                        {
                                            matrix[row, col] = '-';
                                            matrix[size - 2, col] = 'f';
                                        }
                                        else if (matrix[size - 1, col] == 'T')
                                        {
                                            matrix[row, col] = 'f';
                                        }
                                    }
                                    else
                                    {
                                        if (matrix[row - 1, col] == 'F')
                                        {
                                            matrix[row, col] = '-';
                                            matrix[row - 1, col] = 'f';
                                            PlayerWon(size, matrix);
                                        }
                                        else if (matrix[row - 1, col] == '-')
                                        {
                                            matrix[row, col] = '-';
                                            matrix[row - 1, col] = 'f';
                                        }
                                        else if (matrix[row - 1, col] == 'B')
                                        {
                                            matrix[row, col] = '-';

                                            if (row - 2 >= 0)
                                            {
                                                matrix[row - 2, col] = 'f';
                                            }
                                            else
                                            {
                                                matrix[size - 1, col] = 'f';

                                            }
                                        }
                                        else if (matrix[row - 1, col] == 'T')
                                        {
                                            matrix[row, col] = 'f';
                                        }
                                    }
                                    break;
                            }
                        }
                    }
                } 
            }

            Console.WriteLine("Player lost!");

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(string.Join("", matrix[row, col]));
                }
                Console.WriteLine();
            }

        }

        static void PlayerWon(int size, char[,] matrix)
        {
            Console.WriteLine("Player won!");

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(string.Join("", matrix[row, col]));
                }
                Console.WriteLine();
            }

            Environment.Exit(0);
        }
    }
}
