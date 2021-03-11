using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public interface ILieutenantGeneral : ISoldier
    {
        public List<Private> Privates { get; set; }
    }
}
