using System;

namespace _04.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(); // 51 47 32 61 21 
            

            int n = int.Parse(Console.ReadLine()); // 2

            for (int j = 0; j < n; j++)
            {
                string firstElement = line[0];
                
                string[] newLine = new string[line.Length];

                for (int i = 1; i < line.Length; i++)
                {
                    newLine[i-1] = line[i];
                }

                newLine[newLine.Length - 1] = firstElement;
                line = newLine;
            }

            Console.WriteLine(string.Join(" ", line));

        }
    }
}
