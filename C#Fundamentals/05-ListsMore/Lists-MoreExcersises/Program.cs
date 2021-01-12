using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists_MoreExcersises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] raceLine = Console.ReadLine().Split().Select(int.Parse).ToArray();

            

            double sumRacerOne = 0;
            double sumRacerTwo = 0;


            for (int i = 0; i < raceLine.Length / 2 ; i++)
            {
                

                sumRacerOne += raceLine[i];

                if (raceLine[i] == 0)
                {
                    sumRacerOne *= 0.8;
                }
                           
            }

            for (int i = raceLine.Length - 1; i > raceLine.Length / 2; i--)
            {

                sumRacerTwo += raceLine[i];

                if (raceLine[i] == 0)
                {
                    sumRacerTwo *= 0.8;
                }
            }

            if (sumRacerOne < sumRacerTwo)
            {
                Console.WriteLine($"The winner is left with total time: {sumRacerOne:f1}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {sumRacerTwo:f1}");
            }


        }
    }
}
