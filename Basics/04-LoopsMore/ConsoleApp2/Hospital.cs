using System;

namespace ConsoleApp2
{
    class Hospital
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int doctors = 7;

            int examinedPatients = 0;
            int declinedPatients = 0;
            int dayCount = 0;

            for (int i = 1; i <= period; i++)
            {
                dayCount++;

                int currentPatients = int.Parse(Console.ReadLine());

                if (dayCount % 3 == 0)
                {
                    if (declinedPatients > examinedPatients)
                    {
                        doctors++;
                    }
                }

                if (currentPatients <= doctors)
                {
                    examinedPatients += currentPatients;
                }

                else
                {
                    examinedPatients += doctors;
                    declinedPatients += currentPatients - doctors;
                }          
            }
                Console.WriteLine($"Treated patients: {examinedPatients}.");
                Console.WriteLine($"Untreated patients: {declinedPatients}.");
        }
    }
}
