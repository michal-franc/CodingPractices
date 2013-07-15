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
        public void CtorCanTakeArray_AndProducesTree_UnsortedArray()
        {
            var inputArray = new[] { 10, 15, 0, 1, 19, 25, 4, 6, 9 };

            var bst = new BinarySearchTree(inputArray);

            Assert.Equal(bst.TopNode.Value, 9);
            Assert.Equal(bst.TopNode.Left.Value, 0);
            Assert.Equal(bst.TopNode.Left.Right.Value, 1);
            Assert.Equal(bst.TopNode.Right.Value, 10);
            Assert.Equal(bst.TopNode.Right.Right.Value, 15);
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

        public class BreadthMethodtests
        {
            [Fact]
            public void BreadthForSingleElement_Equals_0()
            {
                var expectedBreadth = new TreeBreadth { Left = 0, Right = 0};
                var bst = new BinarySearchTree(new[] { 5 });

                var actualBreadth = bst.GetBreadth();

                Assert.Equal(expectedBreadth, actualBreadth);
            }
            
            [Fact]
            public void BreadthFor_BalancedTree_OneLevel()
            {
                var expectedBreadth = new TreeBreadth { Left = 1, Right = 1 };
                var bst = new BinarySearchTree();

                bst.Add(5);
                bst.Add(1);
                bst.Add(6);

                var actualBreadth = bst.GetBreadth();

                Assert.Equal(expectedBreadth, actualBreadth);
            }
            
            [Fact]
            public void BreadthFor_BalancedTree_TwoLevels()
            {
                var expectedBreadth = new TreeBreadth { Left = 2, Right = 2 };
                var bst = new BinarySearchTree();

                bst.Add(5);
                bst.Add(2);
                bst.Add(1);
                bst.Add(3);
                bst.Add(7);
                bst.Add(6);
                bst.Add(8);

                var actualBreadth = bst.GetBreadth();

                Assert.Equal(expectedBreadth, actualBreadth);
            }

            [Fact]
            public void BreadthFor_UnBalancedTree_OnlyRight()
            {
                var expectedBreadth = new TreeBreadth { Left = 0, Right = 2 };
                var bst = new BinarySearchTree();

                bst.Add(5);
                bst.Add(7);
                bst.Add(6);
                bst.Add(8);

                var actualBreadth = bst.GetBreadth();

                Assert.Equal(expectedBreadth, actualBreadth);
            }

            [Fact]
            public void BreadthFor_UnBalancedTree_OnlyLeft()
            {
                var expectedBreadth = new TreeBreadth { Left = 2, Right = 0 };
                var bst = new BinarySearchTree();

                bst.Add(5);
                bst.Add(2);
                bst.Add(1);
                bst.Add(3);

                var actualBreadth = bst.GetBreadth();

                Assert.Equal(expectedBreadth, actualBreadth);
            }

            [Fact]
            public void BreadthFor_UnBalancedTree_SmallerLeft()
            {
                var expectedBreadth = new TreeBreadth { Left = 1, Right = 2 };
                var bst = new BinarySearchTree();

                bst.Add(5);
                bst.Add(7);
                bst.Add(6);
                bst.Add(8);
                bst.Add(2);

                var actualBreadth = bst.GetBreadth();

                Assert.Equal(expectedBreadth, actualBreadth);
            }
        }

        public class DrawMethodTests
        {
            [Fact]
            public void Single_TopNode()
            {
                var inputArray = new[] { 5 };
                var bst = new BinarySearchTree(inputArray);
                var expectedString =
                    "5";

                var actualString = bst.Draw();

                Assert.Equal(expectedString, actualString);
            }
            [Fact]
            public void DrawTest()
            {
                var inputArray = new[] {1, 5, 2};
                var bst = new BinarySearchTree(inputArray);
                var expectedString =
                    " 5 " +
                    "1-2";

                var actualString = bst.Draw();

                Assert.Equal(expectedString, actualString);
            }
        }
    }
}
