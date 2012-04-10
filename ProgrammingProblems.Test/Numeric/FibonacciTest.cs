using System;
using NUnit.Framework;
using ProgrammingProblems.Numeric;

namespace ProgrammingProblems.Test.Numeric
{
    [TestFixture]
    public class FibonacciTest
    {
        [Test]
        public void IterativeFibonacciFunctionalTest1()
        {
            int max = 10;
            int[] expected = {0, 1, 1, 2, 3, 5, 8};
            CollectionAssert.AreEqual(expected, Fibonacci.IterativeFibonacci(max));
        }

        [Test]
        public void IterativeFibonacciFunctionalTest2()
        {
            int max = 0;
            int[] expected = { 0 };
            CollectionAssert.AreEqual(expected, Fibonacci.IterativeFibonacci(max));
        }

        [Test]
        public void IterativeFibonacciFunctionalTest3()
        {
            int max = -1;
            int[] expected = { 0 };
            CollectionAssert.AreEqual(expected, Fibonacci.IterativeFibonacci(max));
        }


        [Test]
        public void IterativeFibonacciFunctionalTest4()
        {
            int max = 13;
            int[] expected = { 0, 1, 1, 2, 3, 5, 8, 13 };
            CollectionAssert.AreEqual(expected, Fibonacci.IterativeFibonacci(max));
        }

        [Test]
        public void RecursiveFibonacciFunctionalTest1()
        {
            int max = 10;
  //          int[] expected = { 0, 1, 1, 2, 3, 5, 8 };
            int expected = 8;
            int actual = Fibonacci.RecursiveFibonacci(10);
            Assert.AreEqual(8, actual);
        }

        [Test]
        public void RecursiveFibonacciFunctionalTest2()
        {
            int max = 0;
            int[] expected = { 0 };
            Assert.AreEqual(0, Fibonacci.RecursiveFibonacci(max));
        }

        [Test]
        public void RecursiveFibonacciFunctionalTest3()
        {
            int max = -1;
            int[] expected = { 0 };
            Assert.AreEqual(0, Fibonacci.RecursiveFibonacci(max));
        }


        [Test]
        public void RecursiveFibonacciFunctionalTest4()
        {
            int max = 13;
            int[] expected = { 0, 1, 1, 2, 3, 5, 8, 13 };
            Assert.AreEqual(13, Fibonacci.RecursiveFibonacci(max));
        }
    }
}
