using System;
using NUnit.Framework;

namespace ProgrammingProblems.Test
{
    [TestFixture]
    internal class StackAndQueueProblemsTest
    {
        [Test]
        [ExpectedException(typeof (Exception))]
        public void QueueUsingTwoStacksExceptionTest()
        {
            var queue = new StackAndQueueProblems.QueueUsingTwoStacks<char>(10);
            queue.Enqueue('a');
            queue.Dequeue();
            queue.Dequeue();
        }

        [Test]
        public void QueueUsingTwoStacksPositiveTest()
        {
            var queue = new StackAndQueueProblems.QueueUsingTwoStacks<char>(10);
            queue.Enqueue('a');
            queue.Enqueue('b');
            queue.Enqueue('c');
            Assert.IsTrue(queue.Dequeue() == 'a');

            queue.Enqueue('d');
            queue.Enqueue('f');
            Assert.IsTrue(queue.Dequeue() == 'b');
        }
    }
}