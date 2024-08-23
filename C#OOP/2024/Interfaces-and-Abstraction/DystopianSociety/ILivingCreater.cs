using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DystopianSociety
{
    public interface ILivingCreater
    {
        public string Name { get; }
        public DateOnly Birthday { get; }
    }
}
