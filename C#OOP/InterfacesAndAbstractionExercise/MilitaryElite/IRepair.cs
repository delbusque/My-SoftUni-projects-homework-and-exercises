using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public interface IRepair
    {
        public int WorkedHours { get; set; }

        public string PartName { get; set; }
    }
}
