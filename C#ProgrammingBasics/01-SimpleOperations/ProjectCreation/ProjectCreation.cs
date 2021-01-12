using System;

namespace ProjectCreation
{
    class ProjectCreation
    {
        static void Main(string[] args)
        {
            string archName = Console.ReadLine();
            int projCount = int.Parse(Console.ReadLine());

            int projHours = projCount * 3;

            Console.WriteLine($"The architect {archName} will need {projHours} hours to complete {projCount} project/s.");
        }
    }
}
