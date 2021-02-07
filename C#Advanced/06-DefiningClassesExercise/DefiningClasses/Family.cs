using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        public Family(List<Person> members)
        {
            Members = members;
        }

        public List<Person> Members { get; set; }

        public void AddMember(Person member)
        {
            
            Members.Add(member);
        }

        public Person GetOldestMember(List<Person> members)
        {
            Person oldestMember = new Person();
            
            foreach (var member in members.OrderByDescending(m=>m.Age))
            {
                oldestMember = member;
                break;
            }

            return oldestMember;
        }
    }
}
