using System;
using System.Collections.Generic;

namespace _04.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] charText = text.ToCharArray();
            
            List<char> encrypted = new List<char>();

            for (int i = 0; i < charText.Length; i++)
            {
                int current = charText[i];
                char encr = char.Parse(char.ConvertFromUtf32(current + 3));

                encrypted.Add(encr);
            }

            Console.WriteLine(string.Join("", encrypted));
        }
    }
}
