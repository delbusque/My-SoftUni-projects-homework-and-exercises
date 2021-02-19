using System;

namespace _03.ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] array1 = new string[n];
            string[] array2 = new string[n];

            for (int i = 0; i < n; i++)
            {
                string[] currentline = Console.ReadLine().Split();  
               
                    if (i % 2 == 0)
                    {
                        array1[i] = currentline[0];
                        array2[i] = currentline[1];
                    }
                    else
                    {
                        array1[i] = currentline[1];
                        array2[i] = currentline[0];
                    }
            }

            Console.WriteLine(string.Join(" ", array1));
            Console.WriteLine(string.Join(" ", array2));
        }
    }
}
