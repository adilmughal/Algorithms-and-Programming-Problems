namespace ProgrammingProblems.Arrays
{
    public class Sorting
    {
        public static int[] BubbleSort(int[] input)
        {
            int length = input.Length - 1;

            for (int i = 0; i <= length; i++)
            {
                bool isSwapped = false;
                for (int j = length; j >= i + 1; j--)
                {
                    if (input[j] < input[j - 1])
                    {
                        int temp = input[j - 1];
                        input[j - 1] = input[j];
                        input[j] = temp;
                        isSwapped = true;
                    }
                }
                if (!isSwapped)
                    break;
            }
            return input;
        }

        public static int[] InsertionSort(int[] input)
        {
            if(input.Length < 2)
                return input;
            
            int length = input.Length - 1;

            for (int i = 1; i < length; i++)
            {
                int key = input[i];

                int j = i - 1;

                while (j >= 0 && input[j] > key)
                {
                    input[j+1] = input[j];
                    j--;
                }
                input[j + 1] = key;
            }

            return input;
        }

        public static int[] MergeSort(int[] input)
        {

    // if list size is 1, consider it sorted and return it
    //if length(m) <= 1
    //    return m
    //// else list size is > 1, so split the list into two sublists
    //var list left, right
    //var integer middle = length(m) / 2
    //for each x in m up to middle
    //     add x to left
    //for each x in m after or equal middle
    //     add x to right
    //// recursively call merge_sort() to further split each sublist
    //// until sublist size is 1
    //left = merge_sort(left)
    //right = merge_sort(right)
    //// merge the sublists returned from prior calls to merge_sort()
    //// and return the resulting merged sublist
    //return merge(left, right)
            int length = input.Length;

            if (length <= 1)
                return input;

            int middle = length/2;

            int[] left= new int[middle-0];
            int[] right =new int[length-middle];
            
            for (int i = 0; i < middle; i++)
            {
                left[i] = input[i];
            }

            for (int i = middle; i <= length ; i++)
            {
                right[length-i] = input[i];
            }

            left = MergeSort(left);
            right = MergeSort(right);

            return MergeSort(left, right);
        }

        private static int[] MergeSort(int[] left, int[] right)
        {
            int[] result =new int[left.Length + right.Length];
            int count = 0;

            while (left.Length > 0 && right.Length > 0)
            {
                if (left.Length >0 && right.Length > 0)
                {
                    if (left[0] <= right[0])
                    {
                        result[count] = left[0];
                    }
                }
                else if (left.Length>0)
                {
                    
                }
            }
            //        var list result
            //while length(left) > 0 or length(right) > 0
            //    if length(left) > 0 and length(right) > 0
            //        if first(left) <= first(right)
            //            append first(left) to result
            //            left = rest(left)
            //        else
            //            append first(right) to result
            //            right = rest(right)
            //    else if length(left) > 0
            //        append first(left) to result
            //        left = rest(left)
            //    else if length(right) > 0
            //        append first(right) to result
            //        right = rest(right)
            //end while
            //return result
            return null;
        }

        public static char[] SortColoredBalls(char[] balls)
        {
            if (balls.Length <= 1)
                return balls;

            int low = 0;
            int end = balls.Length - 1;
            int mid = 0;

            while (mid <= end)
            {
                char midBall = balls[mid];

                if (midBall == 'G' || midBall == 'g')
                {
                    balls[mid] = balls[low];
                    balls[low] = midBall;
                    low++;
                    mid++;
                }
                else if (midBall == 'R' || midBall == 'r')
                {
                    mid++;
                }
                else if (midBall == 'Y' || midBall == 'y')
                {
                    balls[mid] = balls[end];
                    balls[end] = midBall;
                    end--;
                    mid++;
                }
                else
                {
                    break;
                }
            }

            return balls;
        }
    }
}