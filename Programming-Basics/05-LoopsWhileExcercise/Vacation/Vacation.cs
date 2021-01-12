using System;

namespace Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            double holidayPrice = double.Parse(Console.ReadLine());
            double accountMoney = double.Parse(Console.ReadLine());
            int spendCount = 0;
            int daysCount = 0;
          

            while (accountMoney < holidayPrice && spendCount < 5)
            {
                string operation = Console.ReadLine();
                double amount = double.Parse(Console.ReadLine());
                daysCount++;

                if (operation == "spend")
                {
                    spendCount++;
                    accountMoney -= amount;

                    if (accountMoney < 0)
                    {
                        accountMoney = 0;
                    }
                }

                else if (operation == "save")
                {
                    spendCount = 0;                   
                    accountMoney += amount;
                }                
            }

            if (accountMoney >= holidayPrice)
            {
                Console.WriteLine($"You saved the money for {daysCount} days.");
            }

            if (spendCount == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysCount);
            }
        }
    }
}
