using System;
using System.IO;

namespace _05.SliceAFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Path.Combine("data", "text.txt");

            using (FileStream reader = new FileStream(path, FileMode.Open))
            {
                int chunkSize = (int)reader.Length / 4;

                for (int i = 0; i < 4; i++)
                {
                    byte[] buffer = new byte[1];
                    int count = 0;
                    using (FileStream writer = new FileStream($"part-{i+1}.txt", FileMode.Create, FileAccess.Write))
                    {
                        while (count < chunkSize)
                        {
                            reader.Read(buffer, 0, buffer.Length);
                            writer.Write(buffer, 0, buffer.Length);
                            count+= buffer.Length;
                        }
                    }

                }
            }
        }
    }
}
