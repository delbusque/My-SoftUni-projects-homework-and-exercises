using System;
using System.Collections.Generic;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stack = new StackOfStrings();

            for (int i = 0; i < 6; i++)
            {
                stack.Push(i.ToString());
            }

            Console.WriteLine(stack.IsEmpty());

            List<string> list = new List<string> { "a", "b", "c" };

            stack.AddRange(list);

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
