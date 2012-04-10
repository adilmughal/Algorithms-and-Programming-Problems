﻿using NUnit.Framework;
using System;
using ProgrammingProblems.Strings;

namespace ProgrammingProblems.Test
{

    [TestFixture]
    public class TextSearchNaiveSearch2Test
    {
        [Test]
        [ExpectedException(typeof (ArgumentNullException))]
        public void TestEmptyStringInput()
        {
            TextSearch.NaiveSearch2(string.Empty, string.Empty);
        }

        [Test]
        [ExpectedException(typeof (ArgumentNullException))]
        public void TestNullStringInput()
        {
            TextSearch.NaiveSearch2(null, null);
        }

        [Test]
        public void TestStringInput1()
        {
            string text = "abcdefgababcead";
            string word = "abab";
            int actual = TextSearch.NaiveSearch2(text, word);

            Assert.AreEqual(7, actual);
        }

        [Test]
        public void TestStringInput2()
        {
            string text = "abcdefgababcead";
            string word = "abaaqweqw121231321weqeb";
            int actual = TextSearch.NaiveSearch2(text, word);

            Assert.AreEqual(-1, actual);
        }

        [Test]
        public void TestStringInput3()
        {
            string text = "123456543217321891234";
            string word = "321";
            int actual = TextSearch.NaiveSearch2(text, word);

            Assert.AreEqual(8, actual);
        }
    }
}
