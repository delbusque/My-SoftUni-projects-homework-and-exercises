using System;

namespace BeehivePopulation
{
    class BeehivePopulation
    {
        static void Main(string[] args)
        {
            int startPopulation = int.Parse(Console.ReadLine());
            int years = int.Parse(Console.ReadLine());

            int currentPopulation = startPopulation;

            for (int i = 1; i <= years; i++)
            {
                if (i % 5 == 0)
                {
                    int tensPop = currentPopulation / 10;
                    currentPopulation += tensPop * 2;

                    int fiftysPop = currentPopulation / 50;
                    currentPopulation -= fiftysPop * 5;

                    int twentysPop = currentPopulation / 20;
                    currentPopulation -= twentysPop * 2;
                }

                else
                {
                    int tensPop = currentPopulation / 10;
                    currentPopulation += tensPop * 2;

                    int twentysPop = currentPopulation / 20;
                    currentPopulation -= twentysPop * 2;
                }
            }

            Console.WriteLine($"Beehive population: {currentPopulation}");
        }
    }
}