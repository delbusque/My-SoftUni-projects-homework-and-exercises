using System;

namespace BeehiveRole
{
    class BeehiveRole
    {
        static void Main(string[] args)
        {
            int intelligence = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
          
            if (intelligence >= 80 && power >= 80 && gender == "female")
            {
                Console.WriteLine("Queen Bee");
            }

            else if (intelligence >= 80)
            {
                Console.WriteLine("Repairing Bee");
            }

            else if (intelligence >= 60)
            {
                Console.WriteLine("Cleaning Bee");
            }

            else if (power >= 80 && gender == "male")
            {
                Console.WriteLine("Drone Bee");
            }

            else if (power >= 60)
            {
                Console.WriteLine("Guard Bee");
            }

            else
            {
                Console.WriteLine("Worker Bee");
            }
        }
    }
}
