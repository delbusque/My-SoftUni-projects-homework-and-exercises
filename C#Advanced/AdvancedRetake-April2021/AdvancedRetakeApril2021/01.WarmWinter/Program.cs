using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.WarmWinter
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> hats = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> scarfs = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            List<int> sets = new List<int>();

            while (hats.Count > 0 && scarfs.Count > 0)
            {
                int hat = hats.Peek();
                int scarf = scarfs.Peek();

                if (hat > scarf)
                {
                    sets.Add(hats.Pop() + scarfs.Dequeue());                    
                }

                else if (scarf > hat)
                {
                    hats.Pop();
                }

                else
                {
                    scarfs.Dequeue();
                    int currentHat = hats.Pop() + 1;
                    hats.Push(currentHat);
                }
            }

            List<int> ordered = sets.OrderByDescending(s => s).ToList();

            foreach (var item in ordered)
            {
                Console.WriteLine($"The most expensive set is: {item}");
                break;
            }

            foreach (var item in sets)
            {              
                Console.Write($"{item} ");
            }          
        }
    }
}
