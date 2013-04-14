using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    //An implementation of COMPLETE binary tree
    public class BinaryHeap<T> where T : IComparable
    {
        private T[] _collection;
        private int _n;
        public BinaryHeap(int count)
        {
            _collection = new T[count + 1];
            _n = 0;
        }

        public void Insert(T item)
        {
            if (_n == _collection.Length)
                throw new Exception("Collection already full");
            _collection[++_n] = item;
            swim(_n);
        }

        public T DeleteMax()
        {
            if (_n == 0)
                throw new Exception("Collection already empty");

            T max = _collection[1];
            Helper.Swap<T>(_collection, 1, _n--);
            sink(1);
            _collection[_n + 1] = default(T);
            return max;
        }

        public bool IsEmpty
        {
            get { return _n == 0; }
        }

        private void swim(int k)
        {
            while (k > 1 && _collection[k / 2].CompareTo(_collection[k]) < 0) //parent key is less than child key
            {
                Helper.Swap<T>(_collection, k, k / 2);
                k = k / 2;
            }
        }

        private void sink(int k)
        {
            while (2 * k <= _n)
            {
                int j = 2 * k;
                if (j < _n && _collection[j].CompareTo(_collection[j + 1]) < 0) j++;
                if (_collection[k].CompareTo(_collection[j]) > 0) break;
                Helper.Swap<T>(_collection, k, j);
                k = j;
            }
        }
    }
}
