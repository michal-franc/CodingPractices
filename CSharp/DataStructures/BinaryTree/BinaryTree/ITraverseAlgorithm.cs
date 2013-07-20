using System;

namespace BinaryTree
{
    public interface ITraverseAlgorithm
    {
        void Traverse(TreeNode node, Action<TreeNode> action);
    }

    public class PreOrderTraverse : ITraverseAlgorithm
    {
        public void Traverse(TreeNode node, Action<TreeNode> action)
        {
            if (node == null) return;

            action(node);
            this.Traverse(node.Left, action);
            this.Traverse(node.Right, action);
        }
    }

    public class PostOrderTraverse : ITraverseAlgorithm
    {
        public void Traverse(TreeNode node, Action<TreeNode> action)
        {
            if (node == null) return;

            this.Traverse(node.Left, action);
            this.Traverse(node.Right, action);
            action(node);
        }
    }

    public class InOrderTraverse : ITraverseAlgorithm
    {
        public void Traverse(TreeNode node, Action<TreeNode> action)
        {
            if (node == null) return;

            this.Traverse(node.Left, action);
            action(node);
            this.Traverse(node.Right, action);
        }
    }
}