using System;
using NUnit.Framework;
using ProgrammingProblems.Strings;

namespace ProgrammingProblems.Test.Strings
{
    ///<summary>
    ///  This is a test class for RegexMatchTest and is intended
    ///  to contain all RegexMatchTest Unit Tests
    ///</summary>
    [TestFixture]
    public class RegexMatchTest
    {
        [Test]
        public void MatchTestDigitOnlyWithDigitRegex()
        {
            char[] input = "1231233254465".ToCharArray();
            char[] regex = "\\d+".ToCharArray();
            Assert.AreEqual(true, RegexMatch.Match(input, regex));
        }

        [Test]
        public void MatchTestDigitPlusRegex()
        {
            char[] input = "ab1".ToCharArray();
            char[] regex = "ab\\d+".ToCharArray();
            Assert.AreEqual(true, RegexMatch.Match(input, regex));
        }

        [Test]
        public void MatchTestDoubleDigitRegex()
        {
            char[] input = "ab1c2".ToCharArray();
            char[] regex = "ab\\dc\\d".ToCharArray();
            Assert.AreEqual(true, RegexMatch.Match(input, regex));
        }

        [Test]
        [ExpectedException(typeof (ArgumentException))]
        public void MatchTestEmptyLengthInput()
        {
            char[] input = "".ToCharArray();
            char[] regex = "adil".ToCharArray();
            RegexMatch.Match(input, regex);
        }

        [Test]
        public void MatchTestExample1()
        {
            char[] input = "abcd".ToCharArray();
            char[] regex = "bc".ToCharArray();
            Assert.AreEqual(true, RegexMatch.Match(input, regex));
        }

        [Test]
        public void MatchTestExample2()
        {
            char[] input = "ab".ToCharArray();
            char[] regex = "abc".ToCharArray();
            Assert.AreEqual(false, RegexMatch.Match(input, regex));
        }

        [Test]
        public void MatchTestExample3()
        {
            char[] input = "ab1c".ToCharArray();
            char[] regex = "ab\\dc".ToCharArray();
            Assert.AreEqual(true, RegexMatch.Match(input, regex));
        }

        [Test]
        public void MatchTestExample4()
        {
            char[] input = "ab123c".ToCharArray();
            char[] regex = "ab\\d+c".ToCharArray();
            Assert.AreEqual(true, RegexMatch.Match(input, regex));
        }

        [Test]
        public void MatchTestRegexGreaterLength()
        {
            char[] input = "di".ToCharArray();
            char[] regex = "adil".ToCharArray();
            Assert.AreEqual(false, RegexMatch.Match(input, regex));
        }

        [Test]
        public void MatchTestRepeatingDigitPlusRegex()
        {
            char[] input = "ad12il34".ToCharArray();
            char[] regex = "ad\\d+il\\d+".ToCharArray();
            Assert.AreEqual(true, RegexMatch.Match(input, regex));
        }

        [Test]
        public void MatchTestRepeatingDigitRegex()
        {
            char[] input = "ad12il".ToCharArray();
            char[] regex = "ad\\d\\dil".ToCharArray();
            Assert.AreEqual(true, RegexMatch.Match(input, regex));
        }

        [Test]
        public void MatchTestRepeatingPlusInput()
        {
            char[] input = "++1++".ToCharArray();
            char[] regex = "++\\d+++".ToCharArray();
            Assert.AreEqual(true, RegexMatch.Match(input, regex));
        }

        [Test]
        public void MatchTestWCharacter()
        {
            char[] input = "ab\\wc".ToCharArray();
            char[] regex = "ab\\wc".ToCharArray();
            Assert.AreEqual(true, RegexMatch.Match(input, regex));
        }
    }
}