using System;

namespace InvalidNumber
{
    class InvalidNumber
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            if (100 <= num && num <= 200 || num == 0)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
