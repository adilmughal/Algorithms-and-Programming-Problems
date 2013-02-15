using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
             * An ASCII encoded string since ASCII supports 0-255 chars unique max
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

        public static char[] ReplaceSpace(char[] input)
        {
            /* Replaces space ' ' in char[] with %20 */

            int spaceCount = input.Count(c => c == ' ');
            int newLength = input.Length + spaceCount * 2;
            char[] output = new char[newLength];

            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (input[i] == ' ')
                {
                    output[newLength - 1] = '0';
                    output[newLength - 2] = '2';
                    output[newLength - 3] = '%';
                    newLength -= 3;
                }
                else
                {
                    output[newLength - 1] = input[i];
                    newLength -= 1;
                }
            }
            return output;
        }

        public static string PerformCountCompression(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentException("input");

            if (HasUniqueCharacters(input))
                return input;

            if (input.Length == 1)
                return input;

            int currentChar = 0;
            StringBuilder output=new StringBuilder();

            while (currentChar < input.Length)
            {
                int counter = 1;
                output.Append(input[currentChar]);
                while ( (currentChar+counter) < input.Length && 
                    input[currentChar] == input[currentChar + counter])
                    counter++;
                output.Append(counter);
                currentChar += counter;
            }

            return output.ToString();
        }
    }
}