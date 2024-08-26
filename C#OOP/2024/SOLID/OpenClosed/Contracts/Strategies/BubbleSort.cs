﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenClosed.Contracts;

namespace OpenClosed.Contracts.Strategies
{
    public class BubbleSort : ISortingStrategy
    {
        public List<int> Sort(List<int> list)
        {
            Console.WriteLine(" I`m bubbling ... ");
            return list;
        }
    }
}