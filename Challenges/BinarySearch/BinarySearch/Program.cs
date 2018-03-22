using System;

namespace BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize parameters based on the challenge's
            // example inputs and outputs
            int[] example1 = new int[] { 4, 8, 15, 16, 23, 42 };
            int example1Query = 15;
            int[] example2 = new int[] { 11, 22, 33, 44, 55, 66, 77 };
            int example2Query = 90;

            // Display the first example's inputs and search result
            Console.WriteLine("Example 1 Array");
            Console.WriteLine($"[{string.Join(", ", example1)}]");
            Console.WriteLine($"Searching for {example1Query} gives index " +
                $"{BinarySearch(example1, example1Query)}");

            // Display the second example's inputs and search result
            Console.WriteLine("\nExample 2 Array");
            Console.WriteLine($"[{string.Join(", ", example2)}]");
            Console.WriteLine($"Searching for {example2Query} gives index " +
                $"{BinarySearch(example2, example2Query)}");

            Console.WriteLine("\nPlease press any key to exit this program...");
            Console.ReadKey();
        }

        /// <summary>
        /// Searches for <paramref name="searchValue"/> within
        /// <paramref name="inputArray"/> using the binary search algorithm.
        /// Returns either an index for the found value or -1 if the value
        /// cannot be found in the array.
        /// </summary>
        /// <param name="inputArray">A pre-sorted (ascending), one-dimensional array</param>
        /// <param name="searchValue">The value to search for within the array</param>
        /// <returns>The index for the found value or -1 if the value was not found</returns>
        public static int BinarySearch(int[] inputArray, int searchValue)
        {
            // In the special case of an array of length 1, just check
            // the single element against searchValue
            if (inputArray.Length == 1)
            {
                if (inputArray[0] == searchValue)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }

            int left = 0;
            int right = inputArray.Length - 1;
            int midpoint;

            // Keep slicing the array until either searchValue is found
            // or all elements of the array have been exhausted
            while (left < right)
            {
                midpoint = (left + right) / 2;

                if (inputArray[midpoint] == searchValue)
                {
                    return midpoint;
                }
                
                if (inputArray[midpoint] < searchValue)
                {
                    left = midpoint + 1;
                }
                else if (inputArray[midpoint] > searchValue)
                {
                    right = midpoint - 1;
                }
            }

            return -1;
        }
    }
}
