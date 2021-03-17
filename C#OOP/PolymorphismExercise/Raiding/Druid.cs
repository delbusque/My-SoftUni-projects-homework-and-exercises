﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Druid : BaseHero
    {
        private const int power = 80;
        public Druid(string name) 
            : base(name)
        {
            Power = power;
        }

        public override string CastAbility()
        {
            return $"{GetType().Name} - {Name} healed for {Power}";
        }
    }
}
