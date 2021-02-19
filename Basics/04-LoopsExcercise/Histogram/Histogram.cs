using System;

namespace Histogram
{
    class Histogram
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int gr1 = 0;
            int gr2 = 0;
            int gr3 = 0;
            int gr4 = 0;
            int gr5 = 0;

            for (int i = 0; i < n; i++)
            {
                int currentN = int.Parse(Console.ReadLine());

                if (currentN < 200)
                {
                    gr1 += 1;
                }

                else if (200 <= currentN && currentN < 400)
                {
                    gr2 += 1;
                }

                else if (400 <= currentN && currentN < 600)
                {
                    gr3 += 1;
                }

                else if (600 <= currentN && currentN < 800)
                {
                    gr4 += 1;
                }

                else if (currentN >= 800)
                {
                    gr5 += 1;
                }

            }

            Console.WriteLine($"{100.00 * gr1 / n:f2}%");
            Console.WriteLine($"{100.00 * gr2 / n:f2}%");
            Console.WriteLine($"{100.00 * gr3 / n:f2}%");
            Console.WriteLine($"{100.00 * gr4 / n:f2}%");
            Console.WriteLine($"{100.00 * gr5 / n:f2}%");
        }
    }
}
