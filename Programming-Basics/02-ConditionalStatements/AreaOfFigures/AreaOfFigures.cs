using System;

namespace AreaOfFigures
{
    class AreaOfFigures
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
        
            if (figure == "square")
            {
                double lenght = double.Parse(Console.ReadLine());
                double area = lenght * lenght;
                Console.WriteLine($"{area:f3}");
            }

            else if (figure == "rectangle")
            {
                double lenght = double.Parse(Console.ReadLine());
                double widht = double.Parse(Console.ReadLine());
                Console.WriteLine($"{(lenght * widht):f3}");
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine($"{(radius * radius * Math.PI):f3}");
            }

            else if (figure == "triangle")
            {
                double lenght = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine($"{(lenght * height / 2):f3}");
            }
        }
    }
}
