using System;
using System.Text;
using System.Linq;

namespace _02.AsciiSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            string line = Console.ReadLine();
            char[] charLine = line.ToCharArray();

            int sum = 0;

            foreach (var ch in charLine)
            {
                if (ch > start && ch < end || ch < start && ch > end)
                {
                    sum += ch;
                }
            }

            Console.WriteLine(sum);


        }
    }
}
