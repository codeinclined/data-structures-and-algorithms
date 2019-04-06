using System;
using Xunit;
using FifoAnimalShelter;
using StackAndQueue;
using static FifoAnimalShelter.Program;

namespace FifoAnimalShelterTest
{
    public class AnimalShelterTest
    {
        [Fact]
        public void CanEnqueueCat()
        {
            // Arrange
            MyQueue<Cat> catQueue = new MyQueue<Cat>();
            MyQueue<Dog> dogQueue = new MyQueue<Dog>();
            long runningSerialNumber = 0;

            // Act
            Enqueue(catQueue, dogQueue, ref runningSerialNumber, new Cat());

            // Assert
            Assert.Equal(0, catQueue.Peek().SerialNumber);
        }

        [Fact]
        public void CanEnqueueDog()
        {
            // Arrange
            MyQueue<Cat> catQueue = new MyQueue<Cat>();
            MyQueue<Dog> dogQueue = new MyQueue<Dog>();
            long runningSerialNumber = 0;

            // Act
            Enqueue(catQueue, dogQueue, ref runningSerialNumber, new Dog());

            // Assert
            Assert.Equal(0, dogQueue.Peek().SerialNumber);
        }

        [Fact]
        public void CanEnqueueMultipleAnimals()
        {
            // Arrange
            MyQueue<Cat> catQueue = new MyQueue<Cat>();
            MyQueue<Dog> dogQueue = new MyQueue<Dog>();
            long runningSerialNumber = 0;

            // Act
            Enqueue(catQueue, dogQueue, ref runningSerialNumber, new Cat());
            Enqueue(catQueue, dogQueue, ref runningSerialNumber, new Dog());

            // Assert
            Assert.Equal(1, dogQueue.Peek().SerialNumber);
        }

        [Theory]
        [InlineData(new string[] { "cat", "dog", "cat", "dog" }, "cat", 0)]
        [InlineData(new string[] { "cat", "dog", "cat", "dog" }, "dog", 1)]
        [InlineData(new string[] { "cat", "dog", "cat", "dog" }, "", 0)]
        public void CanDequeueCat(string[] enqueueTypes, string dequeueType, long expectedSerial)
        {
            // Arrange
            MyQueue<Cat> catQueue = new MyQueue<Cat>();
            MyQueue<Dog> dogQueue = new MyQueue<Dog>();
            long runningSerialNumber = 0;

            // Fill up the animal shelter without needing to use ClassData for xUnit theory
            foreach (string enqueueType in enqueueTypes)
            {
                if (enqueueType.ToLower() == "cat")
                {
                    Enqueue(catQueue, dogQueue, ref runningSerialNumber, new Cat());
                }
                else if (enqueueType.ToLower() == "dog")
                {
                    Enqueue(catQueue, dogQueue, ref runningSerialNumber, new Dog());
                }
                else
                {
                    throw new ArgumentException(@"enqueueTypes elements must be either ""cat"" or ""dog""");
                }
            }

            // Act
            long actualSerial = Dequeue(catQueue, dogQueue, dequeueType).SerialNumber;

            // Assert
            Assert.Equal(expectedSerial, actualSerial);
        }
    }
}
