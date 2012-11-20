using System;
using System.Collections.Generic;

namespace ProgrammingProblems
{
    public static class StringProblems
    {
        public static bool HasUniqueCharacters(string input)
        {
            //Assuming input supports ASCII encoding
            var bitSet = new bool[256];

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentNullException("input");
            }

            /* OPTIMIZATION
             * An ASCII encoded string since ASCII supports 256 chars unique max
             * so any input with length greater than 256 must contains duplicate characters
             */
            if (input.Length > 256)
                return false;

            foreach (char c in input)
            {
                int value = Convert.ToInt32(c);
                if (bitSet[value])
                {
                    return false;
                }
                bitSet[value] = true;
            }
            return true;
        }

        public static bool HasUniqueUnicodeCharacters(string input)
        {
            //This would do for Unicode string as well
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentNullException("input");

            var hashSet = new HashSet<char>();

            foreach (char c in input)
            {
                if (hashSet.Contains(c))
                    return false;
                hashSet.Add(c);
            }

            return true;
        }
    }
}