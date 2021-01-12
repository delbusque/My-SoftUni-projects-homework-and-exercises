using System;
using System.Linq;

namespace Arrays_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] vagons = new int[n];
            int passengersCounter = 0;

            for (int i = 0; i < n; i++)

            {
                vagons[i] = int.Parse(Console.ReadLine());
                 
                passengersCounter += vagons[i];
            }

            Console.WriteLine(String.Join(" ", vagons));
            Console.WriteLine(passengersCounter);
        }
    }
}
