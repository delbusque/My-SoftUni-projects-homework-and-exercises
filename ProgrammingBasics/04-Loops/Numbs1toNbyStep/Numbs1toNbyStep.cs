using System;

namespace Numbs1toNbyStep
{
    class Numbs1toNbyStep
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i=i+3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
