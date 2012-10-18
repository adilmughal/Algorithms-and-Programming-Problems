using System.Diagnostics;
using DataStructure;

namespace ProgrammingProblems
{
    internal class TreeProblems
    {
        public static void PreOrderTraversal(BinaryTreeNode node)
        {
            if (node == null)
                return;
            Debug.Print(node.Value.ToString());
            PreOrderTraversal(node.Left);
            PreOrderTraversal(node.Right);
        }

        public static void InOrderTraversal(BinaryTreeNode node)
        {
            if (node == null)
                return;
            InOrderTraversal(node.Left);
            Debug.Print(node.Value.ToString());
            InOrderTraversal(node.Right);
        }

        public static void PostOrderTraversal(BinaryTreeNode node)
        {
            if (node == null)
                return;
            PostOrderTraversal(node.Left);
            PostOrderTraversal(node.Right);
            Debug.Print(node.Value.ToString());
        }
    }
}