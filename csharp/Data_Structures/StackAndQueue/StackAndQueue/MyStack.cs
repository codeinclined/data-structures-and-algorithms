using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

[assembly: InternalsVisibleTo("StackAndQueueTest")]

namespace StackAndQueue
{
    public class MyStack<T>
    {
        /// <summary>
        /// Reference to the top node in this stack. For
        /// non-internal access to the top Node's value, 
        /// please use the Peek() or Pop() methods
        /// </summary>
        internal Node<T> Top { get; private set; }

        /// <summary>
        /// The number of Node objects within the stack
        /// </summary>
        public int Length { get; private set; }

        /// <summary>
        /// Constructor which provides an initial node
        /// with the value passed as <paramref name="firstNodeValue"/>
        /// </summary>
        /// <param name="firstNodeValue">Value of the first node
        /// in the new stack</param>
        public MyStack(T firstNodeValue)
        {
            Top = new Node<T>(firstNodeValue);
            Length = 1;
        }

        /// <summary>
        /// Constructor for an empty stack. Peek() and Pop() will
        /// result in exceptions until some value is pushed onto
        /// the stack.
        /// </summary>
        public MyStack()
        {
            Top = null;
            Length = 0;
        }

        /// <summary>
        /// Inserts a new Node onto the top of the stack with
        /// Value set to <paramref name="value"/>
        /// </summary>
        /// <param name="value">The Value property for the
        /// newly added Node</param>
        public void Push(T value)
        {
            Node<T> newNode = new Node<T>(value, Top);
            Top = newNode;
            Length++;
        }

        /// <summary>
        /// Returns the value held by the top Node of the stack
        /// without removing it
        /// </summary>
        /// <returns>The Value property of the top Node of
        /// the stack</returns>
        /// <exception cref="NullReferenceException">An attempt
        /// was made to peek the top value of an empty stack</exception>
        public T Peek()
        {
            return Top.Value;
        }

        /// <summary>
        /// Removes the top Node from the stack and returns its
        /// Value property
        /// </summary>
        /// <returns>The Value property of the Node being
        /// removed from the top of the stack</returns>
        /// <exception cref="NullReferenceException">An attempt
        /// was made to pop the top value of an empty stack</exception>
        public T Pop()
        {
            Node<T> oldTop = Top;
            Top = oldTop.Next;
            Length--;
            return oldTop.Value;
        }
    }
}
