using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaces
{
    public interface IResident : IPerson
    {
        public string Country { get; set; }

        public string GetName();

    }
}
