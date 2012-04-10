
namespace DataStructure
{
    public class BinaryTreeNode
    {
        public BinaryTreeNode()
        { }

        public BinaryTreeNode(int value)
        {
            Value = value;
        }

        public BinaryTreeNode(int value, BinaryTreeNode left, BinaryTreeNode right)
        {
            Value = value;
            Left = left;
            Right = right;
        }

        public int Value { get; set; }
        public BinaryTreeNode Left { get; set; }
        public BinaryTreeNode Right { get; set; }
    }
}
