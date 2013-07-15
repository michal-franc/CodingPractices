using System;

namespace BinaryTree
{
    public class TreeNode
    {
        public int Value { get; private set; }
        public TreeNode Left { get; private set; }
        public TreeNode Right { get; private set; }

        public TreeNode(int value)
        {
            this.Value = value;
        }

        public void PropagateValue(int val)
        {
            if (this.Value >= val)
            {
                if (this.Left == null)
                {
                    this.Left = new TreeNode(val);
                }
                else
                {
                    this.Left.PropagateValue(val);
                }
            }
            else
            {
                if (this.Right == null)
                {
                    this.Right = new TreeNode(val);
                }
                else
                {
                    this.Right.PropagateValue(val);
                }
            }
        }

        public int GetBreadth(bool left, int val)
        {
            if (left && this.Left != null)
            {
                return 1 + this.Left.GetBreadth(left, val);
            }

            if (!left && this.Right != null)
            {
                return 1 + this.Right.GetBreadth(left, val);
            }

            if (this.Left == null || this.Right == null)
            {
                return 0;
            }

            throw new NotSupportedException();
        }
    }
}