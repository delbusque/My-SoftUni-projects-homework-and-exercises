using System;

namespace SkiTrip
{
    class SkiTrip
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string feedback = Console.ReadLine();

            double price = 0;
            int nights = days - 1;
            if (days == 0)
            {
                nights = 0;
            }

           if (days < 10)
            {
                switch (roomType)
                {
                    case "room for one person":
                        price = nights * 18.00;
                        break;

                    case "apartment":
                        price = nights * 25.00 * 0.70;
                        break;

                    case "president apartment":
                        price = nights * 35.00 * 0.90;
                        break;
                }
            }

            else if (days >= 10 && days <= 15)
            {
                switch (roomType)
                {
                    case "room for one person":
                        price = nights * 18.00;
                        break;

                    case "apartment":
                        price = nights * 25.00 * 0.65;
                        break;

                    case "president apartment":
                        price = nights * 35.00 * 0.85;
                        break;
                }
            }

            else if (days > 15)
            {
                switch (roomType)
                {
                    case "room for one person":
                        price = nights * 18.00;
                        break;

                    case "apartment":
                        price = nights * 25.00 * 0.50;
                        break;

                    case "president apartment":
                        price = nights * 35.00 * 0.80;
                        break;
                }
            }

            if (feedback == "positive")
            {
                price *= 1.25;
            }
           else if (feedback == "negative")
            {
                price *= 0.90;
            }

            Console.WriteLine($"{price:f2}");

        }
    }
}
