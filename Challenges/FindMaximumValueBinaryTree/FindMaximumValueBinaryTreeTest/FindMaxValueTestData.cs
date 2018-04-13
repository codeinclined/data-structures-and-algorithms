using BinaryTree;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumValueBinaryTreeTest
{
    class FindMaxValueTestData : IEnumerable<object[]>
    {
        /// <summary>
        /// Provides four test cases for xUnit test of FindMaximumValue()
        /// </summary>
        /// <returns>Four enumerated Trees via yield</returns>
        public IEnumerator<object[]> GetEnumerator()
        {
            {
                Tree<int> tree = new Tree<int>(2);

                Node<int> left = tree.Root.Left = new Node<int>(7);
                Node<int> right = tree.Root.Right = new Node<int>(5);

                Node<int> leftLeft = left.Left = new Node<int>(2);
                Node<int> leftRight = left.Right = new Node<int>(6);

                Node<int> leftRightleft = leftRight.Left = new Node<int>(5);
                Node<int> leftRightRight = leftRight.Right = new Node<int>(11);

                Node<int> rightRight = right.Right = new Node<int>(9);
                Node<int> rightRightLeft = rightRight.Left = new Node<int>(4);

                yield return new object[] { tree, 11 };
            }
            {
                Tree<int> tree = new Tree<int>(9);

                Node<int> left = tree.Root.Left = new Node<int>(3);
                Node<int> right = tree.Root.Right = new Node<int>(15);

                Node<int> leftLeft = left.Left = new Node<int>(23);
                Node<int> leftRight = left.Right = new Node<int>(9);

                Node<int> leftRightleft = leftRight.Left = new Node<int>(97);
                Node<int> leftRightRight = leftRight.Right = new Node<int>(13);

                Node<int> rightRight = right.Right = new Node<int>(-2);
                Node<int> rightRightLeft = rightRight.Left = new Node<int>(7);

                yield return new object[] { tree, 97 };
            }
            {
                Tree<int> tree = new Tree<int>(400);

                Node<int> left = tree.Root.Left = new Node<int>(50);
                Node<int> right = tree.Root.Right = new Node<int>(19);

                Node<int> leftLeft = left.Left = new Node<int>(84);
                Node<int> leftRight = left.Right = new Node<int>(42);

                Node<int> rightRight = right.Right = new Node<int>(-1002);
                Node<int> rightRightLeft = rightRight.Left = new Node<int>(99);
                Node<int> rightRightRight = rightRight.Right = new Node<int>(39);

                yield return new object[] { tree, 400 };
            }
            {
                Tree<int> tree = new Tree<int>(-1);

                Node<int> left = tree.Root.Left = new Node<int>(-230);
                Node<int> right = tree.Root.Right = new Node<int>(-43);

                Node<int> leftLeft = left.Left = new Node<int>(-49);
                Node<int> leftRight = left.Right = new Node<int>(-933);

                Node<int> rightRight = right.Right = new Node<int>(-42812);
                Node<int> rightRightLeft = rightRight.Left = new Node<int>(-48302);
                Node<int> rightRightRight = rightRight.Right = new Node<int>(-2);

                yield return new object[] { tree, -1 };
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
