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
            // Reference TreeTestData.GetEnumerator()
            List<int> expectedValues = new List<int> { 1, 2, 3, 8, 9, 4, 5, 6, 7 };
            List<int> actualValues = new List<int>();

            // Act
            actualValues = data.PreOrderTraversal(data.Root, actualValues);

            // Assert
            Assert.Equal(expectedValues, actualValues);
        }


        [Theory]
        [ClassData(typeof(TreeTestData))]
        public void InOrderTest(Tree<int> data)
        {
            // Arrange
            // Reference TreeTestData.GetEnumerator()
            List<int> expectedValues = new List<int> { 8, 3, 9, 2, 4, 1, 6, 5, 7 };
            List<int> actualValues = new List<int>();

            // Act
            actualValues = data.InOrderTraversal(data.Root, actualValues);

            // Assert
            Assert.Equal(expectedValues, actualValues);
        }

        [Theory]
        [ClassData(typeof(TreeTestData))]
        public void PostOrderTest(Tree<int> data)
        {
            // Arrange
            // Reference TreeTestData.GetEnumerator()
            List<int> expectedValues = new List<int> { 8, 9, 3, 4, 2, 6, 7, 5, 1 };
            List<int> actualValues = new List<int>();

            // Act
            actualValues = data.PostOrderTraversal(data.Root, actualValues);

            // Assert
            Assert.Equal(expectedValues, actualValues);
        }
    }
}
