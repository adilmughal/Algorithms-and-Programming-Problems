using System;
using System.Collections.Generic;

namespace ProgrammingProblems.Strings
{
    public class CharacterSearch
    {
        public static char FindFirstRepeatedCharacter(char[] input)
        {
            if (input.Length <= 0)
                return '0';
            Dictionary<char, int> dictionary = new Dictionary<char, int>(128);

            for (int i = 0; i < input.Length; i++)
            {
                var c = input[i];
                if (dictionary.ContainsKey(c))
                {
                    dictionary[c] = dictionary[c] + 1;
                }
                else
                {
                    dictionary.Add(c, 1);
                }
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (dictionary[input[i]] == 1)
                    return input[i];
            }
            return '\0';
        }

        public static bool HasUniqueCharacters(string input)
        {
            bool[] bitSet = new bool[256];

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentNullException("input");
            }

            char[] strCharArray = input.ToCharArray();

            foreach (var c in strCharArray)
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