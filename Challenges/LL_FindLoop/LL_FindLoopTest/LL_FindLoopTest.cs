using System;
using Xunit;
using SinglyLinkedList;
using static LL_FindLoop.Program;

namespace LL_FindLoopTest
{
    public class LL_FindLoopTest
    {
        [Theory]
        [ClassData(typeof(FindLoopTestData))]
        public void FindLoopTest(SinglyLinkedList.SinglyLinkedList sll, bool expectedResult)
        {
            // Arrange accomplished within FindLoopTestData enumerator for four test cases

            // Act
            bool actualResult = FindLoop(sll);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
