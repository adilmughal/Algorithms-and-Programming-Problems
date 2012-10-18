using System.Text;

namespace DataStructure
{
    public class LinkedList<T>
    {
        private LinkedListNode<T> _root;

        public LinkedList()
        {
            _root = null;
        }

        public LinkedListNode<T> Root
        {
            get { return _root; }
        }

        public bool IsEmpty
        {
            get { return _root == null; }
        }

        public LinkedListNode<T> Insert(T item)
        {
            // Creates a Node, sets its Node to the first item and 
            // then makes this the first item in the list.
            var node = new LinkedListNode<T>(item);
            node.Next = _root;
            _root = node;
            return node;
        }

        public LinkedListNode<T> Delete()
        {
            // Gets the first item, and then this to be the one it is linked forward to
            LinkedListNode<T> temp = _root;
            if (_root != null)
                _root = _root.Next;
            return temp;
        }

        public int Count
        {
            get
            {
                int count = 0;
                LinkedListNode<T> currentNode = _root;
                while (currentNode != null)
                {
                    count++;
                    currentNode = currentNode.Next;
                }
                    
                return count;  
            }
            
        }

        public T[] ToArray()
        {
            int n = this.Count;
            LinkedListNode<T> currentNode = _root;
            T[] array = new T[n];
            for (int index=0; index < n; index++)
            {
                array[index] = currentNode.Data;
                currentNode = currentNode.Next;
            }
            return array;
        }

        public override string ToString()
        {
            LinkedListNode<T> currentNode = _root;
            var builder = new StringBuilder();

            while (currentNode != null)
            {
                builder.Append(currentNode);
                currentNode = currentNode.Next;
            }
            return builder.ToString();
        }


    }
}