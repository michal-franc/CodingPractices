namespace BinaryTree
{
    public class TreeNode
    {
        public int Value { get; private set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode(int value)
        {
            this.Value = value;
        }
    }
}