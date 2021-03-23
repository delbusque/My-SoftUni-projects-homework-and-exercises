using System;
using System.Collections.Generic;
using System.Text;
using WarCroft.Constants;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Inventory;

namespace WarCroft.Entities.Characters
{
    public class Warrior : Character, IAttacker
    {
        private Bag satchel = new Satchel();
        private double health = 100;
        private double armor = 50;
        private double abilityPoints = 40;

        public Warrior(string name)
            : base(name)
        {
            BaseHealth = this.health;
            BaseArmor = this.armor;
            AbilityPoints = this.abilityPoints;
            Bag = satchel;
        }

        public void Attack(Character character)
        {
            if (IsAlive)
            {
                if (character.IsAlive)
                {
                    if (character.Name == Name)
                    {
                        throw new InvalidOperationException(ExceptionMessages.CharacterAttacksSelf);
                    }
                    else
                    {
                        character.TakeDamage(AbilityPoints);
                    }
                }
            }
        }

         
    }
}
