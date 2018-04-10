using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public class Node<T>
    {
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public T Value { get; set; }

        public Node(T value)
        {
            Value = value;
        }
    }
}
