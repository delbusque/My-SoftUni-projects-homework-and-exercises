using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            if (this.Count <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public StackOfStrings AddRange(List<string> list)
        {
            list.ForEach(this.Push);
            return this;
        }
    }
}
