using System;

namespace _08.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double result = ResultToPower(number, power);
            Console.WriteLine(result);
        }

        static double ResultToPower(double number, int power)
        {
            double result = number;
            double newResult = 0;

            for (int i = 1; i < power; i++)
            {               
                result *= number;
                newResult = result;
            }

            return newResult;
        }
    }
}
