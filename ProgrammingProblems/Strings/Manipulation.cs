using System;
using System.Collections;
using System.Text;

namespace ProgrammingProblems.Strings
{
    public class Manipulation
    {
        public static string Reverse(string input)
        {
            if (string.IsNullOrEmpty(input))
                throw new ArgumentNullException("input");

            if (input.Length == 1)
                return input;

            Char[] resultSet = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                resultSet[i] = input[input.Length - i - 1];
            }
            
            return new string(resultSet);
        }

        public static char[] Reverse(char[] str, int start, int end)
        {
            char temp;
            while (end > start)
            {
                /* Exchange characters */
                temp = str[start];
                str[start] = str[end];
                str[end] = temp;

                /* Move indices towards middle */
                start++; end--;
            }

            return str;
        }

        public static string ReverseWordOrder(string input)
        {
            if (string.IsNullOrEmpty(input))
                throw new ArgumentNullException("input");

            if (input.Length == 1)
                return input;

            char[] str = Reverse(input.ToCharArray(), 0, input.Length-1);

            int start = 0;
            int end = 0;
            int length = input.Length-1;

            while (end < input.Length)
            {
                if (str[end] != ' ')
                {
                    /* Save position of beginning of word */
                    start = end;

                    /* Scan to next non-word character */
                    while (end < length && str[end] != ' ')
                        end++;
                    /* Back up to end of word */
                    end--;

                    /* Reverse word */
                    Reverse(str, start, end);
                }
                end++;
            }


            return str.ToString() ;
        }
        
        public static string RemoveSpecifiedCharacters(string input, string toRemove)
        {
            if (string.IsNullOrEmpty(input))
                throw new ArgumentNullException("input");

            if (string.IsNullOrEmpty(toRemove))
                throw new ArgumentNullException("toRemove");

            bool[] charFlag= new bool[128];
            StringBuilder output=new StringBuilder();

            // Set flags for characters to be removed
            for (int i = 0; i < toRemove.Length; i++)
            {
                charFlag[toRemove[i]] = true;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (charFlag[input[i]] == false)
                    output.Append(input[i]);
            }

            return output.ToString();
        }

        public static void Permute(string str)
        {
            int length = str.Length;
            bool[] used = new bool[length];
            StringBuilder output = new StringBuilder();
            char[] input = str.ToCharArray();

            DoPermute(input, output, used, length, 0);
        }

        private static void DoPermute(char[] input, StringBuilder output, bool[] used, int length, int level)
        {
            if (level == length)
            {
                Console.WriteLine(output.ToString());
                return;
            }

            for (int i = 0; i < length; ++i)
            {
                if (used[i]) continue;

                output.Append(input[i]);
                used[i] = true;
                DoPermute(input, output, used, length, level + 1);
                used[i] = false;
                output.Length = output.Length - 1;

            }
        }
    }
}
