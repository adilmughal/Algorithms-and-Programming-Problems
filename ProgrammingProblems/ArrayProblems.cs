using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingProblems
{
    public class ArrayProblems
    {
        public static int FindMaximumSubarray(int[] input)
        {
            int sum = 0;
            int maxSum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                sum += input[i];
                if (maxSum < sum)
                {
                    maxSum = sum;
                }

                if (sum < 0)
                    sum = 0;
            }
            return maxSum;
        }

        public static IEnumerable<TSource> FindDuplicateItems<TSource>(IEnumerable<TSource> input)
        {
            if (input == null)
                throw new ArgumentNullException("input");

            Dictionary<TSource, int> dictionary = new Dictionary<TSource, int>();

            foreach (TSource item in input)
                if (dictionary.ContainsKey(item))
                    dictionary[item] = dictionary[item] + 1;
                else
                    dictionary.Add(item, 1);

            foreach (KeyValuePair<TSource, int> entry in dictionary)
                if (entry.Value > 1)
                    yield return entry.Key;
        }


        public static int FindSingleDuplicateUsingSum(int[] input)
        {
            if (input == null)
                throw new ArgumentNullException("input");

            int n = input.Length;
            int sum = n*(n - 1)/2;
            int actualSum = 0;

            for (int index = 0; index < input.Length; index++)
                actualSum += input[index];

            return Math.Abs(actualSum - sum);
        }

        public static int FindSingleDuplicate(int[] input)
        {
            if (input == null)
                throw new ArgumentNullException("input");

            int index = 0;
            int xorValue = 0;

            while (index < input.Length)
                xorValue = xorValue ^ input[index++];

            index = 0;

            while (index < input.Length -1)
                xorValue = xorValue ^ input[index++];

            return input[xorValue-1];
        }

        public static IEnumerable<TSource> IsIntersection<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second)
        {
            if (first == null)
                throw new ArgumentNullException("first");
            if (second == null)
                throw new ArgumentNullException("second");

            HashSet<TSource> hashSet = new HashSet<TSource>();

            foreach (TSource item in first)
                hashSet.Add(item);

            foreach (TSource item in second)
                if (hashSet.Contains(item))
                    yield return item;
        }

        public static int[] IsIntersectionQuadratic(int[] first, int[] second)
        {
            if (first == null)
                throw new ArgumentNullException("first");
            if (second == null)
                throw new ArgumentNullException("second");

            int nFirst = first.Count();
            int nSecond = second.Count();

            List<int> result = new List<int>();

            for (int i = 0; i < nFirst; i++)
            {
                for (int j = 0; j < nSecond; j++)
                {
                    if (first[i] == second[j])
                        if (!result.Contains(first[i]))
                            result.Add(first[i]);
                }
            }

            return result.ToArray();
        }

        public static bool IsPermutation(int[] first, int[] second)
        {
            if (first.Length != second.Length)
                return false;

            Array.Sort(first);
            Array.Sort(second);

            for (int i = 0; i < first.Length; i++)
                if (first[i] != second[i])
                    return false;

            return true;
        }

        public static bool IsPermutationv2(int[] first, int[] second)
        {
            if (first.Length != second.Length)
                return false;

            if (first.Length == 1)
                return first[0] == second[0];

            Dictionary<int, int> hashCount = new Dictionary<int, int>(first.Length);

            foreach (int item in first)
                if (hashCount.ContainsKey(item))
                    hashCount[item] = hashCount[item] + 1;
                else
                    hashCount[item] = 1;

            foreach (int item in second)
                if (hashCount.ContainsKey(item))
                    hashCount[item] = hashCount[item] - 1;
                else
                    return false;

            foreach (KeyValuePair<int, int> item in hashCount)
                if (item.Value != 0)
                    return false;

            return true;
        }
    }
}