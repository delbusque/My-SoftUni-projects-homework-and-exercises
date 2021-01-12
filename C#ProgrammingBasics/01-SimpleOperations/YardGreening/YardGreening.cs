using System;

namespace YardGreening
{
    class YardGreening
    {
        static void Main()
        {
            double areaUnits = double.Parse(Console.ReadLine());
            double unitPrice = 7.61;
            double finalPrice = areaUnits * unitPrice;
            double discount = 0.18 * finalPrice;
            double finalPriceWithDiscount = finalPrice - discount;


            Console.WriteLine($"The final price is: {finalPriceWithDiscount.ToString("F")} lv.");
            Console.WriteLine($"The discount is: {discount.ToString("F")} lv.");

        
        }
    }
}
