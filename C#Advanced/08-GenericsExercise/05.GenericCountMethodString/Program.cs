using System;

namespace _05.GenericCountMethodString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<string> line = new Box<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                line.Values.Add(input);
            }

            string element = Console.ReadLine();

            Console.WriteLine(line.GreaterValues(element));
        }
    }
}
