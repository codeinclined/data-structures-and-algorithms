using System;
using Xunit;
using LargestProduct;

namespace LargestProductTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[,] inputArray = new int[,]
            {
                { 1, 3 },
                { 3, 7 },
                { 5, 5 },
                { 0, 1 },
                { -3, 10 }
            };

            Assert.Equal(25, Program.LargestProduct(inputArray));
        }

        [Fact]
        public void Test2()
        {
            int[,] inputArray = new int[,]
            {
                { 1, 2 },
                { 3, 4 },
                { 5, 6 },
                { 7, 8 },
            };

            Assert.Equal(56, Program.LargestProduct(inputArray));
        }

        [Fact]
        public void Test3()
        {
            int[,] inputArray = new int[,]
            {
                { 0, 3 },
                { 9, 1 },
                { 3, 5 },
                { 0, 1 },
                { -3, 11 }
            };

            Assert.Equal(15, Program.LargestProduct(inputArray));
        }

        [Fact]
        public void Test4()
        {
            int[,] inputArray = new int[,]
            {
                { 17, 3 },
                { 43, 9 },
                { 105, 8 },
                { 1_000, 5 },
                { 3, 70 }
            };

            Assert.Equal(5_000, Program.LargestProduct(inputArray));
        }

        [Fact]
        public void Test5()
        {
            int[,] inputArray = new int[,]
            {
                { 21, 33 },
                { 38, 347 },
                { 523, 45 },
                { 10, 1 },
                { 45, 100 }
            };

            Assert.Equal(23_535, Program.LargestProduct(inputArray));
        }
    }
}
