using System;

namespace _2DReactangleArea
{
    class Program
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double lenght = Math.Abs(x2 - x1);
            double widht = Math.Abs(y2 - y1);

            double area = lenght * widht;
            double perimeter = (lenght + widht) * 2;

            Console.WriteLine($"{area:F2}");
            Console.WriteLine($"{perimeter:f2}");          
        }
    }
}
