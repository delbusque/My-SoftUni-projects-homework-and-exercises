using System;

namespace Journey
{
    class Journey
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double price = 0;
            string destination = "";
            string type = "";

            if (budget <= 100)
            {
                destination = "Bulgaria";

                switch (season)
                {
                    case "summer":
                        type = "Camp";
                        price = budget * 0.30;
                        break;
                    case "winter":
                        type = "Hotel";
                        price = budget * 0.70;
                        break;
                }
            }

            else if (budget <= 1000)
            {
                destination = "Balkans";

                switch (season)
                {
                    case "summer":
                        type = "Camp";
                        price = budget * 0.40;
                        break;
                    case "winter":
                        type = "Hotel";
                        price = budget * 0.80;
                        break;
                }
            }

            else if (budget > 1000)
            {
                destination = "Europe";

                switch (season)
                {
                    case "summer":     
                    case "winter":
                        type = "Hotel";
                        price = budget * 0.90;
                        break;
                }
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{type} - {price:f2}");

        }
    }
}
