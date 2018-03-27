using System;
using System.Collections.Generic;
using System.Text;

namespace SinglyLinkedList
{
    /// <summary>
    /// Represents a node in a linked list which
    /// contains a single integer value of type int.
    /// </summary>
    public class Node
    {
        public Node Next { get; set; } = null;
        public int Value { get; set; }

        /// <summary>
        /// Constructor for a Node object containing a
        /// value but no reference to a next node
        /// </summary>
        /// <param name="value">The value that this node
        /// will contain</param>
        public Node(int value)
        {
            Value = value;
        }

        /// <summary>
        /// Constructor for a Node object containing a
        /// value as well as a reference to the provided
        /// Node object as this node's Next property
        /// </summary>
        /// <param name="value">The value that this node
        /// will contain</param>
        /// <param name="next">A reference to the next
        /// node in a linked list.</param>
        public Node(int value, Node next)
        {
            Value = value;
            Next = next;
        }
    }
}
