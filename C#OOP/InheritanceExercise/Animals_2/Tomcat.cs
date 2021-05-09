using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Tomcat : Cat
    {
        private const string tomcatGender = "male";
        
        public Tomcat(string name, int age, string gender) 
            : base(name, age, gender)
        {
            Gender = tomcatGender;
        }

        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}
