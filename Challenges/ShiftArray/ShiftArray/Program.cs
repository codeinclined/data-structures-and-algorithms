using System;

namespace ShiftArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Display the first example case
            int[] example1 = new int[4] { 2, 4, 6, 8 };

            Console.WriteLine(
                $"Original array:\t\t[{string.Join(", ", example1)}]");
            Console.WriteLine("Value to insert:\t5");
            Console.WriteLine(
                $"Insert shifted array:\t[{string.Join(", ", InsertShiftArray(example1, 5))}]");

            // Display the second example case
            int[] example2 = new int[5] { 4, 8, 15, 23, 42 };

            Console.WriteLine();
            Console.WriteLine(
                $"Original array:\t\t[{string.Join(", ", example2)}]");
            Console.WriteLine("Value to insert:\t16");
            Console.WriteLine(
                $"Insert shifted array:\t[{string.Join(", ", InsertShiftArray(example2, 16))}]");

            Console.WriteLine("\nPlease press a key to exit...");
            Console.ReadKey();
        }

        /// <summary>
        /// Returns a copy of <paramref name="inputArray"/> with a length
        /// increased by 1, and <paramref name="newValue"/> inserted into
        /// the middle.
        /// </summary>
        /// <typeparam name="T">The types of values <paramref name="inputArray"/>
        /// and the returned array hold.</typeparam>
        /// <param name="inputArray">The source array</param>
        /// <param name="newValue">The value to be inserted to the middle of
        /// <paramref name="inputArray"/></param>
        /// <returns>Copy of <paramref name="inputArray"/> with length
        /// increased by 1 and <paramref name="newValue"/> inserted into
        /// the middle</returns>
        public static T[] InsertShiftArray<T>(T[] inputArray, T newValue)
        {
            // Allocate a new array for the output and find the midpoint
            // of the input array
            T[] shiftedArray = new T[inputArray.Length + 1];
            int inputMidpoint = inputArray.Length - inputArray.Length / 2;

            // Assign the first half of the values from the input array
            for (int i = 0; i < inputMidpoint; i++)
            {
                shiftedArray[i] = inputArray[i];
            }

            // Assign the new value to the midpoint index of the output array
            shiftedArray[inputMidpoint] = newValue;

            // Assign the remaining values to the output array
            for (int i = inputMidpoint; i < inputArray.Length; i++)
            {
                shiftedArray[i + 1] = inputArray[i];
            }

            return shiftedArray;
        }
    }
}
