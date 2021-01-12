using System;

namespace Sequence2plus1
{
    class Sequence2plus1
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 1;

            while (i <= n)
            {
                Console.WriteLine(i);
                i = i * 2 + 1;
            }
        }
    }
}