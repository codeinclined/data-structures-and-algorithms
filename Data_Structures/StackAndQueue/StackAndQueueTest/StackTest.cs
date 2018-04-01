using System;
using Xunit;
using StackAndQueue;

namespace StackAndQueueTest
{
    public class StackTest
    {
        [Theory]
        [InlineData(new int[] { 1 })]
        [InlineData(new int[] { 1, 2 })]
        [InlineData(new int[] { 1, 2, 3 })]
        public void PushNodesTest(int[] seedValues)
        {
            // Arrange
            MyStack<int> myStack = new MyStack<int>();

            // Act
            foreach (int seedValue in seedValues)
            {
                myStack.Push(seedValue);
            }

            // Assert
            // Pop all values into a new array and test its
            // equality with the seedValues array
            int[] stackValues = new int[seedValues.Length];

            // Work in reverse since stacks are FILO
            for (int i = seedValues.Length - 1; i >= 0; i--)
            {
                stackValues[i] = myStack.Pop();
            }

            Assert.Equal(seedValues, stackValues);
        }

        [Fact]
        public void PushCanAffectLength()
        {
            // Arrange
            MyStack<int> untouchedStack = new MyStack<int>(5);
            MyStack<int> pushedStack = new MyStack<int>(5);

            // Act
            pushedStack.Push(10);

            // Assert
            Assert.True(pushedStack.Length > untouchedStack.Length);
        }

        [Fact]
        public void PopCanAffectLength()
        {
            // Arrange
            MyStack<int> untouchedStack = new MyStack<int>(5);
            MyStack<int> poppedStack = new MyStack<int>(5);

            // Act
            poppedStack.Pop();

            // Assert
            Assert.True(poppedStack.Length < untouchedStack.Length);
        }

        [Fact]
        public void CanFindLength()
        {
            // Arrange
            MyStack<int> myStack = new MyStack<int>();

            // Act
            // Push 4 nodes and pop 2, resulting in 2 nodes
            myStack.Push(3);
            myStack.Push(5);
            myStack.Push(7);
            myStack.Push(11);

            myStack.Pop();
            myStack.Pop();

            // Assert
            Assert.Equal(2, myStack.Length);
        }

        [Theory]
        [InlineData(new int[] { 1 })]
        [InlineData(new int[] { 1, 2 })]
        [InlineData(new int[] { 1, 2, 3 })]
        public void PeekNodeTest(int[] seedValues)
        {
            // Arrange
            MyStack<int> myStack = new MyStack<int>();

            foreach(int seedValue in seedValues)
            {
                myStack.Push(seedValue);
            }

            // Act
            int peekedValue = myStack.Peek();

            // Assert
            Assert.Equal(seedValues[seedValues.Length - 1], myStack.Peek());
        }

        [Theory]
        [InlineData(new int[] { 1 })]
        [InlineData(new int[] { 1, 2 })]
        [InlineData(new int[] { 1, 2, 3 })]
        public void PopNodesTest(int[] seedValues)
        {
            // Arrange
            MyStack<int> myStack = new MyStack<int>();

            foreach (int seedValue in seedValues)
            {
                myStack.Push(seedValue);
            }

            // Act
            // Pop all values and store the first Node's value to ensure
            // that not only is Pop() returning the top value, but that
            // it is also removing Nodes like it should
            for (int i = 0; i < seedValues.Length - 1; i++)
            {
                myStack.Pop();
            }

            int firstValue = myStack.Pop();

            // Assert
            Assert.Equal(seedValues[0], firstValue);
        }

        [Fact]
        public void CannotPeekEmptyStack()
        {
            // Arrange
            MyStack<int> myStack = new MyStack<int>();

            // Act + Assert
            Assert.Throws<NullReferenceException>(() => myStack.Peek());
        }

        [Fact]
        public void CannotPopEmptyStack()
        {
            // Arrange
            MyStack<int> myStack = new MyStack<int>();

            // Act + Assert
            Assert.Throws<NullReferenceException>(() => myStack.Pop());
        }
    }
}
