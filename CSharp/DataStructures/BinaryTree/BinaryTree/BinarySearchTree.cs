namespace BinaryTree
{

    // Abbility to set Value directly on node
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

    public class BinarySearchTree
    {
        public TreeNode TopNode { get; private set; }

        public void Add(int newValue)
        {
            if (TopNode == null)
            {
                this.TopNode = new TreeNode(newValue);
            }
            else
            {
                if(this.TopNode.Value >= newValue)
                {
                    this.TopNode.Left = new TreeNode(newValue);
                }
                else
                {
                    this.TopNode.Right = new TreeNode(newValue);
                }
            }
        }
    }
}
