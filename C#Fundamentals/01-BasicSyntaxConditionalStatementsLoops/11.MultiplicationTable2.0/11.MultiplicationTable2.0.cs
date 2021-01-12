using System;

namespace _11.MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int start = int.Parse(Console.ReadLine());

            int sum = 0;

            do
            {
                sum = n * start;

                Console.WriteLine($"{n} X {start} = {sum}");

                start++;


            } while (start <= 10);
        }
    }
}
