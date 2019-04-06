using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using BinaryTree;

namespace FizzBuzzTree
{
    // Copied from the FizzBuzzTreeTest project minus the expected case
    // (Visual Studio does not allow projects to move circular references)
    class TreeTestData : IEnumerable<Tree<string>>
    {
        public IEnumerator<Tree<string>> GetEnumerator()
        {
            // Build three test cases with different numbers
            {
                Tree<string> tree = new Tree<string>("1");

                Node<string> left = tree.Root.Left = new Node<string>("2");
                Node<string> leftLeft = left.Left = new Node<string>("3");
                Node<string> leftRight = left.Right = new Node<string>("4");

                Node<string> right = tree.Root.Right = new Node<string>("5");
                Node<string> rightLeft = right.Left = new Node<string>("6");
                Node<string> rightRight = right.Right = new Node<string>("7");

                Node<string> leftLeftLeft = leftLeft.Left = new Node<string>("8");
                Node<string> leftLeftRight = leftLeft.Right = new Node<string>("9");

                yield return tree;
            }

            {
                Tree<string> tree = new Tree<string>("5");

                Node<string> left = tree.Root.Left = new Node<string>("7");
                Node<string> leftLeft = left.Left = new Node<string>("9");
                Node<string> leftRight = left.Right = new Node<string>("11");

                Node<string> right = tree.Root.Right = new Node<string>("14");
                Node<string> rightLeft = right.Left = new Node<string>("17");
                Node<string> rightRight = right.Right = new Node<string>("15");

                Node<string> leftLeftLeft = leftLeft.Left = new Node<string>("27");
                Node<string> leftLeftRight = leftLeft.Right = new Node<string>("33");

                yield return tree;
            }

            {
                Tree<string> tree = new Tree<string>("3");

                Node<string> left = tree.Root.Left = new Node<string>("9");
                Node<string> leftLeft = left.Left = new Node<string>("19");
                Node<string> leftRight = left.Right = new Node<string>("18");

                Node<string> right = tree.Root.Right = new Node<string>("6");
                Node<string> rightLeft = right.Left = new Node<string>("5");
                Node<string> rightRight = right.Right = new Node<string>("13");

                Node<string> leftLeftLeft = leftLeft.Left = new Node<string>("15");
                Node<string> leftLeftRight = leftLeft.Right = new Node<string>("8");

                yield return tree;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
