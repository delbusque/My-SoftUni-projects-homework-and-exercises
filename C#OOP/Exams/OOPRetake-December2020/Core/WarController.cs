using System;
using System.Collections.Generic;
using WarCroft.Entities.Characters;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Items;
using System.Linq;
using System.Text;

namespace WarCroft.Core
{
    public class WarController
    {
        Stack<Item> items = new Stack<Item>();
        List<Character> party = new List<Character>();

        public WarController()
        {
        }

        public string JoinParty(string[] args)
        {
            if (args[0] != "Warrior" && args[0] != "Priest")
            {
                throw new ArgumentException($"Invalid character type \"{args[0]}\"!");
            }

            if (args[0] == "Warrior")
            {
                Character character = new Warrior(args[1]);
                party.Add(character);
                return $"{character.Name} joined the party!";

            }
            else
            {
                Character character = new Priest(args[1]);
                party.Add(character);
                return $"{character.Name} joined the party!";
            }
        }

        public string AddItemToPool(string[] args)
        {
            if (args[0] != "FirePotion" && args[0] != "HealthPotion")
            {
                throw new ArgumentException($"Invalid item \"{args[0]}\"!");
            }

            if (args[0] == "FirePotion")
            {
                Item item = new FirePotion();
                items.Push(item);
                return $"{item.GetType().Name} added to pool.";
            }
            else
            {
                Item item = new HealthPotion();
                items.Push(item);
                return $"{item.GetType().Name} added to pool.";
            }
        }

        public string PickUpItem(string[] args)
        {
            string characterName = args[0];

            Character toPickItem = party.Find(ch => ch.Name == characterName);

            if (toPickItem == null)
            {
                throw new ArgumentException($"Character {characterName} not found!");
            }
            else
            {
                if (items.Count == 0)
                {
                    throw new InvalidOperationException($"No items left in pool!");
                }

                party.Remove(toPickItem);

                Type type = items.Peek().GetType();
                toPickItem.Bag.AddItem(items.Pop());
                party.Add(toPickItem);

                return $"{toPickItem.Name} picked up {type.Name}!";
            }
        }

        public string UseItem(string[] args)
        {
            string characterName = args[0];
            string itemType = args[1];

            Character toUseItem = party.Find(ch => ch.Name == characterName);

            if (toUseItem == null)
            {
                throw new ArgumentException($"Character {characterName} not found!");
            }
            else
            {
                party.Remove(toUseItem);

                foreach (var item in toUseItem.Bag.Items)
                {

                    switch (itemType)
                    {
                        case "FirePotion":
                            toUseItem.UseItem(item);
                            party.Add(toUseItem);
                            break;

                        case "HealthPotion":
                            toUseItem.UseItem(item);
                            party.Add(toUseItem);
                            break;
                    }
                }
                return $"{characterName} used {itemType}.";

            }
        }

        public string GetStats()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var character in party.OrderByDescending(ch => ch.IsAlive)
                .ThenBy(ch=>ch.Health).ToList())
            {
                sb.AppendLine(character.ToString());
            }

            return sb.ToString().TrimEnd();
        }

        public string Attack(string[] args)
        {
            string attackerName = args[0];
            string receiverName = args[1];

            Warrior attacker = new Warrior(attackerName);

            if (party.Contains(attacker))
            {
                Character reciever = party.Find(ch => ch.Name == receiverName);

                if (party.Contains(reciever))
                {
                    if (attacker.IsAlive && !reciever.IsAlive)
                    {
                        return $"{attackerName} cannot attack!";
                    }

                    attacker.Attack(reciever);
                    StringBuilder attack = new StringBuilder();

                    attack.AppendLine($"{attackerName} attacks {receiverName} for {attacker.AbilityPoints} hit points!");
                    attack.AppendLine($"{receiverName} has {reciever.Health}/{reciever.BaseHealth} HP and");
                    attack.AppendLine($"{reciever.Armor}/{reciever.BaseArmor} AP left!");

                    if (!reciever.IsAlive)
                    {
                        attack.AppendLine($"{reciever.Name} is dead!");
                    }

                    return attack.ToString();
                }
                else
                {
                    throw new ArgumentException($"Character {receiverName} not found!");
                }
            }
            else
            {
                throw new ArgumentException($"Character {attackerName} not found!");
            }
        }

        public string Heal(string[] args)
        {
            throw new NotImplementedException();
        }
    }
}
