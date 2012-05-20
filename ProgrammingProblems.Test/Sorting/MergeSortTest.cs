﻿using NUnit.Framework;

namespace ProgrammingProblems.Test
{
    [TestFixture]
    public partial class SortingTest
    {
        #region Insertion Sort Test

        [Test]
        public void MergeSortTestHappyFlow()
        {
            int[] input = new int[] { 2, 5, 3, 1, 7, 4, 9 };
            int[] expected = new int[] { 1, 2, 3, 4, 5, 7, 9 };
            int[] actual = Sorting.MergeSort(input);
            CollectionAssert.AreEqual(expected, actual);
        }
        [Test]
        public void MergeSortTestHappyFlow2()
        {
            int[] input = new int[] { 2, 5,3};
            int[] expected = new int[] { 2, 3, 5 };
            int[] actual = Sorting.MergeSort(input);
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void MergeSortTestWithNegativeNumbers()
        {
            int[] input = new int[] { 2, 3, 1, -7, 4, 9 };
            int[] expected = new int[] { -7, 1, 2, 3, 4, 9 };
            int[] actual = Sorting.MergeSort(input);
            CollectionAssert.AreEqual(expected, actual);
        }

        #endregion
    }
}