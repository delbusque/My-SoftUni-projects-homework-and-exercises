using System;
using System.Data;

namespace BakingCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int participantsNumber = int.Parse(Console.ReadLine());

            double cookiePrice = 1.50;
            double cakePrice = 7.80;
            double wafflePrice = 2.30;

            int totalCookies = 0;
            int totalCakes = 0;
            int totalWaffles = 0;

            for (int i = 1; i <= participantsNumber; i++)
            {
                string participantName = Console.ReadLine();
                string sweetsType = Console.ReadLine();

                int participantCookies = 0;
                int participantCakes = 0;
                int participantWaffles = 0;

                while (sweetsType != "Stop baking!")
                {
                    int sweetsNumber = int.Parse(Console.ReadLine());

                    switch (sweetsType)
                    {
                        case "cookies":
                            participantCookies += sweetsNumber;
                            totalCookies += sweetsNumber;
                            break;

                        case "cakes":
                            participantCakes += sweetsNumber;
                            totalCakes += sweetsNumber;
                            break;

                        case "waffles":
                            participantWaffles += sweetsNumber;
                            totalWaffles += sweetsNumber;
                            break;
                    }

                    sweetsType = Console.ReadLine();
                }

                Console.WriteLine($"{participantName} baked {participantCookies} cookies, {participantCakes} cakes and {participantWaffles} waffles.");

            }

            int totalSweets = totalCookies + totalCakes + totalWaffles;
            double totalSum = (totalCookies * cookiePrice) + (totalCakes * cakePrice) + (totalWaffles * wafflePrice);

            Console.WriteLine($"All bakery sold: {totalSweets}");
            Console.WriteLine($"Total sum for charity: {totalSum:f2} lv.");

        }
    }
}
