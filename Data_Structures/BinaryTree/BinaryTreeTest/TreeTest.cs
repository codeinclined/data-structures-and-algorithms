using BinaryTree;
using System;
using System.Collections.Generic;
using Xunit;

namespace BinaryTreeTest
{
    public class TreeTest
    {
        [Theory]
        [ClassData(typeof(TreeTestData))]
        public void PreOrderTest(Tree<int> data)
        {
            // Arrange
            List<int> expectedValues = new List<int> { 1, 2, 3, 8, 9, 4, 5, 6, 7 };
            List<int> actualValues = new List<int>();

            // Act
            actualValues = data.PreOrderTraversal(data.Root, actualValues);

            // Assert
            Assert.Equal(expectedValues, actualValues);
        }
    }
}
