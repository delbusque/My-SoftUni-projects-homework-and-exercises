using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public interface ILieutenantGeneral : ISoldier
    {
        public IReadOnlyCollection<IPrivate> Privates { get;}

        public void AddPrivate(IPrivate @private);
    }
}
