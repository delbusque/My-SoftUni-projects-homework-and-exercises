using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace BankSafe.Tests
{
    public class BankVaultTests
    {
        private BankVault vault;
        private Item item;


        [SetUp]
        public void Setup()
        {
            vault = new BankVault();
            item = new Item("Peter", "1");
        }

        [Test]
        public void WhenCellDontExistThrowExeption()
        {
            Exception ex = Assert.Throws<ArgumentException>(() => 
            { 
                vault.AddItem("as", item); 
            });

            Assert.AreEqual(ex.Message, "Cell doesn't exists!");
        }
        [Test]
        public void WhenCellAlreadyTakenThrowExeption()
        {
            Exception ex = Assert.Throws<ArgumentException>(() =>
            {
                vault.AddItem("A3", item);
                vault.AddItem("A3", new Item("Hero", "A22"));
            });

            Assert.AreEqual(ex.Message, "Cell is already taken!");
        }

        [Test]
        public void WhenItemIsInCell()
        {
            Exception ex = Assert.Throws<InvalidOperationException>(() =>
            {
                vault.AddItem("A3", item);               
                vault.AddItem("A2", item);
            });

            Assert.AreEqual(ex.Message, "Item is already in cell!");
        }

        [Test]
        public void WhenItemAdded()
        {
            string result = vault.AddItem("A1", item);

            Assert.AreEqual(result, $"Item:{item.ItemId} saved successfully!");
        }

        [Test]
        public void WhenRemovingItemCellDontExistThrowExeption()
        {
            Exception ex = Assert.Throws<ArgumentException>(() =>
            {
                vault.RemoveItem("as", item);
            });

            Assert.AreEqual(ex.Message, "Cell doesn't exists!");
        }

        [Test]
        public void WhenRemovingItemDontExistThrowExeption()
        {
            Exception ex = Assert.Throws<ArgumentException>(() =>
            {
                vault.RemoveItem("A2", new Item("A", "qw1"));
            });

            Assert.AreEqual(ex.Message, "Item in that cell doesn't exists!");
        }

        [Test]
        public void WhenItemRemoved()
        {
            vault.AddItem("A1", item);
            string result = vault.RemoveItem("A1", item);

            Assert.AreEqual(result, $"Remove item:{item.ItemId} successfully!");
        }

        [Test]
        public void IfVaultIsInitializedCorrectly()
        {
            Dictionary<string, Item> initialCells = new Dictionary<string, Item>{
                {"A1", null},
                {"A2", null},
                {"A3", null},
                {"A4", null},
                {"B1", null},
                {"B2", null},
                {"B3", null},
                {"B4", null},
                {"C1", null},
                {"C2", null},
                {"C3", null},
                {"C4", null},
            };

            var initialCellsToList = initialCells.ToImmutableDictionary().ToList();
            var vaultCellsToList = vault.VaultCells.ToList();

            for (int i = 0; i < initialCellsToList.Count; i++)
            {
                var key = initialCellsToList[i].Key;
                var vaultKey = vaultCellsToList[i].Key;

                var value = initialCellsToList[i].Value;
                var vaultValue = vaultCellsToList[i].Value;

                Assert.AreEqual(key, vaultKey);
                Assert.AreEqual(value, vaultValue);
            }
        }
    }
}