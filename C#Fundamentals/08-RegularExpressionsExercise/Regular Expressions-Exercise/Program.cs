using System;
using System.Text.RegularExpressions;

namespace Regular_Expressions_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //string pattern = @">>(?<furniture>[A-Za-z]+)<<(?<price>(?:\d+\.\d+)|(?:\d+))!(?<quantity>\d+)";
            string pattern = @">>(?<furniture>[A-Za-z]+)<<(?<price>(\d+\.\d+)|(\d+))!(?<quantity>\d+)";

            Regex furniture = new Regex(pattern);

            string input = Console.ReadLine();

            Console.WriteLine("Bought furniture:");

            double totalSum = 0;

            while (input != "Purchase")
            {
                Match shoppCard = furniture.Match(input);

                if (shoppCard.Success)
                {
                    string type = shoppCard.Groups["furniture"].Value;
                    double price = double.Parse(shoppCard.Groups["price"].Value);
                    int quantuty = int.Parse(shoppCard.Groups["quantity"].Value);

                    double sum = price * quantuty;
                    totalSum += sum;

                    Console.WriteLine(type);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total money spend: {totalSum:f2}");
           
        }
    }
}
