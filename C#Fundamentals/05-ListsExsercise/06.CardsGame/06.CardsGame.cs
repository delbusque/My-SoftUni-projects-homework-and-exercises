using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> playerOne = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> playerTwo = Console.ReadLine().Split().Select(int.Parse).ToList();

            // 10 20 30 40 50
            // 50 40 30 30 10

            while (playerOne.Count != 0 && playerTwo.Count != 0)
            {
                int playerOneCard = playerOne[0];
                int playerTwoCard = playerTwo[0];

                if (playerOneCard > playerTwoCard)
                {
                    playerOne.Add(playerOneCard);
                    playerOne.Add(playerTwoCard);
                    playerOne.Remove(playerOne[0]);
                    playerTwo.Remove(playerTwoCard);
                }
                else if (playerOneCard < playerTwoCard)
                {
                    playerTwo.Add(playerTwoCard);
                    playerTwo.Add(playerOneCard);
                    playerTwo.Remove(playerTwo[0]);
                    playerOne.Remove(playerOneCard);
                }
                else
                {
                    playerOne.Remove(playerOneCard);
                    playerTwo.Remove(playerTwoCard);
                }
                
            }

            if (playerOne.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {playerTwo.Sum()}");
            }
            else if(playerTwo.Count == 0)
            {
                Console.WriteLine($"First player wins! Sum: {playerOne.Sum()}");
            }

        }
    }
}
