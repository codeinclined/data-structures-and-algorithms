using System;
using Xunit;
using SinglyLinkedList;
using static LL_Insertions.Program;
using static LL_Merge.Program;

namespace LL_MergeTest
{
    public class LL_MergeTest
    {
        [Theory]
        [InlineData(new int[] { 1, 3, 2 }, new int[] { 5, 9, 4 }, new int[] { 1, 5, 3, 9, 2, 4 })]
        [InlineData(new int[] { 1, 3 }, new int[] { 5, 9, 4 }, new int[] { 1, 5, 3, 9, 4 })]
        [InlineData(new int[] { 1, 3, 2 }, new int[] { 5, 9 }, new int[] { 1, 5, 3, 9, 2 })]
        public void MergeTest(int[] itemsA, int[] itemsB, int[] expectedItems)
        {
            // Arrange
            SinglyLinkedList.SinglyLinkedList listA = new SinglyLinkedList.SinglyLinkedList();
            foreach (int item in itemsA)
            {
                Append(listA, item);
            }

            SinglyLinkedList.SinglyLinkedList listB = new SinglyLinkedList.SinglyLinkedList();
            foreach (int item in itemsB)
            {
                Append(listB, item);
            }

            // Act
            SinglyLinkedList.SinglyLinkedList mergedList = new SinglyLinkedList.SinglyLinkedList();
            mergedList.Head = MergeLists(listA, listB);

            // Assert
            // Copy all values from mergedList into an array for asserting against expectedItems
            int[] resultAsArray = new int[expectedItems.Length];
            Node curNode = mergedList.Head;
            int curIndex = 0;

            while (curNode != null)
            {
                resultAsArray[curIndex++] = curNode.Value;
                curNode = curNode.Next;
            }

            Assert.Equal(expectedItems, resultAsArray);
        }
    }
}
