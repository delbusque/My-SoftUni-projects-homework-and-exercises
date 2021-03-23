using System;
using System.Collections.Generic;
using System.Text;

namespace WarCroft.Entities.Inventory
{
    public class Satchel : Bag
    {
        private const int capacity = 20;
        
        public Satchel(int capacity = capacity) 
            : base(capacity)
        {
        }
    }
}
