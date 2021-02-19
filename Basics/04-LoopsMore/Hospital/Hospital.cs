using System;

namespace Hospital
{
    class Hospital
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            int doctors = 7;
            int examinedPatients = 0;
            int nonExaminedPatients = 0;

            for (int i = 1; i <= days; i++)
            {

                if (i % 3 == 0)
                {
                    if (nonExaminedPatients > examinedPatients)
                    {
                        doctors += 1;
                    }

                }

                int patients = int.Parse(Console.ReadLine());

                if (patients > doctors)
                {
                    examinedPatients += doctors;
                    nonExaminedPatients += patients - doctors;
                }
                else
                {
                    examinedPatients += patients;
              
                }           
            }   

            Console.WriteLine($"Treated patients: {examinedPatients}.");
            Console.WriteLine($"Untreated patients: {nonExaminedPatients}.");
        }
    }
}
