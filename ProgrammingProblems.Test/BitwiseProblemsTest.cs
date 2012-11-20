using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace ProgrammingProblems.Test
{
    [TestFixture]
    public class BitwiseProblemsTest
    {
        [Test]
        public void ConvertToBase10PositiveTest()
        {
            byte input = (byte)2;
            Assert.AreEqual(2, BitwiseProblems.ConvertToBase10(input));

        }
        
        
    }
}
