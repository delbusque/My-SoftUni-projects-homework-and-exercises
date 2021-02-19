using System;

namespace _03.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('\\');

            foreach (var item in input)
            {
                string[] searched = new string[2];

                if (item.Contains('.'));
                {
                    if (item.Contains(":"))
                    {
                        continue;
                    }
                    else if (item.Contains(";"))
                    {
                        continue;
                    }
                    else if (item.Contains("."))
                    {
                        searched = item.Split('.');
                        Console.WriteLine($"File name: {searched[0]}");
                        Console.WriteLine($"File extension: {searched[1]}");
                    }

                }   
            }
        }
    }
}
