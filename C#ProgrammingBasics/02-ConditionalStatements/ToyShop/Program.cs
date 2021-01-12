using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());
            int allToys = puzzles + dolls + bears + minions + trucks;

            double puzzlesPrice = puzzles * 2.60;
            double dollsPrice = dolls * 3.00;
            double bearsPrice = bears * 4.10;
            double minionsPrice = minions * 8.20;
            double trucksPrice = trucks * 2;
            double allToysPrice = puzzlesPrice + dollsPrice + bearsPrice + minionsPrice + trucksPrice;

            if (allToys >= 50)
            {
                allToysPrice = allToysPrice * 0.75;
            }
                       
            allToysPrice *= 0.90;

            if (allToysPrice >= tripPrice)
            {
                double leftMoney = allToysPrice - tripPrice;
                Console.WriteLine($"Yes! {leftMoney:f2} lv left.");
            }
            else
            {
                double missingMoney = tripPrice - allToysPrice;
                Console.WriteLine($"Not enough money! {missingMoney:f2} lv needed.");
            }

        }
    }
}
