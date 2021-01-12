using System;

namespace ReportSystem
{
    class ReportSystem
    {
        static void Main(string[] args)
        {
            double target = double.Parse(Console.ReadLine());

            string currentGood = Console.ReadLine();
            
            double counterTargetCash = 0;
            double counterTargetCard = 0;

            double counterTarget = 0;

            double counterPaymentsCash = 0;
            double counterPaymentsCard = 0;

            int oddEvenCounter = 1;

            while (currentGood != "End")
            {
                double current = double.Parse(currentGood);

                if (oddEvenCounter % 2 != 0)
                {
                    if (current > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        counterTargetCash += current;
                        counterPaymentsCash++;
                    }
                }

                else
                {
                    if (current < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }

                    else
                    {
                        Console.WriteLine("Product sold!");
                        counterTargetCard += current;
                        counterPaymentsCard++;
                    }
                }

                counterTarget = counterTargetCash + counterTargetCard;

                if (counterTarget >= target)
                {
                    break;
                }

                oddEvenCounter++;
                currentGood = Console.ReadLine();
            }

            if (counterTarget >= target)
            {
                Console.WriteLine($"Average CS: {counterTargetCash / counterPaymentsCash:f2}");
                Console.WriteLine($"Average CC: {counterTargetCard / counterPaymentsCard:f2}");
            }
            else
            {
                Console.WriteLine($"Failed to collect required money for charity.");
            }
        }
    }
}
