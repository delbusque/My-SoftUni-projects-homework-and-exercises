using Drawing.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing.Drawers
{
    public class TrapecDrawer : IDrawer
    {
        public void Draw(IShape shape)
        {
            Console.WriteLine("I am Trapec ... ");
        }

        public bool IsMatch(IShape shape)
        {
            return shape is Trapec;
        }
    }
}
