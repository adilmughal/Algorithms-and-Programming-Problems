using NUnit.Framework;
using ProgrammingProblems.Strings;

namespace ProgrammingProblems.Test.Strings
{
    [TestFixture]
    public class ManipulationRemoveSpecifiedCharactersTest
    {
        [Test]
        public void RemoveSpecified()
        {
            string input = "adil ahmed mughal";
            string toRemove = "m";
            Assert.AreEqual("adil ahed ughal",
                            Manipulation.RemoveSpecifiedCharacters(input, toRemove));

        }
    }
}