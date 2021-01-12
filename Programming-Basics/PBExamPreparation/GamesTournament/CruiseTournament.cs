using System;

namespace GamesTournament
{
    class CruiseTournament
    {
        static void Main(string[] args)
        {
            string player = Console.ReadLine();
            int games = int.Parse(Console.ReadLine());

            double volleyballPoints = 0;
            double tennisPoints = 0;
            double badmintonPoints = 0;

            double volleyballGames = 0;
            double tennisGames = 0;
            double badmintonGames = 0;

            for (int g = 1; g <= games; g++)
            {
                string gameType = Console.ReadLine();
                double gamePoints = double.Parse(Console.ReadLine());

                switch (gameType)
                {
                    case "volleyball":
                        gamePoints *= 1.07;
                        volleyballPoints += gamePoints;
                        volleyballGames++;
                        break;

                    case "tennis":
                        gamePoints *= 1.05;
                        tennisPoints += gamePoints;
                        tennisGames++;
                        break;

                    case "badminton":
                        gamePoints *= 1.02;
                        badmintonPoints += gamePoints;
                        badmintonGames++;
                        break;
                }
            }

            double totalPoints = Math.Floor(volleyballPoints + tennisPoints + badmintonPoints);

            double volleyballPointsAver = Math.Floor(volleyballPoints / volleyballGames);
            double tennisPointsAver = Math.Floor(tennisPoints / tennisGames);
            double badmintonPointsAver = Math.Floor(badmintonPoints / badmintonGames);

            if (volleyballPointsAver >= 75 && tennisPointsAver >= 75 && badmintonPointsAver >= 75)
            {
                Console.WriteLine($"Congratulations, {player}! You won the cruise games with {totalPoints} points.");
            }

            else
            {
                Console.WriteLine($"Sorry, {player}, you lost. Your points are only {totalPoints}.");
            }
        }
    }
}
