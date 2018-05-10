using System;

namespace RadixSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Radix Sort");

            #region First Example
            {
                int[] exampleArray = { 34, 19, 42, 2018, 0, 2005, 77, 2099 };

                Console.WriteLine();
                Console.WriteLine($"First example pre-sort:  [{string.Join(", ", exampleArray)}]");
                Console.WriteLine($"First example post-sort: [{string.Join(", ", RadixSort(exampleArray))}]");
            }
            #endregion

            #region Second Example
            {
                int[] exampleArray = { int.MaxValue, 43, 198, 3928, 0 };

                Console.WriteLine();
                Console.WriteLine($"Second example pre-sort:  [{string.Join(", ", exampleArray)}]");
                Console.WriteLine($"Second example post-sort: [{string.Join(", ", RadixSort(exampleArray))}]");
            }
            #endregion

            #region Third Example
            {
                int[] exampleArray = { 0, 0, 0, 5, 0, 3, 0, 14, 9 };

                Console.WriteLine();
                Console.WriteLine($"Third example pre-sort:  [{string.Join(", ", exampleArray)}]");
                Console.WriteLine($"Third example post-sort: [{string.Join(", ", RadixSort(exampleArray))}]");
            }
            #endregion

            Console.WriteLine();
            Console.WriteLine("Please press any key to exit this demonstration...");
            Console.ReadKey();
        }

        /// <summary>
        /// Finds the maximum value in an integer array
        /// </summary>
        /// <param name="array">The array to find the maximum value for</param>
        /// <returns>The maximum integer value contained in the provided array. Returns
        /// System.Int32.MinValue if the provided array is empty.</returns>
        public static int MaxValueInArray(int[] array)
        {
            // Start at the minimum value for int. Prevents having to check for
            // an empty array or single elment array while still providing the
            // expected functionality.
            int maxValue = int.MinValue;

            // Compare each value against the running maxValue, replacing it as needed
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }

            return maxValue;
        }

        /// <summary>
        /// Performs a counting sort on the specified digit of each element of the provided
        /// array with <paramref name="radix"/> number of buckets.
        /// </summary>
        /// <param name="arrayToSort">The array to sort</param>
        /// <param name="place">The "place" of the digit to sort the array by</param>
        /// <param name="radix">The radix of the number system used by the elements of
        /// the provided array (defaults to base 10)</param>
        /// <returns>The array sorted by the specified digit place in ascending order</returns>
        public static int[] CountingSort(int[] arrayToSort, int place, int radix = 10)
        {
            // Create the working array and counts used to determine the sorting order
            // of the returned elements
            int[] working = new int[arrayToSort.Length];
            int[] counts = new int[radix];
            // This is referenced multiple times in this method to help isolate
            // individual digits of the elements. Precalculate and cache the value.
            int digitFilter = (int)Math.Pow(radix, place);

            // Store the counts of each numeric value for this specified digit place
            for (int i = 0; i < arrayToSort.Length; i++)
            {
                counts[(arrayToSort[i] / digitFilter) % radix]++;
            }
            // Turn the counts into running totals rather than counts of individual values
            for (int i = 1; i < radix; i++)
            {
                counts[i] += counts[i - 1];
            }
            // Use the running totals calculated above to determine the locations of each
            // individual element in the sorted array, decrementing the running totals
            // in order to allow the values to cascade forward in the resultant array
            for (int i = arrayToSort.Length - 1; i >= 0; i--)
            {
                working[--counts[(arrayToSort[i] / digitFilter) % radix]] = arrayToSort[i];
            }

            return working;
        }

        /// <summary>
        /// Sorts the provided integer array using the non-comparative radix sort algorithm
        /// in ascending order, ignoring the sign of the array's values (-105 will come after 104)
        /// </summary>
        /// <param name="arrayToSort">An array of integers to sort in ascending order</param>
        /// <param name="radix">The radix of the number system representing the array's values,
        /// defaulting to base 10</param>
        /// <returns>The sorted array in ascending order (ignoring sign)</returns>
        public static int[] RadixSort(int[] arrayToSort, int radix = 10)
        {
            // An array with fewer than two elements is already "sorted"
            if (arrayToSort.Length < 2)
            {
                return arrayToSort;
            }

            // Iterate through each digit of the integers in the array, applying a pass of
            // the counting sort algorithm to each digit place. The number of iterations, k,
            // is determined by the maximum value in the array (stored in maxValue). Each
            // iteration divides maxValue by the radix, meaning that the loop will only run
            // for the number of digits contained in the maximum value of the array.
            for (int i = 0, maxValue = MaxValueInArray(arrayToSort);
                 maxValue > 0; i++, maxValue /= radix)
            {
                arrayToSort = CountingSort(arrayToSort, i);
            }

            return arrayToSort;
        }
    }
}
