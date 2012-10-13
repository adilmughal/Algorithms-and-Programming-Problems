using NUnit.Framework;

namespace ProgrammingProblems.Test
{
    [TestFixture]
    public class UnionFindTest
    {

        [Test]
        public void UnionFindPositiveTest()
        {
            UnionFind ufAlgorithm = new UnionFind();
            ufAlgorithm.Union(2, 3);
            ufAlgorithm.Union(5, 9);
            ufAlgorithm.Union(8, 3);
            ufAlgorithm.Union(4, 3);
            ufAlgorithm.Union(6, 4);
            ufAlgorithm.Union(2, 1);

            Assert.True(ufAlgorithm.IsConnected(5, 9));
        }
        [Test]
        public void UnionFindNegativeTest()
        {
            UnionFind ufAlgorithm = new UnionFind();
            ufAlgorithm.Union(1, 2);
            ufAlgorithm.Union(3, 4);
            ufAlgorithm.Union(5, 6);
            ufAlgorithm.Union(7, 8);
            ufAlgorithm.Union(7, 9);
            ufAlgorithm.Union(2, 8);
            ufAlgorithm.Union(0, 5);
            ufAlgorithm.Union(1, 9);

            Assert.False(ufAlgorithm.IsConnected(0, 8));
            Assert.False(ufAlgorithm.IsConnected(1, 3));
        }
    }
}
