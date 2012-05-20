using System;
using System.Text;

namespace ProgrammingProblems
{
    public class Manipulation
    {
        public static void Permute(string str)
        {
            int length = str.Length;
            var used = new bool[length];
            var output = new StringBuilder();
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