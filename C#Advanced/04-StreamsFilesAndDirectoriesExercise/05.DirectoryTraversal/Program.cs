using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _05.DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> files = new Dictionary<string,Dictionary<string,double>>();

            DirectoryInfo directoryInfo = new DirectoryInfo("../../../");

            var list = directoryInfo.GetFiles();

            foreach (var file in list)
            {
                if (!files.ContainsKey(file.Extension))
                {
                    files.Add(file.Extension, new Dictionary<string, double>());
                    files[file.Extension].Add(file.Name, file.Length);
                }
                else
                {
                    files[file.Extension].Add(file.Name, file.Length / 1024.00);
                }
               
            }

            var path = Path.Combine($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}", "output.txt");

            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (var type in files.OrderByDescending(t => t.Value.Count).ThenBy(x => x.Key))
                {
                    writer.WriteLine(type.Key);

                    foreach (var item in type.Value.OrderByDescending(x => x.Value))
                    {
                        writer.WriteLine($"--{item.Key} - {item.Value:f3}kb");
                    }
                }
            }          
        }
    }
}
