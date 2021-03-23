using System;
using System.Collections.Generic;
using System.Text;
using WarCroft.Constants;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Inventory
{
    public abstract class Bag : IBag
    {
        private List<Item> items;
        private int load;
        protected const int capacity = 100;

        public Bag(int capacity = capacity)
        {
            Capacity = capacity;
            items = new List<Item>();
        }

        public int Capacity { get; set; }

        public int Load { get => load;
            set
            {
                foreach (var item in items)
                {
                    load += item.Weight;
                }
            }

        }

        public IReadOnlyCollection<Item> Items { get => items.AsReadOnly(); }



        public void AddItem(Item item)
        {
            int currentLoad = 0;
            foreach (var itemm in items)
            {
                currentLoad += itemm.Weight;
            }

            if (currentLoad + item.Weight > Capacity)
            {
                throw new InvalidOperationException(ExceptionMessages.ExceedMaximumBagCapacity);
            }

            items.Add(item);
        }

        public Item GetItem(string name)
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException(ExceptionMessages.EmptyBag);
            }
            else
            {
                foreach (var itemm in items)
                {
                    string type = itemm.GetType().Name;
                    if (type == name)
                    {
                        items.Remove(itemm);
                        return itemm;
                    }
                }

                throw new ArgumentException(ExceptionMessages.ItemNotFoundInBag, name);
            }
        }
    }
}
