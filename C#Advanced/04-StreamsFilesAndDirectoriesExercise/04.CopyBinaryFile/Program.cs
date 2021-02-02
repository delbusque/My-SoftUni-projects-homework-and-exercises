using System;
using System.IO;

namespace _04.CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Path.Combine("data", "CopyMe.jpg");
            var dest = Path.Combine("data", "newFile.jpg");

            using (FileStream reader = new FileStream(path, FileMode.Open))
            {
                using (FileStream writer = new FileStream(dest, FileMode.Create))
                {
                    byte[] buffer = new byte[4096];

                    while (reader.CanRead)
                    {
                        int bytesRead = reader.Read(buffer, 0, buffer.Length);
                        if (bytesRead == 0)
                        {
                            break;
                        }
                        writer.Write(buffer, 0, buffer.Length);
                    }
                }                
            }
        }
    }
}
