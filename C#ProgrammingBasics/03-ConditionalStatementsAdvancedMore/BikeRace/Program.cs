using System;

namespace BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string raceType = Console.ReadLine();

            double juniorsFea = 0;
            double seniorsFea = 0;

            switch (raceType)
            {
                case "trail":
                    juniorsFea = 5.50;
                    seniorsFea = 7.00;
                    break;

                case "cross-country":
                    juniorsFea = 8.00;
                    seniorsFea = 9.50;

                    if (juniors + seniors >= 50)
                    {
                        juniorsFea *= 0.75;
                        seniorsFea *= 0.75;
                    }
                    break;

                case "downhill":
                    juniorsFea = 12.25;
                    seniorsFea = 13.75;
                    break;

                case "road":
                    juniorsFea = 20.00;
                    seniorsFea = 21.50;
                    break;
            }

            double totalJuniorsFea = juniorsFea * juniors;
            double totalSeniorsFea = seniorsFea * seniors;

            double totalSum = (totalJuniorsFea + totalSeniorsFea) * 0.95;

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
