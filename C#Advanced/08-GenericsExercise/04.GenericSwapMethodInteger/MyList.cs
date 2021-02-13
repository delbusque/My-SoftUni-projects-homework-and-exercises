using System;
using System.Collections.Generic;
using System.Text;

namespace _04.GenericSwapMethodInteger
{
    public class MyList<T>
    {
        public List<T> Values { get; set; }

        public MyList()
        {
            Values = new List<T>();
        }

        public void Swap(int a, int b)
        {
            T temp = Values[a];
            Values[a] = Values[b];
            Values[b] = temp;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in Values)
            {
                sb.AppendLine($"{item.GetType()}: {item}");
            }

            string result = sb.ToString().TrimEnd();
            return result;
        }
    }
}
