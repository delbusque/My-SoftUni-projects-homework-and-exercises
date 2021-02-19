using System;

namespace _10.RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());           

            double headset = double.Parse(Console.ReadLine());
            double mouse = double.Parse(Console.ReadLine());
            double keyboard = double.Parse(Console.ReadLine());
            double display = double.Parse(Console.ReadLine());

            double sum = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    sum += headset;
                }
                if (i % 3 == 0)
                {
                    sum += mouse;
                }
                if (i % 6 == 0)
                {
                    sum += keyboard;
                }
                if (i % 12 == 0)
                {
                    sum += display;
                }

            }

            Console.WriteLine($"Rage expenses: {sum:f2} lv.");

        }
    }
}
