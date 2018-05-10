using System;
using Xunit;
using RadixSort;

namespace RadixSortTesting
{
    public class RadixSortTesting
    {
        /// <summary>
        /// Provides three test cases for the RadixSort method. Asserts that
        /// each value in the sorted array is greater than or equal to the
        /// previous value (i.e., the array is in ascending order)
        /// </summary>
        /// <param name="originalArray">The original, unsorted array</param>
        [Theory]
        [InlineData(new int[] { 34, 19, 42, 2018, 0, 2005, 77, 2099 })]
        [InlineData(new int[] { int.MaxValue, 43, 198, 3928, 0 })]
        [InlineData(new int[] { 0, 0, 0, 5, 0, 3, 0, 14, 9 })]
        [InlineData(new int[] { 986 })]
        public void RadixSortTest(int[] originalArray)
        {
            // Arrange
            bool isInAscendingOrder = true;

            // Act
            int[] sortedArray = Program.RadixSort(originalArray);

            // Assert
            // Make sure each element is greater than or equal to the previous element
            for (int i = 1; i < sortedArray.Length; i++)
            {
                if (sortedArray[i] < sortedArray[i - 1])
                {
                    isInAscendingOrder = false;
                    break;
                }
            }

            Assert.True(isInAscendingOrder);
        }

        /// <summary>
        /// Tests that the returned value from MaxValueInArray is truly the maximum
        /// value in the provided array
        /// </summary>
        /// <param name="array">The array to test MaxValueInArray for</param>
        [Theory]
        [InlineData(new int[] { 34, 19, 42, 2018, 0, 2005, 77, 2099 })]
        [InlineData(new int[] { int.MaxValue, 43, 198, 3928, 0 })]
        [InlineData(new int[] { 0, 0, 0, 5, 0, 3, 0, 14, 9 })]
        public void MaxValueTest(int[] array)
        {
            // Act
            int maxValue = Program.MaxValueInArray(array);

            // Assert
            Assert.DoesNotContain(array, a => a > maxValue);
        }

        /// <summary>
        /// Tests that the CountingSort algorithm used by RadixSort is properly
        /// sorting by individual digits in ascending order.
        /// </summary>
        /// <param name="arrayToSort">The array to test CountingSort for</param>
        /// <param name="digit">The digit place to test based on the radix</param>
        /// <param name="radix">The radix for the test. All tests are for base 10
        /// at this time</param>
        [Theory]
        [InlineData(new int[] { 34, 19, 42, 2018, 0, 2005, 77, 2099 }, 0)]
        [InlineData(new int[] { 34, 19, 42, 2018, 0, 2005, 77, 2099 }, 1)]
        [InlineData(new int[] { 34, 19, 42, 2018, 0, 2005, 77, 2099 }, 2)]
        [InlineData(new int[] { 34, 19, 42, 2018, 0, 2005, 77, 2099 }, 3)]
        [InlineData(new int[] { int.MaxValue, 43, 198, 3928, 0 }, 0)]
        [InlineData(new int[] { int.MaxValue, 43, 198, 3928, 0 }, 1)]
        [InlineData(new int[] { int.MaxValue, 43, 198, 3928, 0 }, 2)]
        [InlineData(new int[] { int.MaxValue, 43, 198, 3928, 0 }, 3)]
        [InlineData(new int[] { int.MaxValue, 43, 198, 3928, 0 }, 10)]
        [InlineData(new int[] { 0, 0, 0, 5, 0, 3, 0, 14, 9 }, 0)]
        [InlineData(new int[] { 0, 0, 0, 5, 0, 3, 0, 14, 9 }, 1)]
        [InlineData(new int[] { 0, 0, 0, 5, 0, 3, 0, 14, 9 }, 2)]
        public void CountingSortTest(int[] arrayToSort, int digit, int radix = 10)
        {
            // Arrange
            bool isInAscendingOrder = true;
            int digitFilter = (int)Math.Pow(radix, digit);

            // Act
            int[] sortedArray = Program.CountingSort(arrayToSort, digit);

            // Assert
            // Make sure the elements are truly in ascending order for the
            // specified digit place. _Just_ checks the specified digit, not
            // the total value. Signs are ignored for the sake of this test
            // per the definition of our RadixSort algorithm in its docstring
            for (int i = 1; i < sortedArray.Length; i++)
            {
                if ((sortedArray[i] / digitFilter) % radix <
                    (sortedArray[i - 1] / digitFilter) % radix)
                {
                    isInAscendingOrder = false;
                    break;
                }
            }

            Assert.True(isInAscendingOrder);
        }
    }
}
