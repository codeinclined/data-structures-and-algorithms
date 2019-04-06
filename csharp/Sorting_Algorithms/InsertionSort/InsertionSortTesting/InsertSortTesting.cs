using System;
using Xunit;
using static InsertionSort.Program;

namespace InsertionSortTesting
{
    public class InsertionSortTesting
    {
        /// <summary>
        /// Checks if InsertionSort can sort integers correctly
        /// </summary>
        [Fact]
        public void CanInsertionSortIntegers()
        {
            // Arrange
            int[] originalArray = new int[] { 5, 4, 3, 2, 1 };
            int[] expectedArray = new int[] { 1, 2, 3, 4, 5 };

            // Act
            // Technically, sorted array and original array are references
            // to the same array since InsertionSort operates directly on
            // the provided array
            int[] sortedArray = InsertionSort<int>(originalArray);

            // Assert
            Assert.Equal(expectedArray, sortedArray);
        }

        /// <summary>
        /// Checks if InsertionSort can sort chars correctly
        /// </summary>
        [Fact]
        public void CanInsertionSortChars()
        {
            // Arrange
            char[] originalArray = new char[] { 'f', 'z', 'a', 'c', 'q' };
            char[] expectedArray = new char[] { 'a', 'c', 'f', 'q', 'z' };

            // Act
            // Technically, sorted array and original array are references
            // to the same array since InsertionSort operates directly on
            // the provided array
            char[] sortedArray = InsertionSort<char>(originalArray);

            // Assert
            Assert.Equal(expectedArray, sortedArray);
        }

        /// <summary>
        /// Checks if InsertionSort can sort doubles correctly
        /// </summary>
        [Fact]
        public void CanInsertionSortDoubles()
        {
            // Arrange
            double[] originalArray = new double[] { 1.7, 1.3, 0.9, 7.6, 6.5, Math.PI, Math.E };
            double[] expectedArray = new double[] { 0.9, 1.3, 1.7, Math.E, Math.PI, 6.5, 7.6 };

            // Act
            // Technically, sorted array and original array are references
            // to the same array since InsertionSort operates directly on
            // the provided array
            double[] sortedArray = InsertionSort<double>(originalArray);

            // Assert
            Assert.Equal(expectedArray, sortedArray);
        }
    }
}
