using System;

namespace FootballFans
{
    class FootballFans
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            int fans = int.Parse(Console.ReadLine());

            int countA = 0;
            int countB = 0;
            int countV = 0;
            int countG = 0;

            for (int i = 0; i < fans; i++)
            {
                string sector = Console.ReadLine();

                switch (sector)
                {
                    case "A":
                        countA ++;
                        break;

                    case "B":
                        countB++;
                        break;

                    case "V":
                        countV++;
                        break;

                    case "G":
                        countG++;
                        break;
                }
            }

            int totalcount = countA + countB + countG + countV;

            Console.WriteLine($"{100.00 * countA / fans:f2}%");
            Console.WriteLine($"{100.00 * countB / fans:f2}%");
            Console.WriteLine($"{100.00 * countV / fans:f2}%");
            Console.WriteLine($"{100.00 * countG / fans:f2}%");
            Console.WriteLine($"{100.00 * fans / capacity:f2}%");

        }
    }
}
