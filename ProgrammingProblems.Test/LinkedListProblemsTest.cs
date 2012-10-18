using DataStructure;
using NUnit.Framework;

namespace ProgrammingProblems.Test
{
    [TestFixture]
    internal class LinkedListProblemsTest
    {
        [Test]
        public void CycleDetectionPositiveTest()
        {
            var linkedList = new LinkedList<int>();
            linkedList.Insert(1);
            linkedList.Insert(2);
            linkedList.Insert(3);
            linkedList.Insert(4);
            linkedList.Insert(5);
            linkedList.Insert(6);

            linkedList.Root.Next.Next.Next.Next.Next = linkedList.Root.Next;

            bool isFound = LinkedListProblems.IsCycleFound(linkedList);
            Assert.AreEqual(true, isFound);
        }

        [Test]
        public void FindFirstParticipatingNodeInCyclePositiveTest()
        {
            var linkedList = new LinkedList<int>();
            linkedList.Insert(1);
            linkedList.Insert(2);
            linkedList.Insert(3);
            linkedList.Insert(4);
            linkedList.Insert(5);
            linkedList.Insert(6);

            //Introduce a cycle
            linkedList.Root.Next.Next.Next.Next.Next = linkedList.Root.Next;

            LinkedListNode<int> result = LinkedListProblems.FindFirstParticipatingNodeInCycle(linkedList);
            Assert.AreEqual(2, result.Data);
        }

        [Test]
        public void RemoveDuplicateFromUnsortedListTest()
        {
            var linkedList = new LinkedList<int>();
            linkedList.Insert(1);
            linkedList.Insert(2);
            linkedList.Insert(8);
            linkedList.Insert(2);
            linkedList.Insert(3);
            linkedList.Insert(1);
            linkedList.Insert(4);

            int[] result = LinkedListProblems.RemoveDuplicateFromUnsortedList(linkedList).ToArray();

            CollectionAssert.AreEqual(new[] {4, 1, 3, 2, 8}, result);
        }
    }
}