using System.Diagnostics;

namespace ProgrammingProblems.TreesNGraphs
{
    public class SumUpBinaryTreeNode
    {
        public SumUpBinaryTreeNode()
        {
        }

        public SumUpBinaryTreeNode(int value)
        {
            Value = value;
        }

        public int Value { get; set; }
        public int SumUp { get; set; }
        public SumUpBinaryTreeNode Left { get; set; }
        public SumUpBinaryTreeNode Right { get; set; }
    }

    public class SubTreeWithLargestSum
    {
        public static int PostOrderTraversalWithValueSumUp(SumUpBinaryTreeNode node)
        {
            if (node == null)
                return 0;
            int leftSum = PostOrderTraversalWithValueSumUp(node.Left);
            int rightSum = PostOrderTraversalWithValueSumUp(node.Right);
            node.SumUp = node.Value + leftSum + rightSum;
            Debug.Print(node.Value.ToString() + " with Sum: " + node.SumUp);
            return node.SumUp;
        }
    }
}