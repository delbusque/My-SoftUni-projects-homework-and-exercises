using System;

namespace PasswordGenerator
{
    class PasswordGenerator
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int ascii = 96;

            for (int i = 1; i <= n; i++)
            {
                for (int k = 1; k <= n; k++)
                {
                    for (char j = 'a'; j <= ascii + l; j++)
                    {
                        for (char o = 'a'; o <= ascii + l; o++)
                        {
                            for (int p = 1; p <= n; p++)
                            {
                                if (p > i && p > k)
                                {
                                    Console.Write($"{i}{k}{j}{o}{p} ");
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}
