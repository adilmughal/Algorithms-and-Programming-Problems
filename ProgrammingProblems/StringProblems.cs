using System;

namespace ProgrammingProblems
{
    public class StringProblems
    {
        public static bool HasUniqueCharacters(string input)
        {
            var bitSet = new bool[256];

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentNullException("input");
            }

            char[] strCharArray = input.ToCharArray();

            foreach (char c in strCharArray)
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
    }
}