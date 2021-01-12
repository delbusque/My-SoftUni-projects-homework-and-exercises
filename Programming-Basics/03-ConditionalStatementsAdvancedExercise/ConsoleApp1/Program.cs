using System;

namespace OperationsBetweenNumbers
{
    class OperationsBetweenNumbers
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            string operat = Console.ReadLine();

            double result = 0;

            if (operat == "+" || operat == "-" || operat == "*")
            {
                switch (operat)
                {
                    case "+":
                        result = numOne + numTwo;
                        break;
                    case "-":
                        result = numOne - numTwo;
                        break;
                    case "*":
                        result = numOne * numTwo;
                        break;
                }

                if (result % 2 == 0)
                {
                    Console.WriteLine($"{numOne} {operat} {numTwo} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{numOne} {operat} {numTwo} = {result} - odd");
                }

            }

           



        }
    }
}
