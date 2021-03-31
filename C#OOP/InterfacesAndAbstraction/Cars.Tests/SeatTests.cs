using NUnit.Framework;
using System;

namespace Cars.Tests
{
    [TestFixture]
    public class SeatTests
    {
        private Seat seat;


        [SetUp]
        public void Initializer()
        {
            seat = new Seat("Hello", "red");
        }

        [Test]
        public void IsEngineStarting()
        {
            Assert.That(() => seat.Start(), Is.EqualTo("Engine start"));
        }

        [Test]
        public void IsModelCorrectlyInitialized()
        {
            Assert.That(seat.Model, Is.EqualTo("Hello"));
        }        
    }
}
