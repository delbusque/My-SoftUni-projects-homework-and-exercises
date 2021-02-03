using System;

namespace _02.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string title = "Sir";
           
            Action<string[]> print = name =>
            {
                foreach (var item in name)
                {
                    Console.WriteLine($"Sir {string.Join(Environment.NewLine, item)}");
                }

                
            };

            print(names);
       
        }
    }
}
