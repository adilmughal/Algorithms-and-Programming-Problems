using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingProblems
{
    public class UnionFind
    {
        int[] idArray;
        const int N = 10;
        public UnionFind()
        {
            idArray = new int[N];
            for (int index = 0; index < N; index++)
            {
                idArray[index] = index;
            }
        }

        public bool IsConnected(int p, int q)
        {
            return idArray[p] == idArray[q];
        }

        public void Union(int p, int q)
        {
            int pId = idArray[p];
            int qId = idArray[q];
            for (int index = 0; index < N; index++)
            {
                if (idArray[index] == qId)
                    idArray[index] = pId;
            }
        }
    }
}
