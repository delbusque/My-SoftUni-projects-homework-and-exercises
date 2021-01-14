using System;
using System.Collections.Generic;

namespace _06.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Queue<string> customers = new Queue<string>();

            while (name != "End")
            {
                if (name != "Paid")
                {
                    customers.Enqueue(name);
                }

                else if (name == "Paid")
                {
                    int counter = customers.Count;

                    for (int i = 0; i < counter; i++)
                    {
                        Console.WriteLine(customers.Dequeue());
                    }
                }

                name = Console.ReadLine();
            }

            Console.WriteLine($"{customers.Count} people remaining.");
        }
    }
}
