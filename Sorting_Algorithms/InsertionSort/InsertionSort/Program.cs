using System;

namespace InsertionSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insertion Sort");

            #region First example
            {
                int[] example = new int[] { 5, 4, 3, 2, 1 };
                Console.WriteLine();
                Console.WriteLine("Example 1 Before Sorting:");
                Console.WriteLine($"[{string.Join(", ", example)}]");
                Console.WriteLine("Example 1 After Sorting:");
                Console.WriteLine($"[{string.Join(", ", InsertionSort(example))}]");
            }
            #endregion

            #region Second example
            {
                char[] example = new char[] { 'f', 'z', 'a', 'c', 'q' };
                Console.WriteLine();
                Console.WriteLine("Example 2 Before Sorting:");
                Console.WriteLine($"[{string.Join(", ", example)}]");
                Console.WriteLine("Example 2 After Sorting:");
                Console.WriteLine($"[{string.Join(", ", InsertionSort(example))}]");
            }
            #endregion

            #region Third example
            {
                double[] example = new double[] { 1.7, 1.3, 0.9, 7.6, 6.5, Math.PI, Math.E };
                Console.WriteLine();
                Console.WriteLine("Example 3 Before Sorting:");
                Console.WriteLine($"[{string.Join(", ", example)}]");
                Console.WriteLine("Example 3 After Sorting:");
                Console.WriteLine($"[{string.Join(", ", InsertionSort(example))}]");
            }
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
        /// <param name="arrayToSort">The array to sort</param>
        /// <returns>The sorted array</returns>
        public static T[] InsertionSort<T>(T[] arrayToSort) where T : IComparable<T>
        {
            // Iterate over each key index in the array
            for (int i = 0; i < arrayToSort.Length; i++)
            {
                // Store a reference to the current "key" value
                T keyValue = arrayToSort[i];
                int j = i - 1;

                // Use a while loop instead of a for loop in order to keep j in
                // scope to insert the keyValue back into the array at the
                // appropriate location. Use the CompareTo method of the
                // IComparable interface to allow for this method to be generic
                while (j >= 0 && arrayToSort[j].CompareTo(keyValue) > 0)
                {
                    arrayToSort[j + 1] = arrayToSort[j];
                    j--;
                }

                // All values ahead of the intended location of keyValue
                // have been swapped. Insert the value back into the array at
                // the appropriate position taken from the final value of j
                // after the above while loop
                arrayToSort[j + 1] = keyValue;
            }

            // Return a reference to the sorted array
            return arrayToSort;
        }
    }
}
