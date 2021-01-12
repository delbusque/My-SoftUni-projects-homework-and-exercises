using System;
using System.Data;

namespace Walking2
{
    class Walking2
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int stepsGoal = 10000;
            int stepsCount = 0;

            while (stepsCount < 10000)
            {
                if (command == "Going home")
                {
                    int stepsToHome = int.Parse(Console.ReadLine());

                    if (stepsGoal > stepsCount + stepsToHome)
                    {
                        int more = 10000 - (stepsCount + stepsToHome);
                        Console.WriteLine($"{more} more steps to reach goal.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        break;
                    }
                    
                }
                
                int currentSteps = int.Parse(command);
                stepsCount += currentSteps;

                if (stepsCount >= stepsGoal)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    break;
                }

                command = Console.ReadLine();
            }   
        }
    }
}
