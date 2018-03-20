using System;
using System.Linq;

namespace reverse_an_array
{
    class Program
    {
        // Test cases
        internal static int[][] _testCases = new int[][]
        {
            new int[] { 1, 2, 3, 4, 5, 6 },
            new int[] { 89, 2354, 3546, 23, 10, -923, 823, -12 },
            new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31,
                37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83,
                89, 97, 101, 103, 107, 109, 113, 127, 131, 137,
                139, 149, 151, 157, 163, 167, 173, 179, 181, 191,
                193, 197, 199 }
        };

        // Expected output for each test of the algorithm
        internal static int[][] _testExpected = new int[][]
        {
            new int[] { 6, 5, 4, 3, 2, 1 },
            new int[] { -12, 823, -923, 10, 23, 3546, 2354, 89 },
            new int[] { 199, 197, 193, 191, 181, 179, 173, 167,
                163, 157, 151, 149, 139, 137, 131, 127, 113, 109, 107, 103, 101,
                97, 89, 83, 79, 73, 71, 67, 61, 59, 53, 47, 43, 41, 37, 31, 29,
                23, 19, 17, 13, 11, 7, 5, 3, 2 }
        };

        static void Main(string[] args)
        {
            // Tests each array in the _testCases jagged array to the arrays in
            // the _testExpected jagged array to ensure that the algorithm
            // functioned correctly. Displays "Failed test" on failure and 
            // "Passed test" on success.
            for (int i = 0; i < _testCases.Length; i++)
            {
                if (!reverseArray(_testCases[i]).SequenceEqual(_testExpected[i]))
                {
                    Console.WriteLine($"Failed test {i}!");
                }
                else
                {
                    Console.WriteLine($"Passed test {i}!");
                }
            }

            Console.WriteLine("\nPlease press any key to exit...");
            Console.ReadKey();
        }

        /// <summary>
        /// Takes an array of type T, non-destructively reverses it, and returns the result.
        /// </summary>
        /// <typeparam name="T">The type of array values</typeparam>
        /// <param name="arrayToReverse">The array to non-destructively reverse.</param>
        /// <returns>An array containing the same values as <paramref name="arrayToReverse"/> but in reverse order.</returns>
        public static T[] reverseArray<T>(T[] arrayToReverse)
        {
            T[] destArray = new T[arrayToReverse.Length];

            for (int i = 0; i < arrayToReverse.Length; i++)
            {
                destArray[arrayToReverse.Length - 1 - i] = arrayToReverse[i];
            }

            return destArray;
        }
    }
}
