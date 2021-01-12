using System;

namespace _04.Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            foreach (var item in bannedWords)
            {
                string censsored = new string('*', item.Length);

                text = text.Replace(item, censsored);
            }

            Console.WriteLine(text);

        }
    }
}
