namespace ProgrammingProblems
{
    public partial class Sorting
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
            for (int j = 1; j < input.Length-1; j++)
            {
                int i = j - 1;
                int minKey = input[j];
                while ( i>=0 && (input[i] >minKey))
                {
                    input[i + 1] = input[i];
                    i = i - 1;
                }
                input[i+1] = minKey;
            }
            return input;
        }
    }

}