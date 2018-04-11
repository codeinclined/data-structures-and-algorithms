using System;
using Xunit;
using BinaryTree;
using FizzBuzzTree;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzTreeTest
{
    public class UnitTest1
    {
        // Uses TreeTestData to provide 3 test cases. These appear in
        // the right pane of the test explorer only if you click on
        // the test result and do not show up in the overall test count.
        [Theory]
        [ClassData(typeof(TreeTestData))]
        public void FizzBuzzTreeTest(Tree<string> testTree, Tree<string> expectedTree)
        {
            // Arrange
            List<string> expectedTreeList = new List<string>();
            List<string> testTreeList = new List<string>();
            expectedTree.InOrderTraversal(expectedTree.Root, expectedTreeList);

            // Act
            Program.FizzBuzzTree(testTree);
            testTree.InOrderTraversal(testTree.Root, testTreeList);

            // Assert
            Assert.Equal(expectedTreeList, testTreeList);
        }
    }
}
