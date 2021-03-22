using System;

using WarCroft.Constants;
using WarCroft.Entities.Inventory;

namespace WarCroft.Entities.Characters.Contracts
{
    public abstract class Character
    {
		private string name;
		private double health;
		private double armor;

        public Character(string name, double health, double armor, double abilityPoints, Bag bag)
        {
			Name = name;
			Health = health;
			Armor = armor;
			AbilityPoints = abilityPoints;
			Bag = bag;
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



		protected void EnsureAlive()
		{
			if (!this.IsAlive)
			{
				throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
			}
		}
	}
}