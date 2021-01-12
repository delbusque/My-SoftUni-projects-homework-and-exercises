using System;

namespace PinCodes
{
    class PinCodes
    {
        static void Main(string[] args)
        {
            int posOneLast = int.Parse(Console.ReadLine());
            int posTwoLast = int.Parse(Console.ReadLine());
            int posThreeLast = int.Parse(Console.ReadLine());

            for (int i = 0; i <= posOneLast; i++)
            {
                if (i % 2 != 0 || i == 0)
                {
                    continue;
                }

                for (int j = 2; j <= posTwoLast; j++)
                {
                    if (j % 2 == 0 && j != 2 || j > 7)
                    {
                        continue;
                    }

                    for (int k = 0; k <= posThreeLast; k++)
                    {
                        if (k % 2 != 0 || k == 0)
                        {
                            continue;
                        }

                        Console.WriteLine($"{i} {j} {k}");
                    }
                }
            }
        }
    }
}
