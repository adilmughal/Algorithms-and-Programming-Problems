using System.Diagnostics;
using System.Globalization;
using DataStructure;

namespace ProgrammingProblems
{
    public class TreeProblems
    {
        public static void PreOrderTraversal(BinaryTreeNode node)
        {
            if (node == null)
                return;
            Debug.Print(node.Value.ToString(CultureInfo.InvariantCulture));
            PreOrderTraversal(node.Left);
            PreOrderTraversal(node.Right);
        }

        public static void InOrderTraversal(BinaryTreeNode node)
        {
            if (node == null)
                return;
            InOrderTraversal(node.Left);
            Debug.Print(node.Value.ToString(CultureInfo.InvariantCulture));
            InOrderTraversal(node.Right);
        }

        public static void PostOrderTraversal(BinaryTreeNode node)
        {
            if (node == null)
                return;
            PostOrderTraversal(node.Left);
            PostOrderTraversal(node.Right);
            Debug.Print(node.Value.ToString(CultureInfo.InvariantCulture));
        }

        public static int PostOrderTraversalWithValueSumUp(SumUpBinaryTreeNode node)
        {
            if (node == null)
                return 0;
            int leftSum = PostOrderTraversalWithValueSumUp(node.Left);
            int rightSum = PostOrderTraversalWithValueSumUp(node.Right);
            node.SumUp = node.Value + leftSum + rightSum;
            Debug.Print(node.Value.ToString(CultureInfo.InvariantCulture) + " with Sum: " + node.SumUp);
            return node.SumUp;
        }

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
    }
}