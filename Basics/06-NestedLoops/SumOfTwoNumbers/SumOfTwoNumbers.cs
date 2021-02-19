using System;

namespace SumOfTwoNumbers
{
    class SumOfTwoNumbers
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int counter = 0;
            bool flag = false;

            for (int i = firstNum; i <= secondNum; i++)
            {

                for (int j = firstNum; j <= secondNum; j++)
                {
                    counter++;

                    if (i + j == magicNum)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magicNum})");
                        flag = true;
                        break;
                    }

                }

                if (flag)
                {
                    break;
                }
            }

            if (!flag)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
            }

        }
    }
}
