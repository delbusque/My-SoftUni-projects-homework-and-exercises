using System;

namespace FruitOrVegetable
{
    class FruitOrVegetable
    {
        static void Main()
        {
            string product = Console.ReadLine();

            switch (product)
            {
                case "banana":
                case "apple":
                case "cherry":
                case "kiwi":
                case "lemon":
                case "grapes":
                    Console.WriteLine("fruit"); break;

                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    Console.WriteLine("vegetable"); break;

                default:
                    Console.WriteLine("unknown"); break;
            }
        }
    }
}
