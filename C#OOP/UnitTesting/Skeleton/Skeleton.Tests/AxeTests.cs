using System;
using NUnit.Framework;

[TestFixture]
public class AxeTests
{
    private Axe axe;
    private Dummy target;

    [SetUp]
    public void Initialize()
    {
        axe = new Axe(1, 1);
        target = new Dummy(100, 100);
    }

    [Test]
    public void IsAxeLoosingDurabilityAfterAttack()
    {
        axe.Attack(target);

        Assert.That(axe.DurabilityPoints, Is.EqualTo(0), "Axe Durability doesn`t change after attack.");
    }

    [Test]
    public void AttackingWithBrokenAxe()
    {
        axe.Attack(target);
        Assert.That(() => axe.Attack(target),
            Throws.InvalidOperationException.With.Message.EqualTo("Axe is broken."));
    }
}