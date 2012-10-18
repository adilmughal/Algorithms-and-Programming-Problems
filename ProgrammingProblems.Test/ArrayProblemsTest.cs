using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace ProgrammingProblems.Test
{
    [TestFixture]
    public class ArrayProblemsTest
    {
        [Test]
        [ExpectedException(typeof (ArgumentNullException))]
        public void ArrayIntersectionExceptionTest()
        {
            IEnumerable<int> first = null;
            var second = new[] {2, 3, 8, 5, 6};
            CollectionAssert.AreEquivalent(new[] {5, 6}, ArrayProblems.ArrayIntersection(first, second));
        }

        [Test]
        public void ArrayIntersectionMinBoundaryTest()
        {
            var first = new int[0] {};
            var second = new[] {2, 3, 8, 5, 6};

            CollectionAssert.AreEquivalent(new int[0] {}, ArrayProblems.ArrayIntersection(first, second));
            CollectionAssert.AreEquivalent(new int[0] {}, ArrayProblems.ArrayIntersection(new int[0] {}, new int[0] {}));
        }

        [Test]
        public void ArrayIntersectionPositiveTest()
        {
            var first = new[] {1, 5, 6, 0, 10};
            var second = new[] {2, 3, 8, 5, 6};
            CollectionAssert.AreEquivalent(new[] {5, 6}, ArrayProblems.ArrayIntersection(first, second));
        }

        [Test]
        public void ArrayIntersectionQuadraticPositiveTest()
        {
            var first = new[] {1, 5, 6, 0, 10};
            var second = new[] {2, 3, 8, 5, 6};
            CollectionAssert.AreEquivalent(new[] {5, 6}, ArrayProblems.ArrayIntersectionQuadratic(first, second));
        }

        [Test]
        public void FindMaxSubArrayPositiveTest()
        {
            var input = new[] {1, 5, 6, -1, -2, 0, 10};
            Assert.AreEqual(1, ArrayProblems.FindMaximumSubarray(input));
        }
    }
}