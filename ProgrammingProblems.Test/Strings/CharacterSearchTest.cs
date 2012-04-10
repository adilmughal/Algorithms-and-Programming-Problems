using System;
using NUnit.Framework;
using ProgrammingProblems.Strings;

namespace ProgrammingProblems.Test.Strings
{
    [TestFixture]
    public class CharacterSearchTest
    {
        [Test]
        [ExpectedException(typeof (ArgumentNullException))]
        public void TestEmptyStringInput()
        {
            CharacterSearch.HasUniqueCharacters(string.Empty);
        }

        [Test]
        [ExpectedException(typeof (ArgumentNullException))]
        public void TestNullStringInput()
        {
            CharacterSearch.HasUniqueCharacters(null);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestStringInput()
        {
            string str = "\r\n";
            CharacterSearch.HasUniqueCharacters(str);
        }
    }
}