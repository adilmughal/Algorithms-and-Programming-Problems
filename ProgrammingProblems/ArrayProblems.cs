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
    }
}