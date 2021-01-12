using System;

namespace _07.TheatrePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayType = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());

            int price = 0;

            if (age >= 0 && age <= 18)
            {
                switch (dayType)
                {
                    case "weekday": price = 12; break;
                    case "weekend": price = 15; break;
                    case "holiday": price = 5; break;
                }

                Console.WriteLine("{0}$", price);
            }
            else if (age > 18 && age <= 64)
            {
                switch (dayType)
                {
                    case "weekday": price = 18; break;
                    case "weekend": price = 20; break;
                    case "holiday": price = 12; break;
                }

                Console.WriteLine("{0}$", price);
            }
            else if (age > 64 && age <= 122)
            {
                switch (dayType)
                {
                    case "weekday": price = 12; break;
                    case "weekend": price = 15; break;
                    case "holiday": price = 10; break;
                }

                Console.WriteLine("{0}$", price);
            }

            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
