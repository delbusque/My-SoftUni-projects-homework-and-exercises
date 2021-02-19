using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine()); // 4

            string command = "";                     

            int lenght = 1;
            int maxLenght = 0;
            
            int start = 0;
            int bestStart = 0;

            int counter = 1;

            do
            {
                int[] line = Console.ReadLine().Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
              
                for (int i = 1; i < n; i++)
                {
                    if (line[i - 1] == 1)
                    {                        

                        if (line[i] == line[i - 1])
                        {
                            counter++;
                            lenght++;
                            
                            start += i - 1;
                        }
                        else
                        {
                            bestStart = start;
                        }

                        if (lenght > maxLenght)
                        {
                            maxLenght = lenght;
                        }
                    }
                }

                for (int i = bestStart; i < bestStart + maxLenght; i++)
                {
                    Console.WriteLine(line[i] + "");
                }
            }
            while (command != "Clone them!");

           



        }
    }
}
