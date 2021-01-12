using System;

namespace SumNumbers
{
    class SumNumbers
    {
        static void Main(string[] args)
        {
			string text = Console.ReadLine();
			int sum = 0;

			while (text != "Stop")
			{
				int number = int.Parse(text);
				sum += number;

				text = Console.ReadLine();
			}

			Console.WriteLine(sum);
		}
	}
}