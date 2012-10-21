using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace ProgrammingProblems.Test
{
    [TestFixture]
    public class ArrayProblemsTest
    {
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ArrayIntersectionExceptionTest()
        {
            var second = new[] { 2, 3, 8, 5, 6 };
            CollectionAssert.AreEquivalent(new[] { 5, 6 }, ArrayProblems.IsIntersection(null, second));
        }

        [Test]
        public void ArrayIntersectionMinBoundaryTest()
        {
            var first = new int[0] { };
            var second = new[] { 2, 3, 8, 5, 6 };

            CollectionAssert.AreEquivalent(new int[0] { }, ArrayProblems.IsIntersection(first, second));
            CollectionAssert.AreEquivalent(new int[0] { }, ArrayProblems.IsIntersection(new int[0] { }, new int[0] { }));
        }

        [Test]
        public void ArrayIntersectionPositiveTest()
        {
            var first = new[] { 1, 5, 6, 0, 10 };
            var second = new[] { 2, 3, 8, 5, 6 };
            CollectionAssert.AreEquivalent(new[] { 5, 6 }, ArrayProblems.IsIntersection(first, second));
        }

        [Test]
        public void ArrayIntersectionQuadraticPositiveTest()
        {
            var first = new[] { 1, 5, 6, 0, 10 };
            var second = new[] { 2, 3, 8, 5, 6 };
            CollectionAssert.AreEquivalent(new[] { 5, 6 }, ArrayProblems.IsIntersectionQuadratic(first, second));
        }

        [Test]
        public void FindMaxSubArrayPositiveTest()
        {
            var input = new[] { 1, 5, 6, -1, -2, 0, 10 };
            Assert.AreEqual(1, ArrayProblems.FindMaximumSubarray(input));
        }

        [Test]
        public void ArrayPermutationPositiveTest()
        {
            var first = new[] { 1, 5, 0, 10 };
            var second = new[] { 5, 10, 0, 1 };
            Assert.True(ArrayProblems.IsPermutation(first, second));
        }

        [Test]
        public void ArrayPermutationV2PositiveTest()
        {
            var first = new[] { 1, 5, 0, 10 };
            var second = new[] { 5, 10, 0, 1 };
            Assert.True(ArrayProblems.IsPermutationv2(first, second));
        }

        [Test]
        public void ArrayPermutationV2NegativeTest()
        {
            var first = new[] { -11, 5, 0, 10 };
            var second = new[] { 5, 10, 0, 1 };
            Assert.False(ArrayProblems.IsPermutationv2(first, second));
        }
    }
}