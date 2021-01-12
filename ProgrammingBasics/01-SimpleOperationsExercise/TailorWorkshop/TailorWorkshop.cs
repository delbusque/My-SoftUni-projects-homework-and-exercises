using System;

namespace TailorWorkshop
{
    class TailorWorkshop
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double coverArea = (lenght + 2 * 0.30) * (width + 2 * 0.30);
            double coverSquareArea = (lenght / 2) * (lenght / 2);

            double coverAreaPrice = 7.00;
            double coverSquareAreaPrice = 9.00;

            double priceCoversUsd = coverArea * coverAreaPrice * count;
            double priceSquareCoversUsd = coverSquareArea * coverSquareAreaPrice * count;

            double priceUsd = priceCoversUsd + priceSquareCoversUsd;
            double UsdToBgn = 1.85;
            double priceBgn = priceUsd * UsdToBgn;

            Console.WriteLine($"{priceUsd:f2} USD");
            Console.WriteLine($"{priceBgn:f2} BGN");
        }
    }
}
