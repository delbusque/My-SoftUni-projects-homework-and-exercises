using System;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int yield = startingYield;
            int days = 0;
            int allSpice = 0;

            if (yield < 100)
            {
                Console.WriteLine(days);
                Console.WriteLine(allSpice);
            }

            else
            {
                do
                {
                    days++;
                    int spice = yield - 26;
                    allSpice += spice;
                    yield -= 10;

                } while (yield >= 100);

                allSpice -= 26;

                Console.WriteLine(days);
                Console.WriteLine(allSpice);
            }
        }
    }
}