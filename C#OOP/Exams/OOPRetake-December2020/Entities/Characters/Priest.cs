using System;
using System.Collections.Generic;
using System.Text;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Inventory;
using WarCroft.Entities.Inventory.Contracts;

namespace WarCroft.Entities.Characters
{
    public class Priest : Character, IHealer
    {
        private Bag backPack = new Backpack();
        private double health = 50;
        private double armor = 25;
        private double abilityPoints = 40;

        public Priest(string name) 
            : base(name)
        {
            BaseHealth = this.health;
            BaseArmor = this.armor;
            AbilityPoints = this.abilityPoints;
            Bag = backPack;
        }

        public void Heal(Character character)
        {
            if (IsAlive)
            {
                if (character.IsAlive)
                {
                    character.Health += AbilityPoints;
                }
            }
        }
    }
}
