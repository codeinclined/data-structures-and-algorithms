using System;
using Xunit;
using BinarySearch;

namespace BinarySearchTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 4, 8, 15, 16, 23, 42 }, 15, 2)]
        [InlineData(new int[] { 4, 8, 15, 16, 23, 42 }, 5, -1)]
        [InlineData(new int[] { 11, 22, 33, 44, 55, 66, 77 }, 90, -1)]
        [InlineData(new int[] { 11, 22, 33, 44, 55, 66, 77 }, 66, 5)]
        [InlineData(new int[] { 98 }, 20, -1)]
        [InlineData(new int[] { 98 }, 98, 0)]
        public void BinarySearchTest(int[] inputArray,
            int searchValue, int expectedIndex)
        {
            Assert.Equal(expectedIndex,
                Program.BinarySearch(inputArray, searchValue));
        }
    }
}
