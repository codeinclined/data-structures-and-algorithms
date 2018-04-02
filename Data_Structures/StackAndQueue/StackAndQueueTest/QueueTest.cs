using System;
using Xunit;
using StackAndQueue;

namespace StackAndQueueTest
{
    public class QueueTest
    {
        [Theory]
        [InlineData(new int[] { 1 })]
        [InlineData(new int[] { 1, 2 })]
        [InlineData(new int[] { 1, 2, 3 })]
        public void EnqueueNodesTest(int[] seedValues)
        {
            // Arrange
            MyQueue<int> myQueue = new MyQueue<int>();

            // Act
            foreach (int seedValue in seedValues)
            {
                myQueue.Enqueue(seedValue);
            }

            // Assert
            Assert.Equal(seedValues[0], myQueue.Front.Value);
        }

        [Fact]
        public void EnqueueCanAffectLength()
        {
            // Arrange
            MyQueue<int> untouchedQueue = new MyQueue<int>(5);
            MyQueue<int> enqueuedQueue = new MyQueue<int>(5);

            // Act
            enqueuedQueue.Enqueue(10);

            // Assert
            Assert.True(enqueuedQueue.Length > untouchedQueue.Length);
        }

        [Fact]
        public void DequeueCanAffectLength()
        {
            // Arrange
            MyQueue<int> untouchedQueue = new MyQueue<int>(5);
            MyQueue<int> dequeuedQueue = new MyQueue<int>(5);

            // Act
            dequeuedQueue.Dequeue();

            // Assert
            Assert.True(dequeuedQueue.Length < untouchedQueue.Length);
        }

        [Fact]
        public void CanFindLength()
        {
            // Arrange
            MyQueue<int> myQueue = new MyQueue<int>();

            // Act
            // Enqueue 4 nodes and dequeue 2, resulting in 2 nodes
            myQueue.Enqueue(3);
            myQueue.Enqueue(5);
            myQueue.Enqueue(7);
            myQueue.Enqueue(11);

            myQueue.Dequeue();
            myQueue.Dequeue();

            // Assert
            Assert.Equal(2, myQueue.Length);
        }

        [Theory]
        [InlineData(new int[] { 1 })]
        [InlineData(new int[] { 1, 2 })]
        [InlineData(new int[] { 1, 2, 3 })]
        public void PeekNodeTest(int[] seedValues)
        {
            // Arrange
            MyQueue<int> myQueue = new MyQueue<int>();

            foreach (int seedValue in seedValues)
            {
                myQueue.Enqueue(seedValue);
            }

            // Act
            int peekedValue = myQueue.Peek();

            // Assert
            Assert.Equal(seedValues[0], peekedValue);
        }

        [Theory]
        [InlineData(new int[] { 1 })]
        [InlineData(new int[] { 1, 2 })]
        [InlineData(new int[] { 1, 2, 3 })]
        public void DequeueNodesTest(int[] seedValues)
        {
            // Arrange
            MyQueue<int> myQueue = new MyQueue<int>();

            foreach (int seedValue in seedValues)
            {
                myQueue.Enqueue(seedValue);
            }

            // Act
            // Dequeue all values and store the back Node's
            // value to ensure that not only is Dequeue() returning
            // the front value, but it is also removing Nodes like
            // it should
            for (int i = 0; i < seedValues.Length - 1; i++)
            {
                myQueue.Dequeue();
            }

            int backValue = myQueue.Dequeue();

            // Assert
            Assert.Equal(seedValues[seedValues.Length - 1], backValue);
        }

        [Fact]
        public void CannotPeekEmptyQueue()
        {
            // Arrange
            MyQueue<int> myQueue = new MyQueue<int>();

            // Act + Assert
            Assert.Throws<NullReferenceException>(() => myQueue.Peek());
        }

        [Fact]
        public void CannotDequeueEmptyQueue()
        {
            // Arrange
            MyQueue<int> myQueue = new MyQueue<int>();

            // Act + Assert
            Assert.Throws<NullReferenceException>(() => myQueue.Dequeue());
        }
    }
}
