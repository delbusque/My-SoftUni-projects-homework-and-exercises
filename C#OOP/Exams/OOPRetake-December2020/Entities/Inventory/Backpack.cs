﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WarCroft.Entities.Inventory.Contracts
{
    public class Backpack : Bag
    {
        private const int capacity = 100;

        public Backpack(int capacity = capacity)
            : base(capacity)
        {
        }
    }
}
