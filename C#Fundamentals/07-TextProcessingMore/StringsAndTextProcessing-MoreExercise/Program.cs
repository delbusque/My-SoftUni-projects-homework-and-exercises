using System;
using System.Text;
using System.Linq;

namespace StringsAndTextProcessing_MoreExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] item = Console.ReadLine().Split();

                string name = string.Empty;
                string age = string.Empty;


                for (int j = 0; j < item.Length; j++)
                {

                    if (item[j].Contains('@') && item[j].Contains('|'))
                    {
                        name = item[j].Substring(1, item[j].Length - 2);
                    }
                    else if (item[j].Contains('#') && item[j].Contains('*'))
                    {
                        age = item[j].Substring(1, item[j].Length - 2);
                    }
                }

                
                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
