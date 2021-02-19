using System;
using System.Text;

namespace _07.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringLine = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Repeated(stringLine, n));
          
        }

        static string Repeated(string stringLine, int n)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                result.Append(stringLine);
            }

            return result.ToString();
        }
    }
}
