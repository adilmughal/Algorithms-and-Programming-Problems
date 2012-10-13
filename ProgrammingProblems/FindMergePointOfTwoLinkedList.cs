using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingProblems
{
    public partial class LinkedList
    {
        public LinkedListNode<int> FindMergePointOfTwoLinkedList(LinkedList<int> firstList, LinkedList<int> secondList)
        {
            int firstListLength = CountList(firstList);
            int secondListLength = CountList(secondList);

            LinkedListNode<int> firstListHead = firstList.First;
            LinkedListNode<int> secondListHead = secondList.First;

            while (firstListLength > secondListLength)
            {
                firstListHead = firstListHead.Next;
                firstListLength--;
            }

            while (secondListLength > firstListLength)
            {
                secondListHead = secondListHead.Next;
                secondListLength--;
            }

            //Now both heads must be at same difference
            while (firstListHead != null)
            {
                if (firstListHead == secondListHead)
                    return firstListHead; //same node
                firstListHead = firstListHead.Next;
                secondListHead = secondListHead.Next;
            }
            return null;

        }

        private int CountList(LinkedList<int> list)
        {
            int count=0;
            LinkedListNode<int> head = list.First;
            while (head != null)
            {
                count++;
                head = head.Next;
            }
            return count;
        }
    }
}
