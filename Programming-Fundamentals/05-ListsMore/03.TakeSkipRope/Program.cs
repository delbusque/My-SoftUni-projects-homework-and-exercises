using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            List<char> inputList = new List<char>(); 

            for (int i = 0; i < line.Length; i++)
            {                
                inputList.Add((char)line[i]);
            }

            List<char> digits = new List<char>();
            List<char> symbols = new List<char>();

            for (int i = 0; i < inputList.Count; i++)
           
            {
                char item = inputList[i];

                if (item > 47 && item < 58)
                {
                    digits.Add(inputList[i]);                    
                }
                else
                {
                    symbols.Add(inputList[i]);
                }
            }

            List<char> take = new List<char>();
            List<char> split = new List<char>();

            for (int i = 0; i < digits.Count; i++)
            {
                if (i % 2 == 0)
                {
                    take.Add(digits[i]);
                }
                else
                {
                    split.Add(digits[i]);
                }
            }

            Console.WriteLine(string.Join("", take));
            Console.WriteLine(string.Join("", split));

           

        }
    }
}
