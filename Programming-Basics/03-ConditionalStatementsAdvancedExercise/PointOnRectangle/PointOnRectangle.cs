﻿using System;

namespace PointOnRectangle
{
    class PointOnRectangle
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool onBorder = false;

            if(x == x1 || x == x2)
            {
                if (y >= y1 && y <= y2)
                {
                    onBorder = true;
                }
            }

            else if (y == y1 || y == y2)
            {
                if (x >= x1 && x <= x2)
                {
                    onBorder = true;
                }
            }

            if(onBorder)
            {
                Console.WriteLine("Border");
            }

            else
            {
                Console.WriteLine("Inside / Outside");
            }

        }
    }
}
