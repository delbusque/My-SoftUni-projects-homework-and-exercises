using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01.EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Path.Combine("data", "text.txt");
            int counter = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                using (StreamWriter writer = new StreamWriter("output.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();

                        if (counter % 2 == 0)
                        {
                            Regex pattern = new Regex("[-,.!?]");
                            line = pattern.Replace(line, "@");
                            string[] current = line.Split().Reverse().ToArray();
                            line = string.Join(" ", current);
                            writer.WriteLine(line);
                        }
                        counter++;
                    }
                }
            }
        }
    }
}
