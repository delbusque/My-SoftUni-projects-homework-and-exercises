using System;

namespace _03.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string sign = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            switch (sign)
            {
                case "add":
                    Add(a, b); break;
                case "multiply":
                    Multiply(a, b); break;
                case "substract":
                    Substract(a, b); break;
                case "divide":
                    Divide(a, b); break;
            }
        }
    

        static void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }

        static void Multiply(int a, int b)
        {
            int result = a * b;
            Console.WriteLine(result);
        }

        static void Substract(int a, int b)
        {
            int result = a - b;
            Console.WriteLine(result);
        }

        static void Divide(int a, int b)
        {
            int result = a / b;
            Console.WriteLine(result);
        }
    }
}
