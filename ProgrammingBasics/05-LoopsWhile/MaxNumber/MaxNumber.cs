using System;

namespace MaxNumber
{
    class MaxNumber
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int maxCurrent = int.MinValue;
            int i = 1;

            while (i <= count)
            {
                int current = int.Parse(Console.ReadLine());
               
                if (current >= maxCurrent)
                {
                    maxCurrent = current;
                }

                i++;
            }

            Console.WriteLine(maxCurrent);
        }
    }
}
