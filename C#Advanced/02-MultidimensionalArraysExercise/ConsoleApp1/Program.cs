using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] board = new char[size, size];

            for (int row = 0; row < size; row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < size; col++)
                {
                    board[row, col] = input[col];
                }
            }

            Dictionary<int, int> horses = new Dictionary<int, int>();

            int horseNumber = 0;
            int attacks = 0;
            int removalCount = 0;

            for (int r = 0; r < size; r++)
            {
                for (int c = 0; c < size; c++)
                {
                    if (board[r, c] == 'K')
                    {
                        horseNumber++;
                        horses.Add(horseNumber, 0);

                        if (r - 1 >= 0 && c + 2 < board.GetLength(1))
                        {
                            if (board[r - 1, c + 2] == 'K')
                            {
                                horses[horseNumber]++;
                            }
                        }                       
                        if (r - 2 >= 0 && c + 1 < board.GetLength(1))
                        {
                            if (board[r - 2, c + 1] == 'K')
                            {
                                horses[horseNumber]++;
                            }
                        }                        

                        if (r + 1 < board.GetLength(0) && c - 2 >= 0)
                        {
                            if (board[r + 1, c - 2] == 'K')
                            {
                                horses[horseNumber]++;
                            }
                        }                       
                        if (r + 2 < board.GetLength(0) && c - 1 >= 0)
                        {
                            if (board[r + 2, c - 1] == 'K')
                            {
                                horses[horseNumber]++;
                            }
                        }

                        if (r + 2 < size && c + 1 < size)
                        {
                            if (board[r + 2, c + 1] == 'K')
                            {
                                horses[horseNumber]++;
                            }
                        }
                        if (r + 1 < size && c + 2 < size)
                        {
                            if (board[r + 1, c + 2] == 'K')
                            {
                                horses[horseNumber]++;
                            }
                        }
                        
                        if (r - 2 >= 0 && c - 1 >= 0)
                        {
                            if (board[r - 2, c - 1] == 'K')
                            {
                                horses[horseNumber]++;
                            }
                        }
                        if (r - 1 >= 0 && c - 2 >= 0)
                        {
                            if (board[r - 1, c - 2] == 'K')
                            {
                                horses[horseNumber]++;
                            }
                        }

                        
                        attacks += horses[horseNumber];
                    }
                }
            }

            attacks /= 2;

            while (attacks > 0)
            {
                foreach (var item in horses.OrderByDescending(h => h.Value))
                {
                    attacks -= item.Value;
                    
                    removalCount++;


                    if (attacks == 0)
                    {
                        break;
                    }
                    else if (attacks < 0)
                    {
                        removalCount = removalCount + Math.Abs(attacks) + 1;
                        break;
                    }
                }
            }

            Console.WriteLine(removalCount);
        }
    }
}
