using System;
using System.Linq;
using System.Text;

namespace _05.DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            
            char[] charText = text.ToCharArray();
            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder symbols = new StringBuilder();



            foreach (var item in charText)
            {            
                if (char.IsDigit(item))
                {
                    digits.Append(item);
                }
                else if (char.IsLetter(item))
                {
                    letters.Append(item);
                }
                else
                {
                    symbols.Append(item);
                }
            }

            Console.WriteLine(digits.ToString());
            Console.WriteLine(letters.ToString());
            Console.WriteLine(symbols.ToString());

        }
    }
}
