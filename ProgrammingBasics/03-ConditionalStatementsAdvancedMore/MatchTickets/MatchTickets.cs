using System;

namespace CSharp_Shell
{

    public static class MatchTickets
    {
        public static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int group = int.Parse(Console.ReadLine());

            double vipPrice = 499.99;
            double normalPrice = 249.99;

            double transport = 0;
            double ticketPrice = 0;
            double price = 0;

            switch (type)
            {
                case ("VIP"):

                    if (group <= 4)
                    {
                        transport = budget * 0.75;
                    }
                    else if (group <= 9)
                    {
                        transport = budget * 0.60;
                    }
                    else if (group <= 24)
                    {
                        transport = budget * 0.50;
                    }
                    else if (group <= 49)
                    {
                        transport = budget * 0.40;
                    }
                    else
                    {
                        transport = budget * 0.25;
                    }

                    ticketPrice = group * vipPrice;
                    price = transport + ticketPrice;
                    break;

                case ("Normal"):

                    if (group <= 4)
                    {
                        transport = budget * 0.75;
                    }
                    else if (group <= 9)
                    {
                        transport = budget * 0.60;
                    }
                    else if (group <= 24)
                    {
                        transport = budget * 0.50;
                    }
                    else if (group <= 49)
                    {
                        transport = budget * 0.40;
                    }
                    else
                    {
                        transport = budget * 0.25;
                    }

                    ticketPrice = group * normalPrice;
                    price = transport + ticketPrice;
                    break;
            }

            if (budget >= price)
            {
                double more = budget - price;
                Console.WriteLine($"Yes! You have {more:f2} leva left.");
            }
            else
            {
                double more = price - budget;
                Console.WriteLine($"Not enough money! You need {more:f2} leva.");
            }
        }
    }
}
