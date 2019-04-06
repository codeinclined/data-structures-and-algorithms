using System;
using Xunit;
using MergeSort;

namespace MergeSortTesting
{
    /// <summary>
    /// Provides three test cases for MergeSort
    /// </summary>
    public class MergeSortTesting
    {
        [Theory]
        [InlineData(new int[] { 34, 19, 42, -9, 2018, 0, 2005, 77, 2099 }, new int[] { -9, 0, 19, 34, 42, 77, 2005, 2018, 2099 })]
        [InlineData(new int[] { 5, -5, 0, 3, 17, 43 }, new int[] { -5, 0, 3, 5, 17, 43 })]
        [InlineData(new int[] { int.MaxValue, int.MinValue }, new int[] { int.MinValue, int.MaxValue })]
        public void MergeSortTest(int[] unsortedArray, int[] expectedArray)
        {
            // Act
            int[] sortedArray = Program.MergeSort(unsortedArray);

            // Assert
            Assert.Equal(expectedArray, sortedArray);
        }
    }
}
