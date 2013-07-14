using BinaryTree;
using Xunit;

namespace BinaryTreeTests
{
    public class TreeNodeTest
    {
        [Fact]
        public void PropagateSmallerValue_CreateNew_SetsItAsLeft()
        {
            var firstValue = 15;
            var secondValue = 10;

            var node = new TreeNode(firstValue);

            node.PropagateValue(secondValue);

            Assert.True(node.Left.Value == secondValue);
        }

        [Fact]
        public void PropagateBiggerValue_CreateNew_SetsItAsRight()
        {
            var firstValue = 10;
            var secondValue = 15;

            var node = new TreeNode(firstValue);
            node.PropagateValue(secondValue);

            Assert.True(node.Right.Value == secondValue);
        }

        [Fact]
        public void Propagate2BigValues_Creates2RightNodes()
        {
            var startValue = 1;
            var firstValue = 2;
            var secondValue = 3;

            var node = new TreeNode(startValue);
            node.PropagateValue(firstValue);
            node.PropagateValue(secondValue);

            Assert.True(node.Right.Value == firstValue);
            Assert.True(node.Right.Right.Value == secondValue);
        }
    }
}