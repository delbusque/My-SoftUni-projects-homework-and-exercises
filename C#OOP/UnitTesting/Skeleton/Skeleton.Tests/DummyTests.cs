using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestFixture]
    public class DummyTests
    {
        private Axe axe;
        private Dummy target;

        [SetUp]
        public void Initilized()
        {
            axe = new Axe(20, 20);
        }

        [Test]
        public void IsDummyLosingHealthAfterAttack()
        {
            target = new Dummy(100, 100);
            target.TakeAttack(20);

            Assert.That(target.Health, Is.EqualTo(80));
        }

        [Test]
        public void WhenAttackingDeadDummy()
        {
            target = new Dummy(0, 100);

            Assert.That(() => target.TakeAttack(1), Throws.InvalidOperationException
                .With.Message.EqualTo("Dummy is dead."));
        }

        [Test]
        public void DeadDummyGivesExperience()
        {
            target = new Dummy(0, 100);
            int experience = target.GiveExperience();

            Assert.That(experience, Is.EqualTo(100));
        }

        [Test]
        public void AliveDummyCantGiveExperience()
        {
            target = new Dummy(20, 100);

            Assert.That(() => target.GiveExperience(), Throws.InvalidOperationException
                .With.Message.EqualTo("Target is not dead."));
        }

    }
}