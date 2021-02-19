using System;
using System.Globalization;

namespace OddEvenPossition
{
    class OddEvenPossition
    {
        static void Main(string[] args)
        { 
        
            int num = int.Parse(Console.ReadLine());
            
            double maxEvens = double.MinValue; 
            double maxOdds = double.MinValue;

            double minEvens = double.MaxValue;
            double minOdds = double.MaxValue;

            double sumOdds = 0;
            double sumEvens = 0;

            for (int i = 1; i <= num; i++)
            {
                double currentNum = double.Parse(Console.ReadLine());

                if (i % 2 == 0 )
                {
                    if (currentNum > maxEvens)
                    {
                        maxEvens = currentNum;
                    }

                    if (currentNum < minEvens)
                    {
                        minEvens = currentNum;
                    }

                    sumEvens += currentNum;
                }

                else
                {
                    if (currentNum > maxOdds)
                    {
                        maxOdds = currentNum; 
                    }
                   
                    if (currentNum < minOdds)
                    {
                        minOdds = currentNum;
                    }

                    sumOdds += currentNum;
                }
            }

            Console.WriteLine($"OddSum={sumOdds:f2},");
            if (minOdds == double.MaxValue)
            {
                Console.WriteLine($"OddMin=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={minOdds:f2},");
            }

            if (maxOdds == double.MinValue)
            {
                Console.WriteLine($"OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMax={maxOdds:f2},");
            }



            Console.WriteLine($"EvenSum={sumEvens:f2},");
            if (minEvens == double.MaxValue)
            {
                Console.WriteLine($"EvenMin=No,");
            }
            else
            {
                Console.WriteLine($"EvenMin={minEvens:f2},");
            }

            if (maxEvens == double.MinValue)
            {
                Console.WriteLine($"EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMax={maxEvens:f2}");
            }


        }
    }
}
