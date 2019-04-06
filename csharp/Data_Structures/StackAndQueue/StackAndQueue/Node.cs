using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    /// <summary>
    /// Represents a single node for MyStack and MyQueue
    /// </summary>
    /// <typeparam name="T">The type of object held by the Value
    /// property and the strong type for the Next Node reference
    /// generic class</typeparam>
    public class Node<T>
    {
        public T Value { get; set; }
        internal Node<T> Next { get; set; }

        /// <summary>
        /// Constructor for Node. Can set Value and Next for the
        /// new Node object or the Value will default to the default
        /// value of type <typeparamref name="T"/> and Next to null
        /// </summary>
        /// <param name="value">The Value property for the new Node,
        /// defaults to the default value for type <typeparamref name="T"/>
        /// </param>
        /// <param name="next">The Next property for the new Node,
        /// defaults to null</param>
        public Node(T value = default(T), Node<T> next = null)
        {
            Value = value;
            Next = next;
        }
    }
}
