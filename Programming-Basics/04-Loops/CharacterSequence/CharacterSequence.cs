using System;

namespace CharacterSequence
{
    class CharacterSequence
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            for (int i = 0; i <= text.Length-1; i++)
            {
                char letter = text[i];
                Console.WriteLine(letter);
            }
        }
    }
}
