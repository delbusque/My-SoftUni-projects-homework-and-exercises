using System;

namespace _06.CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = Area(width, height);
            Console.WriteLine(area);
        }

        static double Area(double a, double b)
        {
            return a * b;           
        }
    }
}
