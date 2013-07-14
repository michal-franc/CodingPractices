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
    }
}