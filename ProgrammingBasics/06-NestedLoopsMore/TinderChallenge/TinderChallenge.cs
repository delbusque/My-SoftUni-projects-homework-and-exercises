using System;

namespace TinderChallenge
{
    class TinderChallenge
    {
        static void Main(string[] args)
        {
            int men = int.Parse(Console.ReadLine());
            int women = int.Parse(Console.ReadLine());
            int tables = int.Parse(Console.ReadLine());
           
            double fullTables = 0;

            for (int i = 1; i <= men; i++)
            {
                for (int j = 1; j <= women; j++)
                {

                    fullTables++;

                    if (tables >= fullTables)
                    {
                        Console.Write($"({i} <-> {j}) ");
                    }

                    else
                    {
                        break;
                    }

                }

                if (tables <= fullTables)
                {
                    break;
                }
            }
        }
    }
}
