using System;

namespace NumberInRange
{
    class NumberInRange
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (-100 <= num && num <= 100 && num != 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
