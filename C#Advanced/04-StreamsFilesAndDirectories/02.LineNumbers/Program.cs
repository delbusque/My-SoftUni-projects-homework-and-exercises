using System;
using System.IO;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Path.Combine("data", "text.txt");
            var dest = Path.Combine("data", "output.txt");

            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadLine();
                int counter = 1;

                using (StreamWriter writer = new StreamWriter(dest))
                {
                    while (line != null)
                    {
                        line = line.Insert(0, $"{counter.ToString()}. ");
                        
                        writer.WriteLine($"{line}");
                        counter++;

                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
