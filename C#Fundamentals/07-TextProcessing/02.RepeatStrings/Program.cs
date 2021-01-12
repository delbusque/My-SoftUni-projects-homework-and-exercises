using System;
using System.Text;
using System.Linq;

namespace _02.RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split();

            StringBuilder concat = new StringBuilder();

            foreach (var item in line)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    concat.Append(item);
                }
               
            }

            Console.WriteLine(concat.ToString());
        }
    }
}
