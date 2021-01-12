using System;

namespace SquareArea
{
    class SquareArea
    {
        static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            double area = side * side;

            Console.WriteLine(area);
        }
    }
}
