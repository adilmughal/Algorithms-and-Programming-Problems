using System;
using DataStructure;

namespace ProgrammingProblems
{
    public class LinkedListProblems
    {
        //Floyd Cycle Detection Algorithm
        public static bool IsCycleFound(LinkedList<int> linkedList)
        {
            LinkedListNode<int> first = linkedList.Root;
            if (first == null)
                return false;

            //create a second reference variables
            LinkedListNode<int> second = first;

            do
            {
                first = first.Next;
                second = second.Next.Next;
            } while (first != null && second != null && first != second);

            if (first == second)
                return true;
            return false;
        }

        public static LinkedListNode<int> FindFirstParticipatingNodeInCycle(LinkedList<int> linkedList)
        {
            LinkedListNode<int> first = linkedList.Root;
            if (first == null)
                return null;

            //create a second reference variables
            LinkedListNode<int> second = first;

            do
            {
                first = first.Next;
                second = second.Next.Next;
            } while (first != null && second != null && first != second);

            if (first == second) //loop detected
                return first;


            //Move first pointer to root again
            first = linkedList.Root;
            //second = linkedList.Root;

            //Move second pointer to Nth element where N is length of list
            //int n = linkedList.Count;
            //while (n > 0)
            //{
            //    second = second.Next;
            //    n--;
            //}

            while (first != second)
            {
                first = first.Next;
                second = second.Next;
            }

            return first;
        }

        public static LinkedList<int> RemoveDuplicateFromUnsortedList(LinkedList<int> linkedList)
        {
            if (linkedList == null)
                throw new ArgumentNullException("linkedList");

            var hash = new System.Collections.Generic.Dictionary<int, bool>();
            LinkedListNode<int> currentNode = linkedList.Root;
            LinkedListNode<int> previous = null;

            while (currentNode != null)
            {
                int data = currentNode.Data;
                if (hash.ContainsKey(data))
                {
                    previous.Next = currentNode.Next;
                }
                else
                {
                    hash.Add(data, true);
                    previous = currentNode;
                }
                currentNode = currentNode.Next;
            }
            return linkedList;
        }

        public static LinkedList<int> RemoveDuplicateFromUnsortedListWithoutBuffer(LinkedList<int> linkedList)
        {
            if (linkedList == null)
                throw new ArgumentNullException("linkedList");

            LinkedListNode<int> currentNode = linkedList.Root;


            while (currentNode != null)
            {
                LinkedListNode<int> runningNode = currentNode;
                while (runningNode != null && runningNode.Next != null)
                {
                    if (currentNode.Data == runningNode.Next.Data)
                        runningNode.Next = runningNode.Next.Next; //found match
                    runningNode = runningNode.Next;
                }

                currentNode = currentNode.Next;
            }

            return linkedList;
        }

        public LinkedListNode<int> FindMergePointOfTwoLinkedList(LinkedList<int> firstList, LinkedList<int> secondList)
        {
            int firstListLength = CountList(firstList);
            int secondListLength = CountList(secondList);

            LinkedListNode<int> firstListHead = firstList.Root;
            LinkedListNode<int> secondListHead = secondList.Root;

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
            int count = 0;
            LinkedListNode<int> head = list.Root;
            while (head != null)
            {
                count++;
                head = head.Next;
            }
            return count;
        }
    }
}