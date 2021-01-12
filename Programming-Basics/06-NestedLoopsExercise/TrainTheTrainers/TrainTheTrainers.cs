using System;

namespace TrainTheTrainers
{
    class TrainTheTrainers
    {
        static void Main(string[] args)
        {
            double marks = double.Parse(Console.ReadLine());

            string project = Console.ReadLine();

            double finalAssessmentSum = 0;
            int presentations = 0;

            while (project != "Finish")
            {
                presentations++;
                double currentSum = 0;

                for (int j = 1; j <= marks; j++)
                {
                    double currentMark = double.Parse(Console.ReadLine());
                    currentSum += currentMark;                  
                }
                Console.WriteLine($"{project} - {currentSum / marks:f2}.");

                finalAssessmentSum += currentSum / marks;

                project = Console.ReadLine();
            }

            double finalAssesstment = finalAssessmentSum / presentations;

            Console.WriteLine($"Student's final assessment is {finalAssesstment:f2}.");
        }
    }
}
