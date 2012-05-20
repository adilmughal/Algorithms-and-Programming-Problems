namespace ProgrammingProblems
{
    public partial class Sorting
    {
        /***********************************************************************************************
         *  Problem: 
         *  Sort an array using Merge Sort algorithm
         * 
         *  Assumptions/Clarification: 
         *  Input [a1,a2,a3,...,aN] where a1, a2, a3,...,aN are whole numbers 
         *  RETURNS
         *  Input[a1',a2',a3',...,aN'] such that a1'<=a2'<=a3'... <=aN' AND N > 1
         *  
         *  Approach:
         *  Divide and Conquer
         * 
         *  Pseudocode:
         *  BEGIN

         *  END
         */

        public static int[] MergeSort(int[] input)
        {
            return MergeSort(ref input, 0, input.Length - 1);
        }

        public static int[] MergeSort(ref int[] input, int low, int high)
        {
            if (low < high)
            {
                int middle = (low + high) / 2; /* index of middle element */
                MergeSort(ref input, low, middle);
                MergeSort(ref input, middle + 1, high);
                Merge(ref input, low, middle, high);
            }
            return input;
        }

        private static void Merge(ref int[] input, int low, int middle, int high)
        {
            int resultIndex = 0;
            int leftCounter = low;
            int rightCounter = middle+1;
            int[] resultSet = new int[high-low+1];

            while (leftCounter <= middle && rightCounter <= high)
            {
                if (input[leftCounter] > input[rightCounter])
                {
                    resultSet[resultIndex] = input[leftCounter];
                    leftCounter++;
                }
                else
                {
                    resultSet[resultIndex] = input[rightCounter];
                    rightCounter++;
                }
                resultIndex++;
            }

            while (leftCounter <=middle)
            {
                resultSet[resultIndex++] = input[leftCounter++];
            }

            while (rightCounter <= high)
            {
                resultSet[resultIndex++] = input[rightCounter++];
            }

            for (int i = 0; i < resultSet.Length; i++)
            {
                input[i] = resultSet[i];
            }
        }

        //private int[] MergeSort(int[] input)
        //{
        //    if (input.Length == 1)
        //        return input;

        //    int middle = input.Length / 2;

        //    int[] left = new int[middle];

        //    for (int i = 0; i < middle; i++)
        //    {
        //        left[i] = input[i];
        //    }
        //    int[] right = new int[input.Length - middle];
        //    for (int i = 0; i < input.Length - middle; i++)
        //    {
        //        right[i] = input[i + middle];
        //    }
        //    left = MergeSort(left);
        //    right = MergeSort(right);

        //    int leftptr = 0;
        //    int rightptr = 0;

        //    int[] sorted = new int[input.Length];
        //    for (int k = 0; k < input.Length; k++)
        //    {
        //        if (rightptr == right.Length || ((leftptr < left.Length) && (left[leftptr] <= right[rightptr])))
        //        {
        //            sorted[k] = left[leftptr];
        //            leftptr++;
        //        }
        //        else if (leftptr == left.Length || ((rightptr < right.Length) && (right[rightptr] <= left[leftptr])))
        //        {
        //            sorted[k] = right[rightptr];
        //            rightptr++;
        //        }
        //    }
        //    return sorted;
        //}
    }

}