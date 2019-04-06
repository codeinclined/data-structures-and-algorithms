using System;

namespace MergeSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merge Sort:");

            #region First Example
            {
                int[] example = new int[] { 34, 19, 42, -9, 2018, 0, 2005, 77, 2099 };
                Console.WriteLine();
                Console.WriteLine("First Example");
                Console.WriteLine($"Original: [{string.Join(", ", example)}]");
                Console.WriteLine($"Sorted:   [{string.Join(", ", MergeSort(example))}]");
            }
            #endregion

            #region Second Example
            {
                int[] example = new int[] { 5, -5, 0, 3, 17, 43 };
                Console.WriteLine();
                Console.WriteLine("Second Example");
                Console.WriteLine($"Original: [{string.Join(", ", example)}]");
                Console.WriteLine($"Sorted:   [{string.Join(", ", MergeSort(example))}]");
            }
            #endregion

            #region Third Example
            {
                int[] example = new int[] { int.MaxValue, int.MinValue };
                Console.WriteLine();
                Console.WriteLine("Third Example");
                Console.WriteLine($"Original: [{string.Join(", ", example)}]");
                Console.WriteLine($"Sorted:   [{string.Join(", ", MergeSort(example))}]");
            }
            #endregion

            Console.WriteLine();
            Console.WriteLine("Please press any key to exit this demonstration...");
            Console.ReadKey();
        }

        /// <summary>
        /// Merges together the specified array using the elements between the start
        /// and end indexes, pivoting on the midpoint index
        /// </summary>
        /// <param name="arrayToMerge">The source array to perform the merge on</param>
        /// <param name="start">The beginning of the portion of the source array to
        /// merge</param>
        /// <param name="midpoint">The pivot point for the merge</param>
        /// <param name="end">The ending index of the merged portion of the source array</param>
        /// <returns>Merged array based on ascending order comparisons</returns>
        internal static int[] Merge(int[] arrayToMerge, int start, int midpoint, int end)
        {
            // Worker array
            int[] mergedArray = new int[end - start + 1];

            // Indexes to walk up the values left and right of the midpoint pivot
            int leftIndex = start;
            int rightIndex = midpoint + 1;

            // Iterate over the worker array, taking values from the left and right
            // portions as they satisfy ascending order. If one half is exhausted
            // before the other, then just add the other half's values to the
            // worker array until all values are exhausted
            for (int k = 0; k < mergedArray.Length; k++)
            {
                if (leftIndex > midpoint)
                {
                    mergedArray[k] = arrayToMerge[rightIndex++];
                }
                else if (rightIndex > end)
                {
                    mergedArray[k] = arrayToMerge[leftIndex++];
                }
                else if (arrayToMerge[leftIndex] < arrayToMerge[rightIndex])
                {
                    mergedArray[k] = arrayToMerge[leftIndex++];
                }
                else
                {
                    mergedArray[k] = arrayToMerge[rightIndex++];
                }
            }

            // Commit the merge to the source array efficiently via the
            // CopyTo method (similar to C's memset function)
            mergedArray.CopyTo(arrayToMerge, start);
            return arrayToMerge;
        }

        /// <summary>
        /// Convenience overload for initiating a merge sort without having to manually
        /// specify the starting and ending index
        /// </summary>
        /// <param name="arrayToSort">The array to be sorted</param>
        /// <returns>Sorted array in ascending order</returns>
        public static int[] MergeSort(int[] arrayToSort) => MergeSort(arrayToSort, 0, arrayToSort.Length - 1);

        /// <summary>
        /// Sorts the provided array in ascending order using merge sort
        /// </summary>
        /// <param name="arrayToSort">The array to sort</param>
        /// <param name="start">The starting index</param>
        /// <param name="end">The ending index</param>
        /// <returns>Sorted array in ascending order</returns>
        public static int[] MergeSort(int[] arrayToSort, int start, int end)
        {
            if (start < end || arrayToSort.Length < 2)
            {
                int midpoint = (start + end) / 2;

                MergeSort(arrayToSort, start, midpoint);
                MergeSort(arrayToSort, midpoint + 1, end);

                return Merge(arrayToSort, start, midpoint, end);
            }

            return arrayToSort;
        }
    }
}
