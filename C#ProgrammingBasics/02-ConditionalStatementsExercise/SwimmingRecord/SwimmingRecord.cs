using System;

namespace SwimmingRecord
{
    class SwimmingRecord
    {
        static void Main(string[] args)
        {
            double recordTime = double.Parse(Console.ReadLine());
            double distance= double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());

            double time = distance * timePerMeter;
            double extraTime = Math.Floor(distance / 15) * 12.5;
            double totalTime = time + extraTime;

            if (totalTime < recordTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else if (totalTime >= recordTime)
            {
                Console.WriteLine($"No, he failed! He was {(totalTime - recordTime):f2} seconds slower.");
            }
        }
    }
}
