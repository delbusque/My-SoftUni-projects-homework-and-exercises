using System;
using System.Collections.Generic;

namespace _07.HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> players = new Queue<string>(Console.ReadLine().Split());
            int pass = int.Parse(Console.ReadLine());

            int counter = 1;

            while (players.Count > 1)
            {              
                if (counter % pass == 0)
                {
                    Console.WriteLine($"Removed {players.Dequeue()}");
                    counter++;
                }
                else
                {
                    players.Enqueue(players.Dequeue());
                    counter++;
                }
            }

            Console.WriteLine($"Last is {string.Join("", players)}");
        }
    }
}
