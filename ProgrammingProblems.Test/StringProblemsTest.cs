using NUnit.Framework;

namespace ProgrammingProblems.Test
{
    [TestFixture]
    public class StringProblemsTest
    {
        [Test]
        public void HasUniqueCharactersTest1()
        {
            string input = "adila";
            bool result = StringProblems.HasUniqueCharacters(input);
            Assert.AreEqual(false, result);
        }


        [Test]
        public void ReplaceSpacePositiveTest()
        {
            char[] input = "Adil Mughal".ToCharArray();
            char[] expectedOutput = "Adil%20Mughal".ToCharArray();
            Assert.AreEqual(expectedOutput, StringProblems.ReplaceSpace(input));


            input = "Adil Mughal ".ToCharArray();
            expectedOutput = "Adil%20Mughal%20".ToCharArray();
            Assert.AreEqual(expectedOutput, StringProblems.ReplaceSpace(input));
        }

        [Test]
        public void PerformCountCompressionPositiveTest()
        {
            string input = "aabcccaaa";
            string expectedOutput = "a2b1c3a3";
            Assert.AreEqual(expectedOutput, StringProblems.PerformCountCompression(input));

            input = "aabcdd";
            expectedOutput = "a2b1c1d2";
            Assert.AreEqual(expectedOutput, StringProblems.PerformCountCompression(input));

            input = "abcd";
            expectedOutput = "abcd";
            Assert.AreEqual(expectedOutput, StringProblems.PerformCountCompression(input));

        }
    }
}