using BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using TreeIntersection;
using Xunit;

namespace TreeIntersectionTesting
{
    public class TreeIntersectionTesting
    {
        [Theory]
        [ClassData(typeof(TreeIntersectionTestData))]
        public void TreeIntersectionTest(Tree<int> treeA, Tree<int> treeB, List<int> expectedValues)
        {
            // Arrange
            expectedValues.Sort();

            // Act
            List<int> actualValues = Program.TreeIntersection(treeA, treeB).ToList();

            // Assert
            actualValues.Sort();
            Assert.Equal(expectedValues, actualValues);
        }
    }
}
