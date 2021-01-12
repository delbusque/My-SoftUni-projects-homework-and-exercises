using System;

namespace Alcochol
{
    class Program
    {
        static void Main()
        {
            double whiskeyPricePerLiter = double.Parse(Console.ReadLine());
            double beerLiters = double.Parse(Console.ReadLine());
            double wineLiters = double.Parse(Console.ReadLine());
            double rakiaLiters = double.Parse(Console.ReadLine());
            double whiskeyLiters = double.Parse(Console.ReadLine());

            double rakiaPricePerLiter = whiskeyPricePerLiter / 2;
            double winePricePerLiter = rakiaPricePerLiter - (rakiaPricePerLiter * 0.4);
            double beerPricePerLiter = rakiaPricePerLiter - (rakiaPricePerLiter * 0.8);

            double partyPrice = (beerLiters * beerPricePerLiter) + (wineLiters * winePricePerLiter) + (rakiaLiters * rakiaPricePerLiter) + (whiskeyLiters * whiskeyPricePerLiter);

            Console.WriteLine($"{partyPrice:f2}");
        }
    }
}
