using NUnit.Framework;

namespace ProgrammingProblems.Test
{
    [TestFixture]
    public class ArthmeticProblemsTest
    {
        [Test]
        public void DivideTestHappyFlow1()
        {
            double actual = ArthmeticProblems.DivideWithoutOperator(12, 3);
            Assert.AreEqual(4, actual);
        }

        [Test]
        public void GreatestCommonDivisorPositiveTest()
        {
            Assert.AreEqual(5, ArthmeticProblems.GreatestCommonDivisior(25, 20));

            Assert.AreEqual(4, ArthmeticProblems.GreatestCommonDivisior(12, 8));

            Assert.AreEqual(3, ArthmeticProblems.GreatestCommonDivisior(21, 6));
        }

        [Test]
        public void IterativeFibonacciFunctionalTest1()
        {
            int max = 10;
            int[] expected = {0, 1, 1, 2, 3, 5, 8};
            CollectionAssert.AreEqual(expected, ArthmeticProblems.IterativeFibonacci(max));
        }

        [Test]
        public void IterativeFibonacciFunctionalTest2()
        {
            int max = 0;
            int[] expected = {0};
            CollectionAssert.AreEqual(expected, ArthmeticProblems.IterativeFibonacci(max));
        }

        [Test]
        public void IterativeFibonacciFunctionalTest3()
        {
            int max = -1;
            int[] expected = {0};
            CollectionAssert.AreEqual(expected, ArthmeticProblems.IterativeFibonacci(max));
        }


        [Test]
        public void IterativeFibonacciFunctionalTest4()
        {
            int max = 13;
            int[] expected = {0, 1, 1, 2, 3, 5, 8, 13};
            CollectionAssert.AreEqual(expected, ArthmeticProblems.IterativeFibonacci(max));
        }

        [Test]
        public void LeastCommonMultipleByPrimeFactorizationPositiveTest()
        {
            Assert.AreEqual(42, ArthmeticProblems.LeastCommonMultipleByPrimeFactorization(21, 6));

            Assert.AreEqual(12, ArthmeticProblems.LeastCommonMultipleByPrimeFactorization(4, 6));
        }

        [Test]
        public void LeastCommonMultiplePositiveTest()
        {
            Assert.AreEqual(42, ArthmeticProblems.LeastCommonMultiple(21, 6));

            Assert.AreEqual(12, ArthmeticProblems.LeastCommonMultiple(4, 6));
        }

        [Test]
        public void MultiplyTestHappyFlow1()
        {
            double actual = ArthmeticProblems.MultiplyWithoutOperatorV2(4, 4);
            Assert.AreEqual(16, actual);
        }

        [Test]
        public void PrimeFactorsTest()
        {
            CollectionAssert.AreEqual(new[] {3, 5}, ArthmeticProblems.PrimeFactors(15));

            CollectionAssert.AreEqual(new[] {2, 5, 5}, ArthmeticProblems.PrimeFactors(50));

            CollectionAssert.AreEqual(new[] {17}, ArthmeticProblems.PrimeFactors(17));
        }

        [Test]
        public void PrimeTest()
        {
            Assert.True(ArthmeticProblems.IsPrime(3));

            Assert.False(ArthmeticProblems.IsPrime(4));

            Assert.True(ArthmeticProblems.IsPrime(5));

            Assert.True(ArthmeticProblems.IsPrime(7));

            Assert.False(ArthmeticProblems.IsPrime(9));

            Assert.True(ArthmeticProblems.IsPrime(17));
        }

        [Test]
        public void RecursiveFibonacciFunctionalTest1()
        {
            int max = 10;
            //          int[] expected = { 0, 1, 1, 2, 3, 5, 8 };
            int expected = 8;
            int actual = ArthmeticProblems.RecursiveFibonacci(10);
            Assert.AreEqual(8, actual);
        }

        [Test]
        public void RecursiveFibonacciFunctionalTest2()
        {
            int max = 0;
            int[] expected = {0};
            Assert.AreEqual(0, ArthmeticProblems.RecursiveFibonacci(max));
        }

        [Test]
        public void RecursiveFibonacciFunctionalTest3()
        {
            int max = -1;
            int[] expected = {0};
            Assert.AreEqual(0, ArthmeticProblems.RecursiveFibonacci(max));
        }


        [Test]
        public void RecursiveFibonacciFunctionalTest4()
        {
            int max = 13;
            int[] expected = {0, 1, 1, 2, 3, 5, 8, 13};
            Assert.AreEqual(13, ArthmeticProblems.RecursiveFibonacci(max));
        }

        [Test]
        public void ThreeNplusOneTest1()
        {
            int actualMaxCycleLength = ArthmeticProblems.ThreeNplusOne(1, 10);
            Assert.AreEqual(20, actualMaxCycleLength);
        }


        [Test]
        public void ThreeNplusOneTest2()
        {
            int actualMaxCycleLength = ArthmeticProblems.ThreeNplusOne(100, 200);
            Assert.AreEqual(125, actualMaxCycleLength);
        }


        [Test]
        public void ThreeNplusOneTest3()
        {
            int actualMaxCycleLength = ArthmeticProblems.ThreeNplusOne(201, 210);
            Assert.AreEqual(89, actualMaxCycleLength);
        }

        [Test]
        public void UnionFindNegativeTest()
        {
            var ufAlgorithm = new ArthmeticProblems.UnionFind();
            ufAlgorithm.Union(1, 2);
            ufAlgorithm.Union(3, 4);
            ufAlgorithm.Union(5, 6);
            ufAlgorithm.Union(7, 8);
            ufAlgorithm.Union(7, 9);
            ufAlgorithm.Union(2, 8);
            ufAlgorithm.Union(0, 5);
            ufAlgorithm.Union(1, 9);

            Assert.False(ufAlgorithm.IsConnected(0, 8));
            Assert.False(ufAlgorithm.IsConnected(1, 3));
        }

        [Test]
        public void UnionFindPositiveTest()
        {
            var ufAlgorithm = new ArthmeticProblems.UnionFind();
            ufAlgorithm.Union(2, 3);
            ufAlgorithm.Union(5, 9);
            ufAlgorithm.Union(8, 3);
            ufAlgorithm.Union(4, 3);
            ufAlgorithm.Union(6, 4);
            ufAlgorithm.Union(2, 1);

            Assert.True(ufAlgorithm.IsConnected(5, 9));
        }
    }
}