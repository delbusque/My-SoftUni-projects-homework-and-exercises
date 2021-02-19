using System;
using System.Collections.Generic;

namespace _03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());

            CharRange(a, b);
                               
        }

        static void CharRange(char a, char b)
        {
            if (a < b)
            {
                for (int i = a + 1; i < b; i++)
                {
                    Console.Write((char)i + " ");
                }               
            }
            else
            {
                for (int i = b + 1; i <= a - 1; i++)
                {
                    Console.Write((char)i + " ");
                }            
            }
        }
    }
}
