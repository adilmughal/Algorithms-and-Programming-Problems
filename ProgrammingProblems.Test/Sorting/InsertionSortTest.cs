using NUnit.Framework;

namespace ProgrammingProblems.Test
{
    [TestFixture]
    public partial class SortingTest
    {
        [Test]
        public void InsertionSortTestHappyFlow()
        {
            var input = new[] {2, 5, 3, 1, 7, 4, 9};
            var expected = new[] {1, 2, 3, 4, 5, 7, 9};
            int[] actual = Sorting.InsertionSort(input);
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void InsertionSortTestWithNegativeNumbers()
        {
            var input = new[] {2, 3, 1, -7, 4, 9};
            var expected = new[] {-7, 1, 2, 3, 4, 9};
            int[] actual = Sorting.InsertionSort(input);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}