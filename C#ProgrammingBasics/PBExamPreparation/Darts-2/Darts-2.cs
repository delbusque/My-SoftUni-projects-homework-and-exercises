using System;

namespace Darts
{
    class Darts
    {
        static void Main(string[] args)
        {
            int currentPoints = int.Parse(Console.ReadLine());
            int points = currentPoints;
            int moves = 0;
            int totalPoints = 0;
            bool notBullEye = true;

            while (currentPoints > 0)
            {
                string pointType = Console.ReadLine();
                
                moves++;
                
                if (pointType == "bullseye")
                {
                    notBullEye = false;
                    break;
                }

                int movePoints = int.Parse(Console.ReadLine());                

                if (pointType == "number section")
                {
                    currentPoints -= movePoints;
                    totalPoints += movePoints;
                }

                else if (pointType == "double ring")
                {
                    currentPoints -= (movePoints * 2);
                    totalPoints += (movePoints * 2);
                }

                else if (pointType == "triple ring")
                {
                    currentPoints -= (movePoints * 3);
                    totalPoints += (movePoints * 3);
                }
            }

            if (notBullEye == false)
            {
                Console.WriteLine($"Congratulations! You won the game with a bullseye in {moves} moves!");
            }
            else if (currentPoints == 0)
            {
                Console.WriteLine($"Congratulations! You won the game in {moves} moves!");
            }

            else if (currentPoints < totalPoints)
            {
                Console.WriteLine($"Sorry, you lost. Score difference: {totalPoints - points}.");
            }
        }
    }
}
