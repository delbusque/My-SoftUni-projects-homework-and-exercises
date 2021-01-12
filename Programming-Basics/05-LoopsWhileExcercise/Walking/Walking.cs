using System;

namespace Walking
{
    class Walking
    {
        static void Main(string[] args)
        {
            string steps = Console.ReadLine();
            int stepsCount = 0;

            while (steps != "Going home")
            {

                steps = Console.ReadLine(); 
                int stepsCurrent = int.Parse(steps);
                stepsCount += stepsCurrent;

                if (stepsCount >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    break;
                }

                else
                {
                    continue;
                }
            }
            
            if (steps == "Going home")
            {
                int stepsToHome = int.Parse(Console.ReadLine());
                int more = 10000 - (stepsCount + stepsToHome);
                Console.WriteLine($"{more} more steps to reach goal.");
                
            }

        }
    }
}
