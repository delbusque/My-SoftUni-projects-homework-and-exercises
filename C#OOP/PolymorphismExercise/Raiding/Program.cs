using System;
using System.Collections.Generic;

namespace Raiding
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            RaidGroup raGroup = new RaidGroup();


            while (raGroup.RaGroup.Count < n)
            {

                string name = Console.ReadLine();
                string heroType = Console.ReadLine();

                if (heroType != "Druid" && heroType != "Paladin" && heroType != "Rogue" && heroType != "Warrior")
                {
                    Console.WriteLine("Invalid hero!");
                }
                else
                {
                    raGroup.MakeHero(name, heroType);
                }
            }

            int bossPower = int.Parse(Console.ReadLine());
            int raPower = 0;
            
            foreach (var item in raGroup.RaGroup)
            {
                Console.WriteLine($"{item.CastAbility()}");
                raPower += item.Power;
            }

            if (raPower >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }

        }


    }
}
