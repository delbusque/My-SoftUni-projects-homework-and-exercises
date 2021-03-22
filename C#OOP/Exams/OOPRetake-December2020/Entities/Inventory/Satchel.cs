using System;
using System.Collections.Generic;
using System.Text;

namespace WarCroft.Entities.Inventory
{
    public class Satchel : Bag
    {
        public Satchel(int capacity = 20) 
            : base(capacity)
        {
        }
    }
}
