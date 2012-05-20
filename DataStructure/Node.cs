namespace DataStructure
{
    public class LinkedListNode
    {
        public LinkedListNode(string data)
        {
            Data = data;
        }

        public string Data { get; set; }
        public LinkedListNode Next { get; set; }

        public override string ToString()
        {
            return Data;
        }
    }
}