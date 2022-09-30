using System;
using System.Linq;

namespace _02.Warships
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(",").ToArray();
            char[,] field = new char[size, size];
            for (int row = 0; row < size; row++)
            {
                char[] currentRow = Console.ReadLine().Split().Select(char.Parse).ToArray();
          
                for (int col = 0; col < size; col++)
                {
                    field[row, col] = currentRow[col];
                }
            }
            int playerOneShips = 0; int playerTwoShips = 0;
            foreach (var item in field)
            {
                if (item == '<')
                {
                    playerOneShips++;
                }
                else if (item == '>')
                {
                    playerTwoShips++;
                }
            }
            int destroyedShips = 0;

            for (int a = 0; a < input.Length; a++)
            {
                int[] attack = input[a].Split().Select(int.Parse).ToArray();
                int attackRow = attack[0]; int attackCol = attack[1];

                if (attackRow >= 0 && attackRow < size && attackCol >= 0 && attackCol < size)
                {
                    for (int row = 0; row < size; row++)
                    {
                        for (int col = 0; col < size; col++)
                        {
                            if (field[row, col] == field[attackRow, attackCol])
                            {
                                if (a % 2 == 0)
                                {
                                    if (field[row, col] == '>')
                                    {
                                        field[row, col] = 'X'; playerTwoShips--; destroyedShips++;
                                        if (playerTwoShips == 0)
                                        {
                                            Console.WriteLine($"Player One has won the game! {destroyedShips} ships have been sunk in the battle.");
                                            return;
                                        }
                                    }
                                    else if (field[row, col] == '#')
                                    {
                                        field[row, col] = 'X';
                                        if (col + 1 < size)
                                        {
                                            if (field[row, col + 1] == '>')
                                            {
                                                field[row, col + 1] = 'X'; playerTwoShips--; destroyedShips++;
                                                if (playerTwoShips == 0)
                                                {
                                                    Console.WriteLine($"Player One has won the game! {destroyedShips} ships have been sunk in the battle.");
                                                    return;
                                                }
                                            }                                          
                                        }
                                        if (col - 1 >= 0)
                                        {
                                            if (field[row, col - 1] == '>')
                                            {
                                                field[row, col - 1] = 'X';   playerTwoShips--; destroyedShips++;
                                                if (playerTwoShips == 0)
                                                {
                                                    Console.WriteLine($"Player One has won the game! {destroyedShips} ships have been sunk in the battle.");
                                                    return;
                                                }
                                            }                                            
                                        }
                                        if (row + 1 < size)
                                        {
                                            if (field[row + 1, col] == '>')
                                            {
                                                field[row + 1, col] = 'X'; playerTwoShips--; destroyedShips++;
                                                if (playerTwoShips == 0)
                                                {
                                                    Console.WriteLine($"Player One has won the game! {destroyedShips} ships have been sunk in the battle.");
                                                    return;
                                                }
                                            }                                           
                                        }
                                        if (row - 1 >= 0)
                                        {
                                            if (field[row - 1, col] == '>')
                                            {
                                                field[row - 1, col] = 'X'; playerTwoShips--; destroyedShips++;
                                                if (playerTwoShips == 0)
                                                {
                                                    Console.WriteLine($"Player One has won the game! {destroyedShips} ships have been sunk in the battle.");
                                                    return;
                                                }
                                            }                                           
                                        }
                                        if (row - 1 >= 0 && col - 1 >= 0)
                                        {
                                            if (field[row - 1, col - 1] == '>')
                                            {
                                                field[row - 1, col - 1] = 'X';  playerTwoShips--; destroyedShips++;
                                                if (playerTwoShips == 0)
                                                {
                                                    Console.WriteLine($"Player One has won the game! {destroyedShips} ships have been sunk in the battle.");
                                                    return;
                                                }
                                            }                                           
                                        }
                                        if (row - 1 >= 0 && col + 1 < size)
                                        {
                                            if (field[row - 1, col + 1] == '>')
                                            {
                                                field[row - 1, col + 1] = 'X'; playerTwoShips--; destroyedShips++;
                                                if (playerTwoShips == 0)
                                                {
                                                    Console.WriteLine($"Player One has won the game! {destroyedShips} ships have been sunk in the battle.");
                                                    return;
                                                }
                                            }                                            
                                        }
                                        if (row + 1 < size && col - 1 >= 0)
                                        {
                                            if (field[row + 1, col - 1] == '>')
                                            {
                                                field[row + 1, col - 1] = 'X';  playerTwoShips--; destroyedShips++;
                                                if (playerTwoShips == 0)
                                                {
                                                    Console.WriteLine($"Player One has won the game! {destroyedShips} ships have been sunk in the battle.");
                                                    return;
                                                }
                                            }                                           
                                        }
                                        if (row + 1 < size && col + 1 < size)
                                        {
                                            if (field[row + 1, col + 1] == '>')
                                            {
                                                field[row + 1, col + 1] = 'X';  playerTwoShips--; destroyedShips++;
                                                if (playerTwoShips == 0)
                                                {
                                                    Console.WriteLine($"Player One has won the game! {destroyedShips} ships have been sunk in the battle.");
                                                    return;
                                                }
                                            }                                            
                                        }
                                    }
                                }
                                else
                                {
                                    if (field[row, col] == '<')
                                    {
                                        field[row, col] = 'X'; playerOneShips--;destroyedShips++;
                                        if (playerOneShips == 0)
                                        {
                                            Console.WriteLine($"Player Two has won the game! {destroyedShips} ships have been sunk in the battle.");
                                            return;
                                        }
                                    }
                                    else if (field[row, col] == '#')
                                    {
                                        field[row, col] = 'X';

                                        if (col + 1 < size)
                                        {
                                            if (field[row, col + 1] == '<')
                                            {
                                                field[row, col + 1] = 'X';  playerOneShips--; destroyedShips++;
                                                if (playerOneShips == 0)
                                                {
                                                    Console.WriteLine($"Player Two has won the game! {destroyedShips} ships have been sunk in the battle.");
                                                    return;
                                                }
                                            }                                            
                                        }
                                        if (col - 1 >= 0)
                                        {
                                            if (field[row, col - 1] == '<')
                                            {
                                                field[row, col - 1] = 'X'; playerOneShips--;  destroyedShips++;
                                                if (playerOneShips == 0)
                                                {
                                                    Console.WriteLine($"Player Two has won the game! {destroyedShips} ships have been sunk in the battle.");
                                                    return;
                                                }
                                            }                                            
                                        }
                                        if (row + 1 < size)
                                        {
                                            if (field[row + 1, col] == '<')
                                            {
                                                field[row + 1, col] = 'X'; playerOneShips--; destroyedShips++;
                                                if (playerOneShips == 0)
                                                {
                                                    Console.WriteLine($"Player Two has won the game! {destroyedShips} ships have been sunk in the battle.");
                                                    return;
                                                }
                                            }                                            
                                        }
                                        if (row - 1 >= 0)
                                        {
                                            if (field[row - 1, col] == '<')
                                            {
                                                field[row - 1, col] = 'X'; playerOneShips--; destroyedShips++;
                                                if (playerOneShips == 0)
                                                {
                                                    Console.WriteLine($"Player Two has won the game! {destroyedShips} ships have been sunk in the battle.");
                                                    return;
                                                }
                                            }                                            
                                        }
                                        if (row - 1 >= 0 && col - 1 >= 0)
                                        {
                                            if (field[row - 1, col - 1] == '<')
                                            {
                                                field[row - 1, col - 1] = 'X'; playerOneShips--;  destroyedShips++;
                                                if (playerOneShips == 0)
                                                {
                                                    Console.WriteLine($"Player Two has won the game! {destroyedShips} ships have been sunk in the battle.");
                                                    return;
                                                }
                                            }                                            
                                        }
                                        if (row - 1 >= 0 && col + 1 < size)
                                        {
                                            if (field[row - 1, col + 1] == '<')
                                            {
                                                field[row - 1, col + 1] = 'X';  playerOneShips--;  destroyedShips++;
                                                if (playerOneShips == 0)
                                                {
                                                    Console.WriteLine($"Player Two has won the game! {destroyedShips} ships have been sunk in the battle.");
                                                    return;
                                                }
                                            }                                            
                                        }
                                        if (row + 1 < size && col - 1 >= 0)
                                        {
                                            if (field[row + 1, col - 1] == '<')
                                            {
                                                field[row + 1, col - 1] = 'X';  playerOneShips--;  destroyedShips++;
                                                if (playerOneShips == 0)
                                                {
                                                    Console.WriteLine($"Player Two has won the game! {destroyedShips} ships have been sunk in the battle.");
                                                    return;
                                                }
                                            }                                            
                                        }
                                        if (row + 1 < size && col + 1 < size)
                                        {
                                            if (field[row + 1, col + 1] == '<')
                                            {
                                                field[row + 1, col + 1] = 'X';  playerOneShips--; destroyedShips++;
                                                if (playerOneShips == 0)
                                                {
                                                    Console.WriteLine($"Player Two has won the game! {destroyedShips} ships have been sunk in the battle.");
                                                    return;
                                                }
                                            }                                            
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (playerOneShips > 0 && playerTwoShips > 0)
            {
                Console.WriteLine($"It's a draw! Player One has {playerOneShips} ships left. Player Two has {playerTwoShips} ships left.");
            }
        }
    }
}
