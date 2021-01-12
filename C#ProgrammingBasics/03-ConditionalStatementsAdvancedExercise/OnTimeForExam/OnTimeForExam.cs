using System;

namespace OnTimeForExam
{
    class OnTimeForExam
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minutesExam = int.Parse(Console.ReadLine());
            int hourArrival = int.Parse(Console.ReadLine());
            int minutesArrival = int.Parse(Console.ReadLine());

            minutesExam += hourExam * 60;
            minutesArrival += hourArrival * 60;

            if (minutesArrival > minutesExam)
            {
                int more = minutesArrival - minutesExam;
                Console.WriteLine("Late");
                if (more < 60)
                {
                    Console.WriteLine($"{more} minutes after the start");
                }

                else
                {
                    int hour = more / 60;
                    int minutes = more % 60;
                    Console.WriteLine($"{hour}:{minutes:d2} hours after the start");
                }

            }

            else if (minutesArrival < minutesExam - 30)
            {
                int more = minutesExam - minutesArrival;
                Console.WriteLine("Early");
                if (more < 60)
                {
                    Console.WriteLine($"{more} minutes before the start");
                }

                else
                {
                    int hour = more / 60;
                    int minutes = more % 60;
                    Console.WriteLine($"{hour}:{minutes:d2} hours before the start");
                }
            }

            else
            {
                Console.WriteLine("On time");
                int more = minutesExam - minutesArrival;
                Console.WriteLine($"{more} minutes before the start");
            }

        }
    }
}
