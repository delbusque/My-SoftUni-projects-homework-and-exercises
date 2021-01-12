using System;

namespace Darts
{
    class Darts
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());
            int moves = 0;
            int totalPoints = 0;

            while (points > 0)
            {
                string pointType = Console.ReadLine();
                int movePoints = int.Parse(Console.ReadLine());
                moves++;

                switch (pointType)
                {
                    case "number section":
                        points -= movePoints;
                        totalPoints += movePoints;
                        break;

                    case "double ring":
                        points -= movePoints * 2;
                        totalPoints += movePoints * 2;
                        break;

                    case "triple ring":
                        points -= movePoints * 3;
                        totalPoints += movePoints * 3;
                        break;

                    case "bullseye":
                        Console.WriteLine($"Congratulations! You won the game with a bullseye in {moves} moves!");
                        Environment.Exit(4);
                        break;
                }
            }

            if (points == 0)
            {
                Console.WriteLine($"Congratulations! You won the game in {moves} moves!");
            }

            else
            {
                Console.WriteLine($"Sorry, you lost. Score difference: {totalPoints - points}.");
            }
        }
    }
}
