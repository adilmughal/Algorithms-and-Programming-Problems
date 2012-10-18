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

        public static IEnumerable<TSource> ArrayIntersection<TSource>(IEnumerable<TSource> first , IEnumerable<TSource> second)
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

        public static int[] ArrayIntersectionQuadratic(int[] first, int[] second)
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
    }
}