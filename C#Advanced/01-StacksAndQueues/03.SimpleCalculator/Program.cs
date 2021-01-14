using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<string> stack = new Stack<string>(input.Split().Reverse());

            while (stack.Count > 1)
            {
                int operand1 = int.Parse(stack.Pop());
                string oper = stack.Pop();
                int operand2 = int.Parse(stack.Pop());

                if (oper == "+")
                {
                    stack.Push((operand1 + operand2).ToString());
                }
                else if (oper == "-")
                {
                    stack.Push((operand1 - operand2).ToString());
                }
            }

            Console.WriteLine(string.Join("", stack));

        }
    }
}
