using System;

namespace Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            double sofiaHolidays = double.Parse(Console.ReadLine());
            double homeTownWeekends = double.Parse(Console.ReadLine());
            
            double sofiaPlay = (48 - homeTownWeekends) * 3 / 4;
            double sofiaPlayHolidays = sofiaHolidays * 2 / 3;
            double homeTownPlay = homeTownWeekends;

            double play = sofiaPlay + sofiaPlayHolidays + homeTownPlay;
            
           if (year == "normal")
            {
                Console.WriteLine(Math.Floor(play));
            }

           else if (year == "leap")
            {
                Console.WriteLine(Math.Floor(play * 1.15));
            }
  
        }
    }
}
