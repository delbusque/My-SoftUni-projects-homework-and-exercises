using System;

namespace HoneyCombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int honeys = int.Parse(Console.ReadLine());
            int flowers = int.Parse(Console.ReadLine());

            double totalHoney = 0.21 * honeys * flowers;

            double honeyComb = 100;
            int honeyCombCounter = 0;
            double honeyLeft = 0;

           
                honeyCombCounter++;
                honeyLeft = totalHoney - honeyComb;
                totalHoney = totalHoney - 100;
            

            Console.WriteLine($"{honeyCombCounter} honeycombs filled.");
            Console.WriteLine($"{honeyLeft:f2} grams of honey left.");
        }
    }
}
