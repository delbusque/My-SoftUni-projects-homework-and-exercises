using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.FlowerWreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> lilies = new Stack<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> roses = new Queue<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            int wreathCount = 0;
            int storedFlowers = 0;

            while (lilies.Count != 0 && roses.Count != 0)
            {
                int currLilies = lilies.Peek();
                int currRoses = roses.Peek();

                if (currLilies + currRoses == 15)
                {
                    wreathCount++;
                    lilies.Pop();
                    roses.Dequeue();
                }
                else if (currLilies + currRoses > 15)
                {
                    currLilies -= 2;
                    lilies.Pop();
                    lilies.Push(currLilies);
                }
                else if (currLilies + currRoses < 15)
                {
                    storedFlowers += lilies.Pop();
                    storedFlowers += roses.Dequeue();
                }
            }

            int bonusWreaths = storedFlowers / 15;
            wreathCount += bonusWreaths;

            if (wreathCount >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreathCount} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - wreathCount} wreaths more!");
            }

        }
    }
}
