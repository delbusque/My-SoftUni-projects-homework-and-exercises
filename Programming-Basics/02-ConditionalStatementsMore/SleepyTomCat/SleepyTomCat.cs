using System;

namespace SleepyTomCat
{
    class SleepyTomCat
    {
        static void Main(string[] args)
        {
            int daysOff = int.Parse(Console.ReadLine());
            int daysAtWork = 365 - daysOff;
            int normMinutes = 30000;
            int gameOffMinutes = daysOff * 127;
            int gameDaysAtWorkMinutes = daysAtWork * 63;

            int allGameMinutes = gameDaysAtWorkMinutes + gameOffMinutes;

            if (allGameMinutes > normMinutes)
            {
                int extraHours = allGameMinutes - normMinutes;
                int hours = extraHours / 60;
                int min = extraHours % 60;

                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {min} minutes more for play");
            }

            else if (allGameMinutes <= normMinutes)
            {
                int neededHours = normMinutes - allGameMinutes;
                int hours = neededHours / 60;
                int min = neededHours % 60;

                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {min} minutes less for play");
            }
        }
    }
}
