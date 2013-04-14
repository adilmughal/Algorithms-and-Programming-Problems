using Common;
using System;

namespace DataStructure
{
    //Unordered Min Priority Queue Elementary Implementation
    public class PriorityQueue<T> where T : IComparable
    {
        private T[] _collection;
        private int _currentIndex;
        public PriorityQueue(int count)
        {
            _collection = new T[count];
        }

        public void Insert(T item)
        {
            if (_currentIndex == _collection.Length)
                throw new Exception("Collection already full");
            _collection[_currentIndex++] = item;
        }

        public T DeleteMin()
        {
            if (_currentIndex == 0)
                throw new Exception("Collection already empty");
            int minIndex = 0;
            for (int i = 1; i < _currentIndex; i++)
            {
                if (_collection[i].CompareTo(_collection[minIndex]) < 0)
                    minIndex = i;
            }
            Helper.Swap<T>(_collection, minIndex, _currentIndex - 1);
            return _collection[--_currentIndex];
        }

        public bool IsEmpty 
        {
            get { return _currentIndex == 0; }
        }


    }
}
