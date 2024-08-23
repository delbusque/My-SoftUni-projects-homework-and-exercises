using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DystopianSociety
{
    public class Pet : ILivingCreater
    {
        public Pet(string name, DateOnly birthday)
        {
            Name = name;
            Birthday = birthday;
        }

        public string Name { get; private set; }

        public DateOnly Birthday { get; private set; }
    }
}
