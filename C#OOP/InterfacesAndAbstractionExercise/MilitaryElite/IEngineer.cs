﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public interface IEngineer : ISpecialisedSoldier
    {
        public List<Repair> Repairs { get; set; }
    }
}
