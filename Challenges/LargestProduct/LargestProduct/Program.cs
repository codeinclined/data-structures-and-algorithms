using System;

namespace LargestProduct
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[,] inputArray = new int[,]
            {
                { 1, 2 },
                { 3, 4 },
                { 5, 6 },
                { 7, 8 },
            };

            // Print out 2D input array
            for (int i = 0; i < inputArray.GetLength(0); i++)
            {
                Console.Write("{ ");

                for (int j = 0; j < inputArray.GetLength(1); j++)
                {
                    Console.Write($"{inputArray[i, j]} ");
                }

                Console.WriteLine("}");
            }

            // Print out the answer
            Console.WriteLine($"\nLargest inner array product: {LargestProduct(inputArray)}");
            Console.WriteLine("\nPlease press any key to exit this program...");
            Console.ReadKey();
        }

        /// <summary>
        /// Takes in a 2D array and returns the largest product resulting from multiplying
        /// the elements of each individual inner array together
        /// </summary>
        /// <param name="inputArray">2D array to find the largest inner array product of</param>
        /// <returns>The largest inner array product</returns>
        public static int LargestProduct(int[,] inputArray)
        {
            // Ensure that neither dimension is empty
            if (inputArray.GetLength(0) < 1 || inputArray.GetLength(1) < 1)
            {
                throw new ArgumentException("Must provide an 2D array with dimensions" +
                    "greater than 0 in length.", nameof(inputArray));
            }

            int largestProduct = 0;
            int innerProduct = 0;

            for (int i = 0; i < inputArray.GetLength(0); i++)
            {
                // Reset the inner product for this iteration to the first item of the
                // inner array
                innerProduct = inputArray[i, 0];

                for (int j = 1; j < inputArray.GetLength(1); j++)
                {
                    innerProduct *= inputArray[i, j];
                }

                if (innerProduct > largestProduct)
                {
                    largestProduct = innerProduct;
                }
            }

            return largestProduct;
        }
    }
}
