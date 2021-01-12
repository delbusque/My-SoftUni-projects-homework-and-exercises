using System;

namespace MidExamPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            byte employeeOneHourly = byte.Parse(Console.ReadLine());
            byte employeeTwoHourly = byte.Parse(Console.ReadLine());
            byte employeeThreeHourly = byte.Parse(Console.ReadLine());            
            short totalPerHour = (short)(employeeOneHourly + employeeTwoHourly + employeeThreeHourly);

            short neededHours = 0;
            short hoursCount = 0;

            short totalPeople = short.Parse(Console.ReadLine());                    
            short servicedPeople = 0;

            if (totalPeople <= servicedPeople)
            {
                Console.WriteLine("Time needed: 1h.");
            }
            
            else
            {
                while (totalPeople > servicedPeople)
                {
                    hoursCount++;

                    if (hoursCount % 4 == 0)
                    {
                        neededHours++;
                    }

                    else
                    {
                        servicedPeople += totalPerHour;
                        neededHours++;
                    }
                }

                Console.WriteLine($"Time needed: {neededHours}h.");
            }
        }
    }
}
