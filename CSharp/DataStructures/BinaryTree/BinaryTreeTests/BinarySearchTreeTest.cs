using System.Linq;
using BinaryTree;
using Xunit;

namespace BinaryTreeTests
{
    public class BinarySearchTreeTest 
    {
        [Fact]
        public void CanAdd_Node_With_Value()
        {
            var bst = new BinarySearchTree();
            var value = 1;           

            bst.Add(value);

            Assert.NotNull(bst.TopNode);
            Assert.True(bst.TopNode.Value == 1);
        }
        
        [Fact]
        public void AddingSmallerValueThanTopNode_SetsItAsLeft()
        {
            var bst = new BinarySearchTree();

            var firstValue = 10;
            var secondValue = 8;

            bst.Add(firstValue);
            bst.Add(secondValue);
           
            Assert.True(bst.TopNode.Left.Value == secondValue);
        }

        [Fact]
        public void AddingBiggerValueThanTopNode_SetsItAsRight()
        {
            var bst = new BinarySearchTree();

            var firstValue = 10;
            var secondValue = 15;

            bst.Add(firstValue);
            bst.Add(secondValue);
           
            Assert.True(bst.TopNode.Right.Value == secondValue);
        }
    }
}
