using NUnit.Framework;

namespace ProgrammingProblems.Test
{
    [TestFixture]
    public partial class SortingTest
    {
        [Test]
        public void MergeSortTestHappyFlow()
        {
            var input = new[] {2, 5, 3, 1, 7, 4, 9};
            var expected = new[] {1, 2, 3, 4, 5, 7, 9};
            int[] actual = Sorting.MergeSort(input);
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void MergeSortTestHappyFlow2()
        {
            var input = new[] {2, 5, 3};
            var expected = new[] {2, 3, 5};
            int[] actual = Sorting.MergeSort(input);
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void MergeSortTestWithNegativeNumbers()
        {
            var input = new[] {2, 3, 1, -7, 4, 9};
            var expected = new[] {-7, 1, 2, 3, 4, 9};
            int[] actual = Sorting.MergeSort(input);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}