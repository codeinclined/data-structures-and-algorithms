using System;
using Xunit;
using SinglyLinkedList;

namespace SinglyLinkedListTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Tests whether a new node can be added to the front of a singly linked list by comparing
        /// the Head node's value to the known, expected value of 5 after calling Add(5)
        /// </summary>
        [Fact]
        public void CanAddNodeToEmptySinglyLinkedList()
        {
            // Arrange
            SinglyLinkedList.SinglyLinkedList singlyLinkedList = new SinglyLinkedList.SinglyLinkedList();

            // Act
            singlyLinkedList.Add(5);

            // Assert
            Assert.Equal(5, singlyLinkedList.Head.Value);
        }

        /// <summary>
        /// Tests whether a node being added to an already occupied linked list points to the
        /// Head node that existed prior to adding the second node.
        /// </summary>
        [Fact]
        public void CanAddNodeToOccupiedSinglyLinkedList()
        {
            // Arrange
            SinglyLinkedList.SinglyLinkedList singlyLinkedList = new SinglyLinkedList.SinglyLinkedList();
            Node oldHead;

            // Act
            oldHead = singlyLinkedList.Add(1);
            singlyLinkedList.Add(5);

            // Assert
            Assert.Equal(oldHead, singlyLinkedList.Head.Next);
        }

        [Fact]
        public void FindReturnsNullWhenSinglyLinkedListEmpty()
        {
            // Arrange
            SinglyLinkedList.SinglyLinkedList singlyLinkedList = new SinglyLinkedList.SinglyLinkedList();

            // Act / Assert
            Assert.Null(singlyLinkedList.Find(10));
        }

        [Theory]
        [InlineData(new int[] {1, 2, 3, 4, 5, 6, 7}, 7)]
        [InlineData(new int[] {1, 2, 3, 4, 5, 6, 7}, 3)]
        [InlineData(new int[] {1, 2, 3, 4, 5, 6, 7}, 1)]
        [InlineData(new int[] {1, 2, 3, 4, 5, 6, 7}, 4)]
        [InlineData(new int[] {1, 2, 3, 4, 5, 6, 7}, 6)]
        public void FindInSinglyLinkedListTest(int[] seedValues, int searchValue)
        {
            // Arrange
            SinglyLinkedList.SinglyLinkedList singlyLinkedList = new SinglyLinkedList.SinglyLinkedList();

            // Act
            foreach (int seedValue in seedValues)
            {
                singlyLinkedList.Add(seedValue);
            }

            // Assert
            Assert.NotNull(singlyLinkedList.Find(searchValue));
        }
    }
}
