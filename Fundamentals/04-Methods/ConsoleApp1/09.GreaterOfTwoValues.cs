using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine(MaxValue(a, b));
                    break;

                case "char":
                    char charA = char.Parse(Console.ReadLine());
                    char charB = char.Parse(Console.ReadLine());
                    Console.WriteLine(MaxValue(charA, charB));
                    break;

                case "string":
                    string strA = Console.ReadLine();
                    string strB = Console.ReadLine();
                    Console.WriteLine(MaxValue(strA, strB));
                    break;


            }


        }

        static int MaxValue(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static char MaxValue(char a, char b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static string MaxValue (string a, string b)
        {
            int result = a.CompareTo(b);

            if (result > 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
