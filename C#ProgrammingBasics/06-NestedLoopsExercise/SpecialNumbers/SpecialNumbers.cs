using System;

namespace SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int d1 = 1; d1 <= 9; d1++)
            {
                if (n % d1 != 0)
                {
                    continue;
                }
                
                for (int d2 = 0; d2 <= 9; d2++)
                {
                    if (d2 == 0 || n % d2 != 0)
                    {
                        continue;
                    }

                    for (int d3 = 0; d3 <= 9; d3++)
                    {

                        if (d3 == 0 || n % d3 != 0)
                        {
                            continue;
                        }

                        for (int d4 = 0; d4 <= 9; d4++)
                        {
                            if (d4 == 0 || n % d4 != 0)
                            {
                                continue;
                            }
                            else
                            {
                                Console.Write($"{d1}{d2}{d3}{d4} ");
                            }
                        }
                    }
                }

            }

        }
    }
}
