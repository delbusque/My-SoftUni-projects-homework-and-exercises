using NUnit.Framework;

namespace Tests
{
    //using Database;
    using System;

    [TestFixture]
    public class DatabaseTests
    {
        Database data;

        [SetUp]
        public void Setup()
        {
            data = new Database();
        }

        [Test]
        public void CorrectlyInitiliazedData()
        {
            int[] arrayr = new int[16];
            data = new Database(arrayr);
            Assert.That(data.Count, Is.EqualTo(16));
        }

        [Test]
        public void IsCapacityCorect()
        {
            int[] arrayr = new int[17];

            Assert.Throws<InvalidOperationException>(() => new Database(arrayr));
        }

        [Test]
        public void ShouldAddElementIfEmptyCellAndIncreaseTheCount()
        {
            data.Add(1);
            int expectedCount = 1;
            int actualCount = data.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void ShouldThrowInvalidOperationIfExceeded16()
        {
            int[] arrayr = new int[16];
            data = new Database(arrayr);

            Assert.That(() => data.Add(1), Throws.InvalidOperationException
                .With.Message.EqualTo("Array's capacity must be exactly 16 integers!"));
        }

        [Test]
        public void ShouldDecreaseCounterWhenRemovingElement()
        {
            int[] arrayr = new int[10];
            data = new Database(arrayr);

            data.Remove();

            int[] newArray = data.Fetch();

            int expectedNewCount = 9;
            int newCount = newArray.Length;

            Assert.AreEqual(expectedNewCount, newCount);
        }

        [Test]
        public void ShouldRemoveLastElement()
        {
            int[] arrayr = new int[10];
            data = new Database(arrayr);

            data.Remove();

            int[] newArray = data.Fetch();

            int expectedValueAfterRemoval = 0;
            int removedElementValue = newArray[newArray.Length+1];
            
            Assert.AreEqual(expectedValueAfterRemoval, removedElementValue);
        }

        [Test]
        public void ShouldThrowExceptionIfDatabaseIsEmpty()
        {
            Assert.That(() => data.Remove(), Throws.InvalidOperationException
                .With.Message.EqualTo("The collection is empty!"));
        }
    }
}