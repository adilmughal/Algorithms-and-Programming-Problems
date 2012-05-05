using NUnit.Framework;
using ProgrammingProblems;

namespace ProgrammingProblems.Test
{
    [TestFixture]
    public class ManipulationRemoveSpecifiedCharactersTest
    {
        [Test]
        public void RemoveSpecified()
        {
            string input = "adil ahmed mughal";
            string toRemove = "m";
            Assert.AreEqual("adil ahed ughal", ProgrammingProblems.Strings.RemoveSpecifiedCharacters(input, toRemove));

        }
    }
}