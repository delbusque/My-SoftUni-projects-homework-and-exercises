using System;

namespace Dishwasher
{
    class Dishwasher
    {
        static void Main(string[] args)
        {
            int bottles = int.Parse(Console.ReadLine());

            int detergent = bottles * 750;
            int plates = 0;
            int pots = 0;
            int commandCount = 0;

            string command = Console.ReadLine();          

            while (command != "End")
            {
                commandCount++;

                int dishes = int.Parse(command);

                if (commandCount % 3 == 0)
                {
                    pots += dishes;                  
                }
                else
                {
                    plates += dishes;
                }

                int detergentDishesIn = (plates * 5) + (pots * 15);
                int moreDetergentIn = detergentDishesIn - detergent;

                if (detergent < detergentDishesIn)
                {
                    Console.WriteLine($"Not enough detergent, {moreDetergentIn} ml. more necessary!");
                    Environment.Exit(0);
                }
                
                command = Console.ReadLine();
            }

            int detergentDishes = (plates * 5) + (pots * 15);
            int moreDetergent = detergent - detergentDishes;

            Console.WriteLine("Detergent was enough!");
            Console.WriteLine($"{plates} dishes and {pots} pots were washed.");
            Console.WriteLine($"Leftover detergent {moreDetergent} ml.");
        }
    }
}
