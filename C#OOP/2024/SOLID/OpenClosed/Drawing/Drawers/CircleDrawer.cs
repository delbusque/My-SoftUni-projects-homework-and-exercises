using Drawing.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing.Drawers
{
    public class CircleDrawer : IDrawer
    {
        public void Draw(IShape shape)
        {
            Console.WriteLine("I am a circle ... ");
        }

        public bool IsMatch(IShape shape)
        {
            return shape is Circle;
        }
    }
}
