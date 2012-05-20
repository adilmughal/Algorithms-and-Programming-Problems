using System.Text;

namespace DataStructure
{
    public class LinkedList
    {
        private LinkedListNode _first;

        public LinkedList()
        {
            _first = null;
        }

        public bool IsEmpty
        {
            get { return _first == null; }
        }

        public LinkedListNode Insert(string title)
        {
            // Creates a Node, sets its Node to the first item and then makes this the first item in the list.
            var node = new LinkedListNode(title);
            node.Next = _first;
            _first = node;
            return node;
        }

        public LinkedListNode Delete()
        {
            // Gets the first item, and then this to be the one it is linked forward to
            LinkedListNode temp = _first;
            if (_first != null)
                _first = _first.Next;
            return temp;
        }

        public override string ToString()
        {
            LinkedListNode currentNode = _first;
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