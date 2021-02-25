using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {
        public Person(string name, int age)
        {
            Age = age;
            Name = name;
        }

        private int age;
        public virtual int Age {
            
            get
            {
                return this.age;
            }
            
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid age");
                }

                else
                {
                    this.age = value;
                }
                
            } 
        }
        
        public string Name { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Name: {Name}, Age: {Age}");
                       
            return sb.ToString();
        }


    }
}
