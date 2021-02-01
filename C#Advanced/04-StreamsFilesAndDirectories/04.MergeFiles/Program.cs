using System;
using System.Collections.Generic;
using System.IO;

namespace _04.MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOne = new List<string>();
            List<string> listTwo = new List<string>();
            var path1 = Path.Combine("data", "text1.txt");
            var path2 = Path.Combine("data", "text2.txt");

            using (StreamReader reader = new StreamReader(path1))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    listOne.Add(line);
                    line = reader.ReadLine();
                }              
            }
            using (StreamReader reader = new StreamReader(path2))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    listTwo.Add(line);
                    line = reader.ReadLine();
                }
            }
            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                if (listOne.Count <= listTwo.Count)
                {
                    for (int i = 0; i < listOne.Count; i++)
                    {
                        writer.WriteLine(listOne[i]);
                        writer.WriteLine(listTwo[i]);
                    }
                    for (int i = listOne.Count; i < listTwo.Count; i++)
                    {
                        writer.WriteLine(listTwo[i]);
                    }
                }
                else
                {
                    for (int i = 0; i < listTwo.Count; i++)
                    {
                        writer.WriteLine(listOne[i]);
                        writer.WriteLine(listTwo[i]);
                    }
                    for (int i = listTwo.Count; i < listOne.Count; i++)
                    {
                        writer.WriteLine(listOne[i]);
                    }
                }
            }   
        }
    }
}
