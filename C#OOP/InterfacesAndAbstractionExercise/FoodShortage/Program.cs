using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<IBuyer> buyers = new List<IBuyer>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];
                int age = int.Parse(input[1]);

                if (input.Length > 3)
                {
                    string id = input[2];
                    string birthdate = input[3];
                    IBuyer citizen = new Citizen(name, age, id, birthdate);
                    buyers.Add(citizen);
                }
                else
                {
                    string group = input[2];
                    IBuyer rebel = new Rebel(name, age, group);
                    buyers.Add(rebel);
                }
            }

            string buyerName = Console.ReadLine();
            int totalFood = 0;

            while (buyerName != "End")
            {
                foreach (var buyer in buyers)
                {
                    if (buyer.Name == buyerName)
                    {
                        buyer.BuyFood();                       
                    }
                }

                buyerName = Console.ReadLine();
            }

            foreach (var buyer in buyers)
            {
                totalFood += buyer.Food;
            }

            Console.WriteLine(totalFood);
        }
    }
}
