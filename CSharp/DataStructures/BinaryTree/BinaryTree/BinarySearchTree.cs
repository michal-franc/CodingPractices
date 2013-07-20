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
                    this.Add(val); 
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

        public void Add(int val)
        {
            if (this.TopNode == null)
            {
                this.TopNode = new TreeNode(val);
                return;
            }
                
            this.Add(this.TopNode, val);
        }

        private void Add(TreeNode node, int val)
        {
            if (val <= node.Value)
            {
                if (node.Left == null)
                {
                    node.Left = new TreeNode(val);
                    return;
                }

                this.Add(node.Left, val);
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new TreeNode(val);
                    return;
                }

                this.Add(node.Right, val);
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

        public int GetMin()
        {
            return this.GetMin(this.TopNode);
        }

        private int GetMin(TreeNode node)
        {
            if (node.Left == null) return node.Value;

            return this.GetMin(node.Left);
        }

        public int GetMax()
        {
            return this.GetMax(this.TopNode);
        }

        private int GetMax(TreeNode node)
        {
            if (node.Right == null) return node.Value;

            return this.GetMax(node.Right);
        }

        public TreeNode Search(int val)
        {
            return this.Search(this.TopNode, val);
        }

        private TreeNode Search(TreeNode node, int val)
        {
            if (val == node.Value) return node;
            else if (val < node.Value) return this.Search(node.Left, val);
            else return this.Search(node.Right, val);
        }

        public void Traverse(Action<TreeNode> action, ITraverseAlgorithm traverseAlgorithm)
        {
            traverseAlgorithm.Traverse(this.TopNode, action);
        }
    }
}