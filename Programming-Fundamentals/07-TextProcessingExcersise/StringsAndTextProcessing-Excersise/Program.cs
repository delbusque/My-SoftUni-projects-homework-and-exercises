using System;
using System.Linq;
using System.Text;

namespace StringsAndTextProcessing_Excersise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var item in usernames)
            {
                bool isValid = false;
                
                for (int i = 0; i < item.Length; i++)
                {
                    if (item.Length >= 3 && item.Length <= 16 && item.All(x=>char.IsLetterOrDigit(x)) || item.Contains('-') || item.Contains('_'))
                    {
                        isValid = true;
                    }
                    else
                    {
                        break;
                    }
                }

                if (isValid == true)
                {
                    Console.WriteLine(item);
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
