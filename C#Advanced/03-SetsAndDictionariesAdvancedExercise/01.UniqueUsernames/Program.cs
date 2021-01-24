using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> userNames = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                
                if (!userNames.Contains(name))
                {
                    userNames.Add(name);
                }
            }

            foreach (var item in userNames)
            {              
                Console.WriteLine(item);
            }
        }
    }
}
