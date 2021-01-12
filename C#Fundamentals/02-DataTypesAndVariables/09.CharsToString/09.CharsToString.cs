using System;

namespace _09.CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "";
            
            for (int i = 0; i <= 2; i++)
            {
                char current = char.Parse(Console.ReadLine());
                result += current.ToString();
            }

            Console.WriteLine(result);
        }
    }
}
