using System;

namespace _04.PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                PrintLine(i);
            }

            for (int i = num - 1; i > 0; i--)
            {
                PrintLine(i);
            }
            
           
        }

        static void PrintLine(int to)
        {
            for (int i = 1; i <= to; i++)
            {
                Console.Write(i + " ");                
            }
            Console.WriteLine();

        }
    }
}
