using System;
using StackAndQueue;
using static QueueWithStacks.Program;
using Xunit;

namespace QueueWithStacksTest
{
    public class QueueWithStacksTest
    {
        [Theory]
        [InlineData(new int[] { 2, 3, 5, 7, 11, 13 })]
        [InlineData(new int[] { 2 })]
        [InlineData(new int[] { 2, 3 })]
        [InlineData(new int[] { 2, 3, 5, 7, 13 })]
        public void EnqueueTest(int[] seedValues)
        {
            // Arrange
            MyStack<int> inStack = new MyStack<int>();
            MyStack<int> outStack = new MyStack<int>();

            // Act
            foreach (int value in seedValues)
            {
                Enqueue(inStack, outStack, value);
            }

            // Assert
            // Assert that the items were inserted in the correct FIFO
            // access order by comparing the first Dequeue result with
            // the first value in the seedValues array
            Assert.Equal(seedValues[0], Dequeue(inStack, outStack));
        }

        [Theory]
        [InlineData(new int[] { 2, 3, 5, 7, 11, 13 })]
        [InlineData(new int[] { 2 })]
        [InlineData(new int[] { 2, 3 })]
        [InlineData(new int[] { 2, 3, 5, 7, 13 })]
        public void DequeueTest(int[] seedValues)
        {
            // Arrange
            MyStack<int> inStack = new MyStack<int>();
            MyStack<int> outStack = new MyStack<int>();

            foreach (int value in seedValues)
            {
                Enqueue(inStack, outStack, value);
            }

            // Act
            // Dequeue until end of the queue, then store the last
            // node's value to assert below
            for (int i = 0; i < seedValues.Length - 1; i++)
            {
                Dequeue(inStack, outStack);
            }

            int actualValue = Dequeue(inStack, outStack);

            // Assert
            // The last dequeued node's value should match the last item
            // in the seedValues array since queues work in FIFO order
            Assert.Equal(seedValues[seedValues.Length - 1], actualValue);
        }
    }
}
