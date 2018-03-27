using System;
using Xunit;
using SinglyLinkedList;
using LL_Insertions;

namespace LL_InsertionsTest
{
    public class InsertionsTest
    {
        /// <summary>
        /// Ensure that the returned new Node reference from SinglyLinkedList.Append matches
        /// SinglyLinkedList.Head.Next after calling SinglyLinkedList.Append
        /// </summary>
        [Theory]
        [InlineData(new int[] { 1, 3, 2 }, 5)]
        [InlineData(new int[] { }, 9)]
        [InlineData(new int[] { 6 }, 14)]
        public void AppendLinkedListTest(int[] seedValues, int appendedValue)
        {
            // Arrange
            SinglyLinkedList.SinglyLinkedList singlyLinkedList = new SinglyLinkedList.SinglyLinkedList();

            // Iterate backwards through seedValues using the previously tested Add method
            // to seed our linked list with values
            for (int i = seedValues.Length - 1; i >= 0; i--)
            {
                singlyLinkedList.Add(seedValues[i]);
            }

            // Act
            Node appendedNode = Program.Append(singlyLinkedList, appendedValue);

            // Manually find the tail node to assert against our appended node
            Node tailNode = singlyLinkedList.Head;

            while (tailNode.Next != null)
            {
                tailNode = tailNode.Next;
            }

            // Assert
            Assert.Same(tailNode, appendedNode);
        }

        /// <summary>
        /// Tests whether new nodes can be inserted before nodes containing a search value by populating
        /// a singly linked list, inserting before a search value, and then checking that the expected
        /// reference within the linked list matches the reference that has been returned
        /// </summary>
        [Theory]
        [InlineData(new int[] { 10, 20, 30 }, 20, 15)]
        [InlineData(new int[] { 10, 20, 30 }, 10, 25)]
        [InlineData(new int[] { 10, 20, 30 }, 30, 35)]
        public void InsertBeforeTest(int[] seedValues, int searchValue, int newValue)
        {
            // Arrange
            SinglyLinkedList.SinglyLinkedList singlyLinkedList = new SinglyLinkedList.SinglyLinkedList();

            foreach (int seedValue in seedValues)
            {
                Program.Append(singlyLinkedList, seedValue);
            }

            // Act
            Node insertedNode = Program.InsertBefore(singlyLinkedList, searchValue, newValue);
            Node afterNode = singlyLinkedList.Find(searchValue);

            // Assert
            Assert.Same(afterNode, insertedNode.Next);
        }

        /// <summary>
        /// Tests whether new nodes can be inserted after nodes containing a search value by populating
        /// a singly linked list, inserting after the search value, and then checking that the expected
        /// reference within the linked list matches the reference that has been returned
        /// </summary>
        [Theory]
        [InlineData(new int[] { 10, 20, 30 }, 20, 15)]
        [InlineData(new int[] { 10, 20, 30 }, 10, 25)]
        [InlineData(new int[] { 10, 20, 30 }, 30, 35)]
        public void InsertAfterTest(int[] seedValues, int searchValue, int newValue)
        {
            // Arrange
            SinglyLinkedList.SinglyLinkedList singlyLinkedList = new SinglyLinkedList.SinglyLinkedList();

            foreach (int seedValue in seedValues)
            {
                Program.Append(singlyLinkedList, seedValue);
            }

            // Act
            Node insertedNode = Program.InsertAfter(singlyLinkedList, searchValue, newValue);
            Node beforeNode = singlyLinkedList.Find(searchValue);

            // Assert
            Assert.Same(beforeNode.Next, insertedNode);
        }
    }
}
