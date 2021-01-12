using System;

namespace ExamPreparation
{
    class ExamPreparation
    {
        static void Main(string[] args)
        {
            int lowMarks = int.Parse(Console.ReadLine());
            int allMarks = 0;
            int countMarks = 0;
            int countLowMarks = 0;
           
            string lastProblem = "";

            string problem = Console.ReadLine();

            while (problem != "Enough")
            {
                lastProblem = problem;
                int mark = int.Parse(Console.ReadLine());
          
                countMarks++;
                allMarks += mark;

                if (mark <= 4)
                {
                    countLowMarks++;
                }       

                if (countLowMarks >= lowMarks)
                {
                    break;             
                }
                
                problem = Console.ReadLine();               
            }

            if (countLowMarks >= lowMarks)
            {
                Console.WriteLine($"You need a break, {countLowMarks} poor grades.");

                // Console.WriteLine($"You need a break, {countLowMarks} poor grades.");
                // Environment.Exit(0); 
            }

            else
            {
                double average = 1.00 * allMarks / countMarks;

                Console.WriteLine($"Average score: {average:f2}");
                Console.WriteLine($"Number of problems: {countMarks}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
            
        }
    }
}            
              
