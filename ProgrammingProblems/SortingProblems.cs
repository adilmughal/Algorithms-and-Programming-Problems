using System;

namespace ProgrammingProblems
{
    public class SortingProblems
    {
        /***********************************************************************************************
                 *  Problem: 
                 *  Sort an array using Insertion Sort
                 * 
                 *  Assumptions/Clarification: 
                 *  Input [a1,a2,a3,...,aN] where a1, a2, a3,...,aN are whole numbers 
                 *  RETURNS
                 *  Input[a1',a2',a3',...,aN'] such that a1'<=a2'<=a3'... <=aN' AND N > 1
                 *  
                 *  Approach:
                 *  Iterative
                 *  
                 *  Pseudocode:
                 *  BEGIN
                 *      LOOP (FOR) j=2 to N
                 *          MinKey = Input[j]
                 *          i = j-1
                 *          LOOP (WHILE) Input[i]>MinKey AND i > 0
                 *              Input[i+1] = Input[i]
                 *              i=i-1
                 *          END LOOP
                 *          Input[i] = MinKey
                 *      END LOOP
                 *  END
                 */

        public static int[] InsertionSort(int[] input)
        {
            for (int j = 1; j < input.Length; j++)
            {
                int i = j - 1;
                int minKey = input[j];
                while (i >= 0 && (input[i] > minKey))
                {
                    input[i + 1] = input[i];
                    i = i - 1;
                }
                input[i + 1] = minKey;
            }
            return input;
        }

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

        public static void MergeSort(int[] input)
        {
            MergeSort(input, 0, input.Length - 1);
        }

        private static void MergeSort(int[] input, int low, int high)
        {
            if (low >= high)
                return;

            int middle = low + (high - low) / 2;/* index of middle element */
      
            MergeSort(input, low, middle);
            MergeSort(input, middle + 1, high);
            Merge(input, low, middle, high);
        }

        private static void Merge(int[] input, int low, int middle, int high)
        {
            int leftCounter = low;
            int rightCounter = middle + 1;
            var resultSet = new int[high - low + 1];

            for (int rIndex = low; rIndex <= high; rIndex++)
            {
                if (leftCounter > middle)
                    resultSet[rIndex-low] = input[rightCounter++];
                else if (rightCounter > high)
                    resultSet[rIndex-low] = input[leftCounter++];
                else if (input[leftCounter] < input[rightCounter])
                    resultSet[rIndex-low] = input[leftCounter++];
                else
                    resultSet[rIndex-low] = input[rightCounter++];
            }

            for (int i = 0; i < resultSet.Length; i++)
                input[i+low] = resultSet[i];
        }

        public static char[] TwoColorsDutchNationalFlagSort(char[] input)
        {
            int low = 0;
            int high = input.Length - 1;
            while (low < high)
            {
                if (input[low] == 'B')
                    low++;
                else
                    Swap(input, low, high--);
            }
            return input;
        }

        public static char[] ThreeColorsDutchNationalFlagSort(char[] input)
        {
            int low = 0;
            int high = input.Length - 1;
            int mid = 0;

            while (mid < high)
            {
                switch (input[mid])
                {
                    case 'B':
                        Swap(input, low, mid);
                        low++;
                        mid++;
                        break;
                    case 'G':
                        mid++;
                        break;
                    case 'R':
                        Swap(input, mid, high);
                        high--;
                        break;
                }
            }
            return input;
        }

        public static char[] FourColorsDutchNationalFlagSort(char[] input)
        {
            int low = 0;
            int high = input.Length - 1;
            int mid = 0;
            int mid2 = input.Length - 1;

            while (mid < mid2)
            {
                switch (input[mid])
                {
                    case 'B':
                        Swap(input, low, mid);
                        low++;
                        mid++;
                        break;
                    case 'G':
                        mid++;
                        break;
                    case 'R':
                        Swap(input, mid, mid2);
                        mid2--;
                        break;
                    case 'Y':
                        Swap(input, mid2, high);
                        mid2--;
                        high--;
                        break;
                }
            }
            return input;
        }

        private static void Swap<T>(T[] input, int low, int high)
        {
            T temp = input[low];
            input[low] = input[high];
            input[high] = temp;
        }
    }
}