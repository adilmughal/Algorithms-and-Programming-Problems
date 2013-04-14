using NUnit.Framework;

namespace DataStructure.Test
{
    [TestFixture]
    public class BinaryHeapTest
    {
        [Test]
        public void BinaryHeapDoubleDeleteTest()
        {
            BinaryHeap<int> binaryHeap = new BinaryHeap<int>(10);
            binaryHeap.Insert(4);
            binaryHeap.Insert(1);
            binaryHeap.Insert(3);
            binaryHeap.Insert(8);
            binaryHeap.Insert(0);
            Assert.AreEqual(8, binaryHeap.DeleteMax());
            Assert.AreEqual(4, binaryHeap.DeleteMax());
        }

        [Test]
        public void BinaryHeapInsertDeleteInsertTest()
        {
            BinaryHeap<int> binaryHeap = new BinaryHeap<int>(10);
            binaryHeap.Insert(4);
            binaryHeap.Insert(6);
            binaryHeap.Insert(3);
            binaryHeap.Insert(8);
            Assert.AreEqual(8, binaryHeap.DeleteMax());
            binaryHeap.Insert(10);
            Assert.AreEqual(10, binaryHeap.DeleteMax());
        }

        [Test]
        public void BinaryHeapSimpleTest()
        {
            BinaryHeap<int> binaryHeap = new BinaryHeap<int>(10);
            binaryHeap.Insert(4);
            binaryHeap.Insert(6);
            binaryHeap.Insert(3);
            binaryHeap.Insert(8);
            Assert.AreEqual(8, binaryHeap.DeleteMax());
        }
    }
}