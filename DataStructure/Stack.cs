using System;

namespace DataStructure
{
    public class Stack<T> : IStack<T>
    {
        private readonly T[] _arrayStore;
        private int _currentIndex;

        public Stack(int capacity)
        {
            _arrayStore = new T[capacity];
        }

        #region IStack<T> Members

        public void Push(T item)
        {
            if (_currentIndex == _arrayStore.Length)
                throw new Exception("Length of stack exceeds capacity");
            _arrayStore[_currentIndex++] = item;
        }

        public T Pop()
        {
            if (_currentIndex == 0)
                throw new Exception("Stack already empty");
            return _arrayStore[--_currentIndex];
        }

        public bool IsEmpty()
        {
            if (_currentIndex == 0)
                return true;
            return false;
        }

        public bool IsFull()
        {
            if (_currentIndex == _arrayStore.Length)
                return true;
            return false;
        }

        #endregion
    }
}