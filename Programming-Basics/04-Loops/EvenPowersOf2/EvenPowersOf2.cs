using System;

namespace EvenPowersOf2
{
    class EvenPowersOf2
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i <= count; i += 2)
            {           
                    double result = Math.Pow(2, i);
                    Console.WriteLine(result);            
            }
        }
    }
}
