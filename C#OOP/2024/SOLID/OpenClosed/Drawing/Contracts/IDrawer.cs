using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing.Contracts
{
    public interface IDrawer
    {
        void Draw(IShape shape);

        bool IsMatch(IShape shape);
    }
}
