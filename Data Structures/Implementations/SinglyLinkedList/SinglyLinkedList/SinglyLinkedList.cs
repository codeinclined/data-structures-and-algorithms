using System;
using System.Collections.Generic;
using System.Text;

namespace SinglyLinkedList
{
    public class SinglyLinkedList
    {
        /// <summary>
        /// Represents the Node object at the front of the linked
        /// list. If this is null, then the linked list is empty.
        /// </summary>
        public Node Head { get; set; }

        /// <summary>
        /// Adds a new node to the front of the linked list
        /// and returns a reference to that newly added node.
        /// </summary>
        /// <param name="value">The value to be contained by
        /// the newly added node.</param>
        /// <returns>A reference to the newly added node.</returns>
        public Node Add(int value)
        {
            // If our linked list is empty, simply set Head to
            // a new node containing the provided value
            if (Head == null)
            {
                return Head = new Node(value);
            }

            // Create a new node pointing to the current head to
            // prevent it from being flagged by the garbage collector
            // and then set Head to our new head node.
            Node newHead = new Node(value, Head);
            return Head = newHead;
        }

        /// <summary>
        /// Attempts to find the first node within this linked list
        /// which contains the value specified. If this value is not
        /// found within our linked list, then this method will return
        /// null.
        /// </summary>
        /// <param name="value">The value to search for among the nodes
        /// of this linked list.</param>
        /// <returns>A reference to the first node in the linked list
        /// that contains the provided value. If this value is not
        /// found among the linked list's nodes, then null is returned</returns>
        public Node Find(int value)
        {
            // If our linked list is empty, then simply return null
            // as there are no nodes to find value in
            if (Head == null)
            {
                return Head;
            }

            Node currentNode = Head;

            // Walk through the linked list until we either reach the end of
            // the linked list or current node contains the value that we are
            // searching for. If the value is not found, this will result in
            // null being returned as our documentation states.
            // This will not access a null object due to the short-circuiting
            // of the conditional && operator
            while (currentNode != null && currentNode.Value != value)
            {
                currentNode = currentNode.Next;
            }

            return currentNode;
        }
    }
}
