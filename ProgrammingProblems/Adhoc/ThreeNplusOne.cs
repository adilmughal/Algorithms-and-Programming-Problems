namespace ProgrammingProblems
{
    public partial class Adhoc
    {
         public static int ThreeNplusOne(int i, int j)
         {
             int maximumCycleLength = 0;
             int start, end;
             if (i < j)
             {
                 start = i + 1;
                 end = j - 1;
             }
             else
             {
                 start = j + 1;
                 end = i - 1;
             }
             for (int k = start; k <=end; k++)
             {
                 int currentCycleLength = 1;
                 int s = k;
                 while (s != 1)
                 {
                     if (s%2 == 0)
                         s = s/2;
                     else
                         s = (3*s) + 1;
                     currentCycleLength++;
                 }
                 if (currentCycleLength > maximumCycleLength)
                     maximumCycleLength = currentCycleLength;
             }
             return maximumCycleLength;
         }
    }

}