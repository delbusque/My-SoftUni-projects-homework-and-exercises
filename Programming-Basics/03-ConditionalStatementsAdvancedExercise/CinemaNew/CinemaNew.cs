using System;

namespace MoreConditionalStatementsExcersise
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string typeShow = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            int places = rows * columns;

            if (typeShow == "Premiere")
            {
                Console.WriteLine($"{places * 12.00:f2} leva");
            }
            else if (typeShow == "Normal")
            {
                Console.WriteLine($"{places * 7.50:f2} leva");
            }
            else if (typeShow == "Discount")
            {
                Console.WriteLine($"{places * 5.00:f2} leva");
            }

        }
    }
}
