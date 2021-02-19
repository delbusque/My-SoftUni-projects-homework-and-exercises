using System;

namespace _10.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int currentN = n;

            int pokeCounter = 0;

            while (currentN >= m)
            {
                currentN -= m;
                pokeCounter++;

                if (currentN == n / 2 && y != 0)
                {
                    currentN /= y;
                }
                else
                {
                    continue;
                }

            }

            Console.WriteLine(currentN);
            Console.WriteLine(pokeCounter);
        }
    }
}
