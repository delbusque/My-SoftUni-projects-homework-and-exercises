using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Kitten : Cat
    {
        private const string kittenGender = "female";
        
        public Kitten(string name, int age, string gender) 
            : base(name, age, gender)
        {
            Gender = kittenGender;
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
