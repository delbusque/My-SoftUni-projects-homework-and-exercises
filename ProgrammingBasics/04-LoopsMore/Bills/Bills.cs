using System;

namespace Bills
{
    class Bills
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());

            double water = 20;
            double internet = 15;
            double totalWater = water * months;
            double totalInternet = internet * months;

            double totalElectricity = 0;
            double totalOthers = 0;

            for (int i = 0; i < months; i++)
            {
                double electricity = double.Parse(Console.ReadLine());
                double others = (water + internet + electricity) * 1.20;

                totalElectricity += electricity;
                totalOthers += others;
            }

            double average = (totalElectricity + totalInternet + totalWater + totalOthers) / months;

            Console.WriteLine($"Electricity: {totalElectricity:f2} lv");
            Console.WriteLine($"Water: {totalWater:f2} lv");
            Console.WriteLine($"Internet: {totalInternet:f2} lv");
            Console.WriteLine($"Other: {totalOthers:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv"); 
        }
    }
}
