using System;
using System.Collections.Generic;
using System.Text;

namespace _05.GenericCountMethodString
{
    public class Box<T>
        where T : IComparable
    {       
        public List<T> Values { get; set; }

        public Box()
        {
            Values = new List<T>();
        }

        public int GreaterValues(T element)
        {
            int count = 0;
            
            foreach (var item in Values)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                }
            }

            return count;
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
