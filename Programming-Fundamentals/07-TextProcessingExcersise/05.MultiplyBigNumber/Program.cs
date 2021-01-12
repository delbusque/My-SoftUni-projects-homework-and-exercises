using System;
using System.Text;
using System.Linq;
using System.Numerics;

namespace _05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            int digit = int.Parse(Console.ReadLine());

            BigInteger conv = BigInteger.Parse(bigNumber);
            Console.WriteLine(conv * digit);


        }
    }
}
