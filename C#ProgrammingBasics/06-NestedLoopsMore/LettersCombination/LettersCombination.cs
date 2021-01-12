using System;

namespace LettersCombination
{
    class LettersCombination
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char miss = char.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = start; i <= end; i++)
            {                
                
                if (i == miss)
                {
                    continue;
                }

                for (int k = start; k <= end; k++)
                {
                    if (k == miss)
                    {
                        continue;
                    }

                    for (int j = start; j <= end; j++)
                    {
                        if (j == miss)
                        {
                            continue;
                        }
                        counter++;

                        char a = Convert.ToChar(i);
                        char b = Convert.ToChar(k);
                        char c = Convert.ToChar(j);

                        Console.Write($"{a}{b}{c} ");
                    }
                }
            }

            Console.Write(counter);
        }
    }
}
