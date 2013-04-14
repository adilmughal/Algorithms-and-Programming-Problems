using NUnit.Framework;

namespace DataStructure.Test
{
    [TestFixture]
    public class PriorityQueueTest
    {
        [Test]
        public void PriorityQueueDoubleDeleteTest()
        {
            PriorityQueue<int> pQueue = new PriorityQueue<int>(10);
            pQueue.Insert(4);
            pQueue.Insert(1);
            pQueue.Insert(3);
            pQueue.Insert(8);
            pQueue.Insert(0);
            Assert.AreEqual(0, pQueue.DeleteMin());
            Assert.AreEqual(1, pQueue.DeleteMin());
        }

        [Test]
        public void PriorityQueueSimpleTest()
        {
            PriorityQueue<int> pQueue = new PriorityQueue<int>(10);
            pQueue.Insert(4);
            pQueue.Insert(6);
            pQueue.Insert(3);
            pQueue.Insert(8);
            Assert.AreEqual(3, pQueue.DeleteMin());
        }
    }
}