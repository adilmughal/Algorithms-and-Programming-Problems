namespace DataStructure
{
    public class LinkedListNode
    {
        public string Data { get; set; }
        public LinkedListNode Next { get; set; }
        
        public LinkedListNode(string data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data;
        }
    }
}