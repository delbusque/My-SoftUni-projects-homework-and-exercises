using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> firstBox = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            Stack<int> secondBox = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            List<int> claimedItems = new List<int>();

            while (firstBox.Count > 0 && secondBox.Count > 0)
            {

                int sum = firstBox.Peek() + secondBox.Peek();

                if (sum % 2 == 0)
                {
                    claimedItems.Add(sum);
                    firstBox.Dequeue();
                    secondBox.Pop();
                }
                else
                {
                    firstBox.Enqueue(secondBox.Pop());
                }
            }

            if (firstBox.Count == 0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            else if (secondBox.Count == 0)
            {
                Console.WriteLine("Second lootbox is empty");
            }

            int claimedSum = claimedItems.Sum();
            
            if (claimedSum >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {claimedSum}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {claimedSum}");
            }
        }
    }
}
