using System;
using NUnit.Framework;
using ProgrammingProblems.Numeric;

namespace ProgrammingProblems.Test.Numeric
{
    [TestFixture]
    public class NumericManipulationMultiplyTest
    {
        [Test]
        public void MultiplyTestHappyFlow1()
        {
            double actual = 0;
            actual = OperationAndManipulation.Multiply(2, 3);
            Assert.AreEqual(6, actual);

            actual = OperationAndManipulation.Multiply(2, 5);
            Assert.AreEqual(10, actual);

            actual = OperationAndManipulation.Multiply(3, 5);
            Assert.AreEqual(15, actual);
        }


        [Test]
        public void MultiplyTestHappyFlow2()
        {
            double actual = 0;
            actual = OperationAndManipulation.Multiply(-2, 3);
            Assert.AreEqual(-6, actual);

            actual = OperationAndManipulation.Multiply(-10, 5);
            Assert.AreEqual(-50, actual);

            actual = OperationAndManipulation.Multiply(-3, 5);
            Assert.AreEqual(-15, actual);
        }

        [Test]
        public void MultiplyTestBoundaryTest1()
        {
            double actual = 0;
            actual = OperationAndManipulation.Multiply(int.MaxValue, 2);
            Assert.AreEqual(4294967294, actual);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void MultiplyTestBoundaryNegativeTest1()
        {
            double actual = 0;
            actual = OperationAndManipulation.Multiply(5, -2);
        }

        [Test]
        public void MultiplyTestBoundaryNegativeTest2()
        {
            double actual = 0;
            actual = OperationAndManipulation.Multiply(0, 100);
            Assert.AreEqual(0, actual);
        }

        [Test]
        public void MultiplyTestBoundaryNegativeTest3()
        {
            double actual = 0;
            actual = OperationAndManipulation.Multiply(5, 0);
            Assert.AreEqual(0, actual);
        }

        [Test]
        public void MultiplyTestBoundaryNegativeTest4()
        {
            double actual = 0;
            actual = OperationAndManipulation.Multiply(-1,0);
            Assert.AreEqual(0, actual);
        }

        [Test]
        public void MultiplyTestBoundaryTestMax()
        {
            double actual = 0;
            actual = OperationAndManipulation.Multiply(int.MaxValue, int.MaxValue);
           // Assert.GreaterOrEqual(4611686014132420609, actual);
        }


        [Test]
        public void Multiply2TestHappyFlow1()
        {
            double actual = 0;
            actual = OperationAndManipulation.Multiply2(2, 3);
            Assert.AreEqual(6, actual);

            actual = OperationAndManipulation.Multiply2(2, 5);
            Assert.AreEqual(10, actual);

            actual = OperationAndManipulation.Multiply2(3, 5);
            Assert.AreEqual(15, actual);
        }
    }
}