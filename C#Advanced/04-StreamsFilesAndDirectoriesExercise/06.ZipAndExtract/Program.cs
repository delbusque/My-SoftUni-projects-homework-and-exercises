using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace _06.ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory("data", "output.zip");

            ZipFile.ExtractToDirectory("output.zip", Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
        }
    }
}
