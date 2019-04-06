using BinaryTree;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeTest
{
    class TreeTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            Tree<int> tree = new Tree<int>(1);

            Node<int> left = tree.Root.Left = new Node<int>(2);
            Node<int> leftLeft = left.Left = new Node<int>(3);
            Node<int> leftRight = left.Right = new Node<int>(4);

            Node<int> right = tree.Root.Right = new Node<int>(5);
            Node<int> rightLeft = right.Left = new Node<int>(6);
            Node<int> rightRight = right.Right = new Node<int>(7);

            Node<int> leftLeftLeft = leftLeft.Left = new Node<int>(8);
            Node<int> leftLeftRight = leftLeft.Right = new Node<int>(9);

            yield return new object[] { tree };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
