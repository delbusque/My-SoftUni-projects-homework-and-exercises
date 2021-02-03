using System;
using System.Linq;

namespace _03.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> upper = s => s[0] == s.ToUpper()[0];

            string[] text = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(upper).ToArray();

            foreach (var item in text)
            {
                Console.WriteLine(item);
            }
        }
    }
}
