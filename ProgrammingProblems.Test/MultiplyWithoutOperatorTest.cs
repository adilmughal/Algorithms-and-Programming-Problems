using NUnit.Framework;

namespace ProgrammingProblems.Test
{
    [TestFixture]
    public partial class NumericTest
    {
        [Test]
        public void MultiplyTestHappyFlow1()
        {
            double actual = Numeric.MultiplyWithoutOperatorV2(4, 4);
            Assert.AreEqual(16, actual);
        }
    }
}