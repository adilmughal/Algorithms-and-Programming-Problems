using NUnit.Framework;

namespace ProgrammingProblems.Test
{
    [TestFixture]
    public class ArrayProblemsTest
    {
        [Test]
        public void FindMaxSubArrayPositiveTest()
        {
            var input = new[] {1, 5, 6, -1, -2, 0, 10};
            Assert.AreEqual(1, ArrayProblems.FindMaximumSubarray(input));
        }
    }
}