using System;
using Xunit;
using static LL_KthFromEnd.Program;
using static LL_Insertions.Program;

namespace LL_KthFromEndTest
{
    public class LL_KthFromEndTest
    {
        [Theory]
        [InlineData(new int[] { 1, 3, 8, 2 }, 0)]
        [InlineData(new int[] { 1, 3, 8, 2 }, 1)]
        [InlineData(new int[] { 1, 3, 8, 2 }, 2)]
        [InlineData(new int[] { 1, 3, 8, 2 }, 3)]
        [InlineData(new int[] { 1 }, 0)]
        public void KthFromEndTest(int[] seedValues, int k)
        {
            // Arrange
            SinglyLinkedList.SinglyLinkedList sll = new SinglyLinkedList.SinglyLinkedList();

            foreach (int seedValue in seedValues)
            {
                Append(sll, seedValue);
            }

            // Assert
            // Our seedValues array matches the length and ordering of the linked list,
            // thus indexing from the end of the array should match KthFromEnd on the linked list
            Assert.Equal(seedValues[seedValues.Length - 1 - k], KthFromEnd(sll, k));
        }
    }
}
