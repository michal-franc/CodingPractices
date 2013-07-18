using System;

namespace BinaryTree
{
    public class BinarySearchTree
    {
        public BinarySearchTree()
        {
        }

        public BinarySearchTree(int[] inputArray)
        {
            var middleValue = this.GetMiddleValue(inputArray);

            this.TopNode = new TreeNode(middleValue);
            
            foreach (var val in inputArray)
            {
                if (val != middleValue)
                {
                    this.TopNode.PropagateValue(val); 
                }
            }
        }

        private int GetMiddleValue(int[] inputArray)
        {
            var length = inputArray.Length / 2;
            
            Array.Sort(inputArray);

            return inputArray[length];
        }

        public TreeNode TopNode { get; private set; }

        public void Add(int newValue)
        {
            if (TopNode == null)
            {
                this.TopNode = new TreeNode(newValue);
            }
            else
            {
                this.TopNode.PropagateValue(newValue);
            }
        }

        public TreeBreadth GetBreadth()
        {
            var breadth = new TreeBreadth
                {
                    Left = this.GetBreadth(this.TopNode.Left, true),
                    Right = this.GetBreadth(this.TopNode.Right, false) 
                };

            return breadth;
        }

        private int GetBreadth(TreeNode node, bool checkLeft)
        {
            if (node == null) return 0;

            var nextnode = checkLeft ? node.Left : node.Right; 

            return 1 + this.GetBreadth(nextnode, checkLeft);
        }

        public int GetHeight()
        {
            return this.GetHeight(this.TopNode);
        }

        private int GetHeight(TreeNode node)
        {
            if (node == null) return 0;

            return 1 + Math.Max(this.GetHeight(node.Left), this.GetHeight(node.Right));
        }
    }
}