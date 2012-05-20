using NUnit.Framework;

namespace ProgrammingProblems.Test
{
    [TestFixture]
    public partial class StringsTest
    {
        [Test]
        public void HasUniqueCharactersTest1()
        {
            string input = "adila";
            bool result = Strings.HasUniqueCharacters(input);
            Assert.AreEqual(false, result);
        }
    }
}