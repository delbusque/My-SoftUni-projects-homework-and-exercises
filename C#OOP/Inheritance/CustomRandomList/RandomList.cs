using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        public string RandomString()
        {
            Random random = new Random();
            int position = random.Next(0, this.Count);
            string removed = this[position];

            this.RemoveAt(position);
            return removed;
        }
    }
}
