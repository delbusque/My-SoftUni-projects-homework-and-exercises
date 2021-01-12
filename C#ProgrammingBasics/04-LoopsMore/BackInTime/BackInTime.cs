using System;

namespace BackInTime
{
    class BackInTime
    {
        static void Main(string[] args)
        {
            double sumHeritage = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            double sumEvenYears = 0;
            double sumOddYears = 0;
            int birthday = 18-1;

            for (int i = 1800; i <= year; i++)
            {  
                
                if (i % 2 == 0)
                {
                    sumEvenYears += 12000.00;
                }

                else
                {                    
                    birthday += 2;
                    sumOddYears += 12000.00 + (birthday * 50.00);
                }
            }

            double sum = sumEvenYears + sumOddYears;

            if (sum <= sumHeritage)
            {
                double more = sumHeritage - sum;
                Console.WriteLine($"Yes! He will live a carefree life and will have {more:f2} dollars left."); 
            }
            else
            {
                double more = sum - sumHeritage;
                Console.WriteLine($"He will need {more:f2} dollars to survive.");
            }
        }
    }
}
