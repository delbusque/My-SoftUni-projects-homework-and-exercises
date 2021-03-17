using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class RaidGroup
    {
        private List<BaseHero> raGroup;

        public RaidGroup()
        {
            raGroup = new List<BaseHero>();
            RaGroup = raGroup;
        }
        public List<BaseHero> RaGroup { get; set; }

        public void MakeHero(string name, string heroType)
        {
            if (heroType == "Druid")
            {
                BaseHero hero = new Druid(name);
                raGroup.Add(hero);
            }

            else if (heroType == "Paladin")
            {
                BaseHero hero = new Paladin(name);
                raGroup.Add(hero);
            }

            else if (heroType == "Rogue")
            {
                BaseHero hero = new Rogue(name);
                raGroup.Add(hero);
            }

            else if (heroType == "Warrior")
            {
                BaseHero hero = new Warrior(name);
                raGroup.Add(hero);
            }
        }
    }
}
