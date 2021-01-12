using System;
using System.Numerics;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger yield = BigInteger.Parse(Console.ReadLine());
           
            BigInteger days = 0;
            BigInteger allSpice = 0;

            if (yield < 100)
            {
                Console.WriteLine(days);
                Console.WriteLine(allSpice);
            }

            else
            {
                while (yield >= 100)
                {
                    allSpice += yield - 26;                    
                    yield -= 10;
                    days++;
                }
                allSpice -= 26;

                Console.WriteLine(days);
                Console.WriteLine(allSpice);
            }
 
            
        }
    }
}
