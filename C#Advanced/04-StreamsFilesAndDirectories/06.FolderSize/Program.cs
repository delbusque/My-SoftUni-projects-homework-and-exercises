using System;
using System.IO;

namespace _06.FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = Directory.GetFiles("../../../TestFolder");
            long size = 0;

            foreach (var file in files)
            {                
                    FileInfo info = new FileInfo(file);
                    size += info.Length;                      
            }

            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                writer.Write(size / 1024.0 / 1024.0);
            }
        }
    }
}
