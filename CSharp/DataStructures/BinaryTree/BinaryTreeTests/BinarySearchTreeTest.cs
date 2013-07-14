using BinaryTree;
using Xunit;

namespace BinaryTreeTests
{
    public class BinarySearchTreeTest
    {
        [Fact]
        public void CtorCanTakeArray_AndProduces_Tree_SortedArray()
        {
            var inputArray = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var bst = new BinarySearchTree(inputArray);

            Assert.Equal(bst.TopNode.Value, 5);
            Assert.Equal(bst.TopNode.Left.Value, 1);
            Assert.Equal(bst.TopNode.Left.Right.Value, 2);
            Assert.Equal(bst.TopNode.Right.Value, 6);
            Assert.Equal(bst.TopNode.Right.Right.Value, 7);
        }
        
        [Fact]
        public void AddingNode_ToEmptyTree_SetTopNode()
        {
            var bst = new BinarySearchTree();
            var value = 1;

            bst.Add(value);

            Assert.NotNull(bst.TopNode);
            Assert.True(bst.TopNode.Value == 1);
        }

    }
}
