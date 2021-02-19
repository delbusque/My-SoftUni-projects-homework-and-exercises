using System;
using System.Text;
using System.Linq;

namespace StringsAndTextProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                char[] word = input.ToCharArray();

                Console.WriteLine($"{input} = {string.Join("", word.Reverse())}");

                input = Console.ReadLine();
            }
        }
    }
}
