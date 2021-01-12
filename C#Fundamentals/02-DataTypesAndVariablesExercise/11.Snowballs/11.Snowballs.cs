using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace _11.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            BigInteger maxSnowValue = int.MinValue;

            int maxSnow = 0;
            int maxTime = 0;
            int maxQuality = 0;

            for (int i = 0; i < n; i++)
            {               
                short snowballSnow = short.Parse(Console.ReadLine());
                short snowballTime = short.Parse(Console.ReadLine());
                byte snowballQuality = byte.Parse(Console.ReadLine());

                BigInteger value = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

                if (value > maxSnowValue)
                {
                    maxSnowValue = value;
                    maxSnow = snowballSnow;
                    maxTime = snowballTime;
                    maxQuality = snowballQuality;
                }

            }

            Console.WriteLine($"{maxSnow} : {maxTime} = {maxSnowValue} ({maxQuality})");
        }
    }
}
