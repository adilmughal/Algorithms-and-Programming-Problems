using System;

namespace DataStructure
{
    public class BinarySearchTree<TKey, TValue> where TKey : IComparable<TKey>
    {
        private BinarySearchTreeNode _root;

        public TValue Retrieve(TKey key)
        {
            if (_root == null)
                return default(TValue);

            return Retrieve(key, _root);
        }

        private TValue Retrieve(TKey key, BinarySearchTreeNode node)
        {
            int compareTo = node.Key.CompareTo(key);

            if (compareTo > 0)
                return Retrieve(key, node.Left);
            if (compareTo < 0)
                return Retrieve(key, node.Right);

            return node.Value;
        }

        public void Add(TKey key, TValue value)
        {
            if (_root == null)
                _root = new BinarySearchTreeNode(key, value, 1);
            else
                Add(key, value, _root);
        }

        private BinarySearchTreeNode Add(TKey key, TValue value, BinarySearchTreeNode node)
        {
            if (node == null)
                return new BinarySearchTreeNode(key, value, 1);

            int compareTo = node.Key.CompareTo(key);

            if (compareTo == 0)
                node.Value = value;
            else if (compareTo > 0)
                node.Left =  Add(key, value, node.Left);
            else if (compareTo < 0)
                node.Right = Add(key, value, node.Right);
            return node;
        }

        #region Nested type: BinarySearchTreeNode

        private class BinarySearchTreeNode
        {
            public BinarySearchTreeNode(TKey key, TValue value, int n)
            {
                Key = key;
                Value = value;
                NodeCount = n;
            }

            public TKey Key { get; private set; }
            public TValue Value { get; set; }
            public BinarySearchTreeNode Right { get; set; }
            public BinarySearchTreeNode Left { get; set; }
            public int NodeCount { get; set; }
        }

        #endregion
    }
}