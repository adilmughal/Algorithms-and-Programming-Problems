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
    }
}