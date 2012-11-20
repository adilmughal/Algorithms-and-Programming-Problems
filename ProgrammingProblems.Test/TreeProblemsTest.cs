using DataStructure;
using NUnit.Framework;

namespace ProgrammingProblems.Test
{
    [TestFixture]
    public class TreeProblemsTest
    {
        [Test]
        public void BinarySearchTreePositiveTest()
        {
            var bst = new BinarySearchTree<int, string>();
            bst.Add(10, "Mr. and Mrs. Iqbal Ahmed Mughal");
            bst.Add(1, "Sana");
            bst.Add(2, "Mehwish");
            bst.Add(3, "Adil");
            bst.Add(4, "Ammara");
            Assert.AreEqual("Ammara", bst.Retrieve(4));
        }
    }
}