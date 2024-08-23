using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DystopianSociety
{
    public class Citizen : IIdentifiable, ILivingCreater
    {
        public Citizen(string name, int age, string id)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public string Id { get; private set; }
        public int Age { get; private set; }
        public string Name { get ; private set ; }
        public DateOnly Birthday { get; private set; }

        public void setBirthday(DateOnly birthday) { 
        
            Birthday = birthday;
        }
    }
}
