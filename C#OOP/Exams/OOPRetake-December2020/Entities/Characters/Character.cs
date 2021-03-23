using System;

using WarCroft.Constants;
using WarCroft.Entities.Inventory;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Characters.Contracts
{
    public abstract class Character
    {
		private string name;

        protected Character(string name, double health, double armor, double abilityPoints, Bag bag)
        {
			Name = name;
			BaseHealth = health;
			Health = health;
			BaseArmor = armor;
			Armor = armor;
			AbilityPoints = abilityPoints;
			Bag = bag;
        }

		protected Character(string name)
		{
			Name = name;
		}

		public string Name 
		{ get => name;
			set
			{
                if (string.IsNullOrWhiteSpace(value))
                {
					throw new ArgumentException(ExceptionMessages.CharacterNameInvalid);
                }
				name = value;
			}
		}

        public double BaseHealth { get; set; }

		public double Health { get; set; }

		public double BaseArmor { get; set; }
		public double Armor { get; set; }

		public double AbilityPoints { get; set; }

        public Bag Bag { get; set; }

        public bool IsAlive { get; set; } = true;

		public void TakeDamage(double hitPoints)
        {
            if (IsAlive)
            {
                if (Armor - hitPoints >= 0)
                {
					Armor -= hitPoints;
				}
                else
                {
					Armor = 0;
					double leftHitPoints = hitPoints - Armor;

                    if (Health - leftHitPoints > 0)
                    {
						Health -= leftHitPoints;
                    }
                    else
                    {
						Health = 0;
						IsAlive = false;
                    }
                }
            }
        }

		public void UseItem(Item item)
        {
			EnsureAlive();  
			item.AffectCharacter(this);
        }

		protected void EnsureAlive()
		{
			if (!this.IsAlive)
			{
				throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
			}
		}
	}
}