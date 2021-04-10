namespace Aquariums.Tests
{
    using NUnit.Framework;
    using System;

    public class AquariumsTests
    {
        private Fish fish;
        private Aquarium aquarium;

        [SetUp]
        public void Setup()
        {
            fish = new Fish("Bubbly");
            aquarium = new Aquarium("MyAqua", 3);
        }

        [Test]
        public void WhenAddingFish()
        {
            aquarium.Add(fish);
            aquarium.Add(new Fish("Jubbly"));
            aquarium.Add(new Fish("Jubb"));

            Assert.Throws<InvalidOperationException>(() => aquarium.Add(new Fish("ubbly")));
        }

        [Test]
        public void RemoveFish()
        {
            Assert.Throws<InvalidOperationException>(() => aquarium.RemoveFish(fish.Name));
        }

        [Test]
        public void RemoveCorectly()
        {
            aquarium.Add(fish);
            aquarium.RemoveFish(fish.Name);

            Assert.AreEqual(0, aquarium.Count);
        }

        [Test]
        public void ThrowInvalidOperationEx()
        {
            Assert.Throws<InvalidOperationException>(() => aquarium.SellFish(fish.Name));
        }

        [Test]
        public void ForReport()
        {
            aquarium.Add(fish);

            string result = $"Fish available at {aquarium.Name}: {fish.Name}";

            Assert.AreEqual(result, aquarium.Report());
        }

        [Test]
        public void SetAvailable()
        {
            aquarium.Add(fish);
            aquarium.SellFish(fish.Name);

            Assert.IsFalse(fish.Available);
        }

    }
}
