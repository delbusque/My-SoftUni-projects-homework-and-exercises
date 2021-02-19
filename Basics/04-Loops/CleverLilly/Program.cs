using System;

namespace CleverLilly
{
    class Program
    {
        static void Main(string[] args)
        {
            int years = int.Parse(Console.ReadLine());
            double mashinePrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());

            double savings = 0;
            double toyCount = 0;
            double moneyCount = 0;

            for (int i = 1; i <= years; i++)
            {

                if (i % 2 == 0)
                {
                    moneyCount = moneyCount + 10; 
                    savings = savings + (moneyCount - 1);
                    
                }

                else
                {
                    toyCount = toyCount + 1;
                }    
                
            }

            savings = savings + (toyCount * toyPrice);
           
            if (savings >= mashinePrice)
            {
                double more = savings - mashinePrice;
                Console.WriteLine($"Yes! {more:f2}");
            }
            else
            {
                double more = mashinePrice - savings;
                Console.WriteLine($"No! {more:f2}");
            }


        }
    }
}
