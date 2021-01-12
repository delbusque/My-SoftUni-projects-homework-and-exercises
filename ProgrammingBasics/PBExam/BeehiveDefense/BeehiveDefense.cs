using System;

namespace BeehiveDefense
{
    class BeehiveDefense
    {
        static void Main(string[] args)
        {
            int bees = int.Parse(Console.ReadLine());
            int bearHealth = int.Parse(Console.ReadLine());
            int beesDownPerAttack = int.Parse(Console.ReadLine());

            while (bearHealth > 0)
            {
                bees -= beesDownPerAttack;
                
                if (bees < 100 && bees >= 0)
                {
                    Console.WriteLine($"The bear stole the honey! Bees left {bees}.");
                    Environment.Exit(0);
                }

                else if (bees < 0)
                {
                    bees = 0;
                    Console.WriteLine($"The bear stole the honey! Bees left {bees}.");
                    Environment.Exit(0);
                }

                bearHealth -= bees * 5;
            }

            Console.WriteLine($"Beehive won! Bees left {bees}.");          
        }
    }
}
