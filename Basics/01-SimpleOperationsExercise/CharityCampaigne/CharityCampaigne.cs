using System;

namespace CharityCampaigne
{
    class CharityCampaigne
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            int cooks = int.Parse(Console.ReadLine());
            int cakesPerCookPerDay = int.Parse(Console.ReadLine());
            int wafflesPerCookPerDay = int.Parse(Console.ReadLine());
            int pancakesPerCookPerDay = int.Parse(Console.ReadLine());

            double cakePrice = 45.00;
            double wafflePrice = 5.80;
            double pancakePrice = 3.20;

            double wholeSum = ((cakesPerCookPerDay * cakePrice) + (wafflesPerCookPerDay * wafflePrice) + (pancakesPerCookPerDay * pancakePrice)) * days * cooks;
            double goodsExpenses = wholeSum / 8;
            double charitySum = wholeSum - goodsExpenses;

            Console.WriteLine($"{charitySum:f2}");
        }
    }
}
