using System;

namespace CelciusToFarenh
{
    class CelciusToFarenh
    {
        static void Main(string[] args)
        {
            // (°F − 32) × 5/9 = °C

            double celcius = double.Parse(Console.ReadLine());

            double farenheid = (celcius * 1.8000) + 32.00;
            Console.WriteLine($"{farenheid:f2}");

        }
    }
}
