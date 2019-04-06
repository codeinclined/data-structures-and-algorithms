using System;
using Xunit;
using QuickSort;

namespace QuickSortTesting
{
    public class QuickSortTesting
    {
        /// <summary>
        /// Provides three test cases for the QuickSort algorithm
        /// </summary>
        /// <param name="originalArray">The original, unsorted array to sort</param>
        /// <param name="expectedArray">The expected result of the sorting algorithm</param>
        [Theory]
        [InlineData(new int[] { 34, 19, 42, -9, 2018, 0, 2005, 77, 2099 }, new int[] { -9, 0, 19, 34, 42, 77, 2005, 2018, 2099 })]
        [InlineData(new int[] { int.MaxValue, int.MinValue, 42, 13, 26 }, new int[] { int.MinValue, 13, 26, 42, int.MaxValue})]
        [InlineData(new int[] { 1, 1, 1, 1, 3, 1, 2 }, new int[] { 1, 1, 1, 1, 1, 2, 3 })]
        public void QuickSortTest(int[] originalArray, int[] expectedArray)
        {
            // Assert
            Assert.Equal(expectedArray, Program.QuickSort(originalArray));
        }
    }
}
