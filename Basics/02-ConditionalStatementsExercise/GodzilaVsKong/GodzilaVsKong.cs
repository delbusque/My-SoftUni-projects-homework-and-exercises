using System;

namespace GodzilaVsKong
{
    class GodzilaVsKong
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int eActorsCount = int.Parse(Console.ReadLine());
            double pricePerActor = double.Parse(Console.ReadLine());

            double decorPrice = budget * 0.10;
            double eActorsPrice = eActorsCount * pricePerActor;


            if (eActorsCount > 150)
            {
                eActorsPrice *= 0.90;

                double finalPrice = decorPrice + eActorsPrice;

                if (finalPrice <= budget)
                {
                    Console.WriteLine("Action!");
                    Console.WriteLine($"Wingard starts filming with {(budget - finalPrice):f2} leva left.");
                }
                else if (finalPrice > budget)
                {
                    Console.WriteLine("Not enough money!");
                    Console.WriteLine($"Wingard needs {(finalPrice - budget):f2} leva more.");
                }
            }

            else if (eActorsCount <= 150)
            {

                double finalPrice = decorPrice + eActorsPrice;

                if (finalPrice <= budget)
                {
                    Console.WriteLine("Action!");
                    Console.WriteLine($"Wingard starts filming with {(budget - finalPrice):f2} leva left.");
                }
                else if (finalPrice > budget)
                {
                    Console.WriteLine("Not enough money!");
                    Console.WriteLine($"Wingard needs {(finalPrice - budget):f2} leva more.");
                }
            }
        }
    }
}
