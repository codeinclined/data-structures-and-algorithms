using System;
using System.Text;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("StackAndQueueTest")]

namespace StackAndQueue
{
    public class MyQueue<T>
    {
        /// <summary>
        /// Reference to the front Node of the queue. For
        /// non-internal access to this Node, please use the
        /// Peek() and Dequeue() methods of this class.
        /// </summary>
        internal Node<T> Front { get; private set; }

        /// <summary>
        /// Reference to the back Node of the queue. For
        /// non-internal access to this Node, please use the
        /// Dequeue() method until the end of the queue is reached.
        /// </summary>
        internal Node<T> Back { get; private set; }

        /// <summary>
        /// The number of Node objects within the queue
        /// </summary>
        public int Length { get; private set; }

        /// <summary>
        /// Constructor for a new queue with an initial
        /// front Node containing <paramref name="frontValue"/>
        /// as its Value property
        /// </summary>
        /// <param name="frontValue">The value of the
        /// initial Node object within the queue</param>
        public MyQueue(T frontValue)
        {
            Front = new Node<T>(frontValue);
            Back = Front;
            Length = 1;
        }

        /// <summary>
        /// Constructor for an empty queue. Attempting to call
        /// Peek() or Dequeue() methods will result in an exception
        /// until a Node is added through Enqueue()
        /// </summary>
        public MyQueue()
        {
            Front = null;
            Back = Front;
            Length = 0;
        }

        /// <summary>
        /// Add a new Node object containing <paramref name="newValue"/>
        /// as its Value property to the front of the queue.
        /// </summary>
        /// <param name="newValue">The value that the new Node's Value
        /// property will contain</param>
        public void Enqueue(T newValue)
        {
            // If the queue is empty, create a new Node for the
            // Front reference
            if (Front is null)
            {
                Front = new Node<T>(newValue);
                Back = Front;
            }
            // Otherwise, set the old Back object's Next reference to a
            // new Node and change the Back reference to that new Node
            else
            {
                Back.Next = new Node<T>(newValue);
                Back = Back.Next;
            }

            Length++;
        }

        /// <summary>
        /// Remove the front Node from the queue and return its Value
        /// property
        /// </summary>
        /// <returns>The Value property of type <typeparamref name="T"/>
        /// that the removed Node contained</returns>
        public T Dequeue()
        {
            Node<T> oldFrontNode = Front;
            Front = Front.Next;
            Length--;
            return oldFrontNode.Value;
        }

        /// <summary>
        /// Returns the Value property of the front Node of the queue.
        /// Does not remove the Node object from the queue.
        /// </summary>
        /// <returns>The Value property of type <typeparamref name="T"/>
        /// from the front Node of the queue.</returns>
        public T Peek()
        {
            return Front.Value;
        }
    }
}
