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
            //double pricePresidentApartment = 0;
            //double priceApartment = 0;

            int nights = days - 1;
            if (days == 0)
            {
                nights = 0;
            }

            if (days < 10)
            {
                if (roomType == "room for one person")
                {
                    price = nights * 18.00;
                }
                else if (roomType == "apartment")
                {
                    price = nights * 25.00 * 0.70;
                }
                else if (roomType == "president apartment")
                {
                    price = nights * 35.00 * 0.90;
                }

            }

            if (10 <= days && days <= 15)
            {
                if (roomType == "room for one person")
                {
                    price = nights * 18.00;
                }
                else if (roomType == "apartment")
                {
                    price = nights * 25.00 * 0.65;
                }
                else if (roomType == "president apartment")
                {
                    price = nights * 35.00 * 0.85;
                }

            }

            if (days > 15)
            {
                if (roomType == "room for one person")
                {
                    price = nights * 18.00;
                }
                else if (roomType == "apartment")
                {
                    price = nights * 25.00 * 0.50;
                }
                else if (roomType == "president apartment")
                {
                    price = nights * 35.00 * 0.80;
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
