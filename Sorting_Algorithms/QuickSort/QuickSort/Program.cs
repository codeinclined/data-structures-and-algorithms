using System;

namespace QuickSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quick sort:");

            #region First Example
            {
                int[] exampleArray = { 34, 19, 42, -9, 2018, 0, 2005, 77, 2099 };

                Console.WriteLine();
                Console.WriteLine($"First Example Pre-Sort:  [{string.Join(", ", exampleArray)}]");
                Console.WriteLine($"First Example Post-Sort: [{string.Join(", ", QuickSort(exampleArray))}]");
            }
            #endregion

            #region Second Example
            {
                int[] exampleArray = { int.MaxValue, int.MinValue, 42, 13, 26 };

                Console.WriteLine();
                Console.WriteLine($"Second Example Pre-Sort:  [{string.Join(", ", exampleArray)}]");
                Console.WriteLine($"Second Example Post-Sort: [{string.Join(", ", QuickSort(exampleArray))}]");
            }
            #endregion

            #region Third Example
            {
                int[] exampleArray = { 1, 1, 1, 1, 3, 1, 2 };

                Console.WriteLine();
                Console.WriteLine($"Third Example Pre-Sort:  [{string.Join(", ", exampleArray)}]");
                Console.WriteLine($"Third Example Post-Sort: [{string.Join(", ", QuickSort(exampleArray))}]");
            }
            #endregion

            Console.WriteLine();
            Console.WriteLine("Please press any key to exit this demonstration...");
            Console.ReadKey();
        }

        /// <summary>
        /// Convenience overload which initiates a quick sort from index 0 through the last index
        /// of the provided array (the entire array argument is taken as one partition).
        /// </summary>
        /// <param name="arrayToSort">The array to be sorted</param>
        /// <returns>A reference to the now-sorted array (in ascending order)</returns>
        public static int[] QuickSort(int[] arrayToSort) =>
            QuickSort(arrayToSort, 0, arrayToSort.Length - 1);

        /// <summary>
        /// Sorts a provided array in ascending order using the quick sort algorithm
        /// </summary>
        /// <param name="arrayToSort">The array to be sorted</param>
        /// <param name="begin">The starting index of the partition upon which this method will sort</param>
        /// <param name="end">The ending index of the partition upon which this method will sort</param>
        /// <returns>A reference to the now-sorted array (in ascending order)</returns>
        public static int[] QuickSort(int[] arrayToSort, int begin, int end)
        {
            if (arrayToSort.Length > 1 && begin < end)
            {
                // Find the pivot value and the left and right iterators
                int pivotValue = arrayToSort[(end + begin) / 2];
                int left = begin;
                int right = end;

                // Iterate until the left and right iterators pass one another
                while (left <= right)
                {
                    // Move the iterators along until a value is reached on the
                    // incorrect side of the pivot point
                    while (arrayToSort[left] < pivotValue)
                    {
                        left++;
                    }
                    while (arrayToSort[right] > pivotValue)
                    {
                        right--;
                    }

                    // If the loop is still valid after moving the iterators above,
                    // then we have reached a pair of values that are on the wrong
                    // side of the pivot. Swap these values to correct this
                    if (left <= right)
                    {
                        int temp = arrayToSort[left];
                        arrayToSort[left] = arrayToSort[right];
                        arrayToSort[right] = temp;
                        // Advance the left and right iterators (we know the swapped
                        // values are on the correct sides of the pivot now)
                        left++;
                        right--;
                    }
                }

                // Recurse on the partitions left and right of the pivot point if the 
                // source array can be further partitioned
                if (begin < right)
                {
                    QuickSort(arrayToSort, begin, right);
                }
                if (left < end)
                {
                    QuickSort(arrayToSort, left, end);
                }
            }

            // We have reached our base case; start popping off of the call stack
            return arrayToSort;
        }
    }
}
