using System;

namespace VegetabeMarket
{
    class VegetabeMarket
    {
        static void Main(string[] args)
        {
            double VegPriceKg = double.Parse(Console.ReadLine());
            double FruiPriceKg = double.Parse(Console.ReadLine());
            double VegKg = double.Parse(Console.ReadLine());
            double FruiKg = double.Parse(Console.ReadLine());

            double euro = 1.94;

            double income = ((VegKg * VegPriceKg) + (FruiKg * FruiPriceKg)) / euro;
            Console.WriteLine($"{income:f2}"); 
        }
    }
}
