﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : IDrawable
    {
        private int radius;
        
        public Circle(int radius)
        {
            this.radius = radius;
        }

        public void Draw()
        {
            double rIn = radius - 0.4;
            double rOut = radius + 0.4;
            for (double i = radius; i >= -radius; --i)
            {
                for (double j = -radius; j < rOut; j+= 0.5)
                {
                    double value = j * j + i * i;

                    if (value >= rIn*rIn && value <= rOut * rOut)
                    {
                Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
