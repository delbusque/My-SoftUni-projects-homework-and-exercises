using System;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"\b[A-Z][a-z]+\s[A-Z][a-z]+\b";
            Regex regex = new Regex(pattern);

            Console.WriteLine(string.Join(" ", regex.Matches(text))); 

        }
    }
}
