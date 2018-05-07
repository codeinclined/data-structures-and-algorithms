using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insertion Sort");

            #region First example
            int[] example = new int[] { 5, 4, 3, 2, 1 };
            Console.WriteLine();
            Console.WriteLine("Example 1 Before Sorting:");
            Console.WriteLine($"[{string.Join(", ", example)}]");
            Console.WriteLine("Example 1 After Sorting:");
            Console.WriteLine($"[{string.Join(", ", InsertionSort(example))}]");
            #endregion

            #region Second example
            example = new int[] { 14, 17, 3, 19, 27 };
            Console.WriteLine();
            Console.WriteLine("Example 2 Before Sorting:");
            Console.WriteLine($"[{string.Join(", ", example)}]");
            Console.WriteLine("Example 2 After Sorting:");
            Console.WriteLine($"[{string.Join(", ", InsertionSort(example))}]");
            #endregion

            #region Third example
            example = new int[] { 1, 2, 3, 7, 6, 5, 4 };
            Console.WriteLine();
            Console.WriteLine("Example 3 Before Sorting:");
            Console.WriteLine($"[{string.Join(", ", example)}]");
            Console.WriteLine("Example 3 After Sorting:");
            Console.WriteLine($"[{string.Join(", ", InsertionSort(example))}]");
            #endregion

            Console.WriteLine();
            Console.Write("Please press any key to exit this demonstration...");
            Console.ReadKey(true);
        }

        /// <summary>
        /// Performs an insertion sort on the provided array of type T
        /// </summary>
        /// <typeparam name="T">The type of values in the array to be sorted
        /// where T implements the IComparable interface</typeparam>
        /// <param name="unsortedArray">The array to sort</param>
        /// <returns>The sorted array</returns>
        public static T[] InsertionSort<T>(T[] unsortedArray) where T : IComparable<T>
        {
            // Iterate over each key index in the array
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                // Store a reference to the current "key" value
                T keyValue = unsortedArray[i];
                int j = i - 1;

                // Use a while loop instead of a for loop in order to keep j in
                // scope to insert the keyValue back into the array at the
                // appropriate location
                while (j >= 0 && unsortedArray[j].CompareTo(keyValue) > 0)
                {
                    unsortedArray[j + 1] = unsortedArray[j];
                    j--;
                }

                // All values ahead of the intended location of keyValue
                // have been swapped. Insert the value back into the array at
                // the appropriate position taken from the final value of j
                // after the above while loop
                unsortedArray[j + 1] = keyValue;
            }

            // Return a reference to the sorted array
            return unsortedArray;
        }
    }
}
