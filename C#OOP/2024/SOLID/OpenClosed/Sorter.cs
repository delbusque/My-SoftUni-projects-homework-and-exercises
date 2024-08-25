using OpenClosed.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    public class Sorter
    {   
        private ISortingStrategy strategy;

        public Sorter(ISortingStrategy sortingStrategy) 
        {
            strategy = sortingStrategy;
        }

        public List<int> Sort(List<int> list) {
            return strategy.Sort(list);
        }
    }
}
