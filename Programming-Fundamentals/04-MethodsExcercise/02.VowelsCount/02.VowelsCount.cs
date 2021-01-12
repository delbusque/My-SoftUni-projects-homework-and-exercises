using System;
using System.Linq;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            Vowels(input);
        }       

        static void Vowels(string input)
        {
            int count = 0;
            char[] vowels = new char[] { 'a', 'o', 'e', 'i', 'u', 'y' };

            for (int i = 0; i < input.Length; i++)
            {
                if (vowels.Contains(input[i]))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
