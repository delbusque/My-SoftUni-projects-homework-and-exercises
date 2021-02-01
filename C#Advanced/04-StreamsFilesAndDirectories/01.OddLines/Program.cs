using System;
using System.IO;
using System.Linq;

namespace _01.OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Path.Combine("data", "text.txt");
            var dest = Path.Combine("data", "output.txt");

            using (FileStream file = new FileStream(path, FileMode.Open))
            {
                using (TextReader reader = new StreamReader(file))
                {
                    string line = reader.ReadLine();
                    int counter = 0;

                    using (FileStream output = new FileStream(dest, FileMode.Append))
                    {
                        using (TextWriter writer = new StreamWriter(output))
                        {

                            while (line != null)
                            {
                                if (counter % 2 != 0)
                                {
                                    writer.WriteLine(line);
                                }

                                line = reader.ReadLine();
                                counter++;
                            }
                        }
                    }

                }
            }
        }
    }
}
