using System;
using Xunit;
using ShiftArray;

namespace ShiftArrayTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[4] { 2, 4, 6, 8 }, 5, new int[5] { 2, 4, 5, 6, 8 })]
        [InlineData(new int[5] { 4, 8, 15, 23, 42 }, 16,
            new int[6] { 4, 8, 15, 16, 23, 42 })]
        [InlineData(new int[2] { 4, 9 }, 17, new int[3] { 4, 17, 9 })]
        public void TestInsertShiftArray(int[] testArray, int testValue, int[] expectedArray)
        {
            Assert.Equal(expectedArray, Program.InsertShiftArray(testArray, testValue));
        }
    }
}
