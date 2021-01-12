using System;

namespace AccountBallance
{
    class AccountBalance
    {
        static void Main(string[] args)
        {
            int numberInstalments = int.Parse(Console.ReadLine());
            int i = 1;
            double totalSum = 0;
            double paymentSum = 0;

            while (i <= numberInstalments)
            {
                paymentSum = double.Parse(Console.ReadLine());

                if (paymentSum < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                else
                {
                    totalSum += paymentSum;
                    i++;
                    Console.WriteLine($"Increase: {paymentSum:f2}");
                }
            }
            Console.WriteLine($"Total: {totalSum:f2}");
        }
    }
}