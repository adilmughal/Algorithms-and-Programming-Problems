using System;
using System.Collections.Generic;

namespace ProgrammingProblems.Strings
{
    public class RegexMatch
    {
        public static bool Match(char[] input, char[] regex)
        {
            if (input.Length == 0)
                throw new ArgumentException("input");

            if (regex.Length == 0)
                throw new ArgumentException("regex");

            Queue<char> queue = new Queue<char>(input);

            int rIndex = 0;

            while (queue.Count > 0)
            {
                char c = queue.Dequeue();
                if (IsThisADigitChar(c))
                {
                    if (RegexContainsDigitEquivalent(regex, rIndex))
                    {
                        rIndex += 2; //advance the regex array index by 2 for \\d
                        if (RegexContainsDigitPlusEquivalent(regex, rIndex))
                        {
                            rIndex++; //advance the regex array index by 1 for '+' after \\d
                            while (queue.Count > 0 && IsThisADigitChar(queue.Peek()))
                                queue.Dequeue();
                        }
                    }
                }
                else if (regex[rIndex] == c)
                {
                    rIndex++;
                }
                else
                {
                    //if half matched Regex then reset index
                    rIndex = 0;
                }

                if (rIndex == regex.Length)
                    return true;
            }

            return false;
        }

        private static bool RegexContainsDigitPlusEquivalent(char[] regex, int rIndex)
        {
            return (rIndex < regex.Length) && (regex[rIndex] == '+');
        }

        private static bool RegexContainsDigitEquivalent(char[] regex, int rIndex)
        {
            return (rIndex < regex.Length - 1) && (regex[rIndex] == '\\' && regex[rIndex + 1] == 'd');
        }

        private static bool IsThisADigitChar(char input)
        {
            return (input >= '0') && (input <= '9');
        }
    }
}