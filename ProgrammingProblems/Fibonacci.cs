using System.Collections.Generic;

namespace ProgrammingProblems
{
    public partial class Numeric
    {
        public static int[] IterativeFibonacci(int max)
        {
            if (max < 1)
                return new[] {0};

            var result = new List<int>(new[] {0, 1});

            int n = 2;

            while (true)
            {
                int sum = result[n - 1] + result[n - 2];
                if (sum > max)
                    break;
                result.Insert(n, sum);
                n++;
            }
            return result.ToArray();
        }

        public static int RecursiveFibonacci(int n)
        {
            if (n == 0 || n == 1)
                return n;

            else if (n > 1)
                return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);

            else return -1;
        }
    }
}