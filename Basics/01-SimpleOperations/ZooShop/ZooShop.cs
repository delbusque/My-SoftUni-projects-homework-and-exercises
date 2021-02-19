using System;

namespace ZooShop
{
    class ZooShop
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int animals = int.Parse(Console.ReadLine());

            double dogsExpenses = dogs * 2.50;
            double animalsExpenses = animals * 4.00;

            double totalExpenses = dogsExpenses + animalsExpenses;

            Console.WriteLine($"{totalExpenses:f2} lv.");
        }
    }
}
