using System;

namespace PrimeNonPrime
{
    class PrimeNonPrime
    {
        static void Main(string[] args)
        {
            string enter = "";
            int primes = 0;
            int nonPrimes = 0;
            bool isPrime = true;

            while ((enter = Console.ReadLine()) != "stop")
            {
                int num = int.Parse(enter);
                isPrime = true;

                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }

                for (int i = 2; i <= Math.Sqrt(num); i++)
                {

                    if (num % i == 0)
                    {                       
                        nonPrimes += num;
                        isPrime = false;
                        break;
                    }                
                }

                if (isPrime)
                {
                    primes += num;

                }

            }

            Console.WriteLine($"Sum of all prime numbers is: {primes}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimes}");

        }
    }
}
