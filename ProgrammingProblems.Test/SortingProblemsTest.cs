using NUnit.Framework;

namespace ProgrammingProblems.Test
{
    [TestFixture]
    public class SortingProblemsTest
    {
        [Test]
        public void InsertionSortTestHappyFlow()
        {
            var input = new[] { 2, 5, 3, 1, 7, 4, 9 };
            var expected = new[] { 1, 2, 3, 4, 5, 7, 9 };
            int[] actual = SortingProblems.InsertionSort(input);
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void InsertionSortTestWithNegativeNumbers()
        {
            var input = new[] { 2, 3, 1, -7, 4, 9 };
            var expected = new[] { -7, 1, 2, 3, 4, 9 };
            int[] actual = SortingProblems.InsertionSort(input);
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void MergeSortTestHappyFlow()
        {
            var input = new[] { 2, 5, 3, 1, 7, 4, 9 };
            var expected = new[] { 1, 2, 3, 4, 5, 7, 9 };
            int[] actual = SortingProblems.MergeSort(input);
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void MergeSortTestHappyFlow2()
        {
            var input = new[] { 2, 5, 3 };
            var expected = new[] { 2, 3, 5 };
            int[] actual = SortingProblems.MergeSort(input);
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void MergeSortTestWithNegativeNumbers()
        {
            var input = new[] { 2, 3, 1, -7, 4, 9 };
            var expected = new[] { -7, 1, 2, 3, 4, 9 };
            int[] actual = SortingProblems.MergeSort(input);
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void GroupSortPositiveTest()
        {
            var input = new[] {'B', 'R', 'B', 'G', 'G', 'R'};
            CollectionAssert.AreEqual(new[] {'B', 'B', 'R', 'R', 'G', 'G'}, SortingProblems.GroupSort(input));
        }

        [Test]
        public void TwoColorDutchNationalFlagPositiveTest()
        {
            var input = new[] { 'B', 'W', 'B', 'W', 'W' };
            CollectionAssert.AreEqual(new[] { 'B', 'B', 'W', 'W', 'W' }, SortingProblems.TwoColorsDutchNationalFlagSort(input));
        }

        [Test]
        public void ThreeColorDutchNationalFlagPositiveTest()
        {
            var input = new[] { 'B', 'R', 'B', 'G', 'G', 'R' };
            CollectionAssert.AreEqual(new[] { 'B', 'B', 'G', 'G', 'R', 'R' }, SortingProblems.ThreeColorsDutchNationalFlagSort(input));
        }
    }
}