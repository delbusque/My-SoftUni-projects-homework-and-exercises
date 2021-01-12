using System;

namespace SecretDoorLock
{
    class SecretDoorLock
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }
                
                for (int j = 2; j <= b; j++)
                {
                    if (j % 2 == 0 && j != 2 || j > 7)
                    {
                        continue;
                    }
                    
                    for (int k = 1; k <= c; k++)
                    {
                        if (k % 2 != 0)
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
