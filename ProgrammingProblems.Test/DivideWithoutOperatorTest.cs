using NUnit.Framework;

namespace ProgrammingProblems.Test
{
    [TestFixture]
    public partial class NumericTest
    {
        [Test]
        public void DivideTestHappyFlow1()
        {
            double actual = Numeric.DivideWithoutOperator(12, 3);
            Assert.AreEqual(4, actual);
        }
    }
}