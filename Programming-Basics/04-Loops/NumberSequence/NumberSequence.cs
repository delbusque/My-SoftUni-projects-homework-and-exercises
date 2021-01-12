using System;
using System.ComponentModel.DataAnnotations;

namespace NumberSequence
{
    class NumberSequence
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int maxNumb = int.MinValue;
            int minNumb = int.MaxValue;

            for (int i = 0; i < count; i++)
            {
                int inputNum = int.Parse(Console.ReadLine());
              
                if (inputNum > maxNumb)
                {
                    maxNumb = inputNum;
                }

                if (inputNum < minNumb)
                {
                    minNumb = inputNum;
                }
            }

            Console.WriteLine($"Max number:{maxNumb}");
            Console.WriteLine($"Min number:{minNumb}");

        }
    }
}
