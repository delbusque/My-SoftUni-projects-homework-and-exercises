using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            double secondNum = double.Parse(Console.ReadLine());

            Console.WriteLine(Result(firstNum, @operator, secondNum));

        }

        static double Result(double firstNum, string @operator, double secondNum)
        {
            double result = 0;
            
            switch (@operator)
            {
                case "+":
                    result = Math.Round(firstNum + secondNum, 2); break;
                case "-":
                    result = Math.Round(firstNum - secondNum, 2); break;
                case "*":
                    result = Math.Round(firstNum * secondNum, 2); break;
                case "/":
                    result = Math.Round(firstNum / secondNum, 2); break;
            }

            return result;
        }
    }
}
