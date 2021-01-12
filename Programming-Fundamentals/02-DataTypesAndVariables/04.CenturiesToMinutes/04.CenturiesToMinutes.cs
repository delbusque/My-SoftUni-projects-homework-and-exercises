using System;
using System.Numerics;

namespace _04.CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            //years, days, hours and minutes

            int centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;
            ulong days = (ulong)(years * 365.2422);
            BigInteger hours = days * 24;
            BigInteger minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");

        }
    }
}
