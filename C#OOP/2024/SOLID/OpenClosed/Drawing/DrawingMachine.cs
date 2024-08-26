using Drawing.Contracts;
using Drawing.Drawers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing
{
    public class DrawingMachine
    {
        private List<IDrawer> drawers;

        public DrawingMachine()
        {
            drawers = new List<IDrawer>()
            {
                new CircleDrawer(),
                new TrapecDrawer()
            };
        }

        public void Draw(IShape shape)
        {
            IDrawer drawer = drawers.First(d => d.IsMatch(shape));
            drawer.Draw(shape);
        }
    }
}
