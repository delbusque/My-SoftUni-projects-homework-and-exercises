using System;
using System.Collections.Generic;
using System.Text;

namespace Box
{
    public class Box
    {

        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            Height = height;
            Width = width;
            Length = length;
        }

        public double Length
        {
            get => length; private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }

                length = value;
            }
        }
        public double Width
        {
            get => width; private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }

                width = value;
            }
        }
        public double Height
        {
            get => height; private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }

                height = value;
            }
        }

        public double SurfaceArea(Box box)
        {
            double surfaceArea = 2 * box.Length * box.Width + 2 * box.Length * box.Height + 2 * box.Width * box.Height;
            return surfaceArea;
        }

        public double LateralSurfaceArea(Box box)
        {
            double lateralSurfaceArea = 2 * box.Length * box.Height + 2 * box.Width * box.Height;
            return lateralSurfaceArea;
        }

        public double Volume(Box box)
        {
            double volume = box.Length * box.Height * box.Width;
            return volume;
        }
    }
}
