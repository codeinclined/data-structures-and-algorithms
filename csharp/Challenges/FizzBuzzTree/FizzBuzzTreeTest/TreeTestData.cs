using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using BinaryTree;

namespace FizzBuzzTreeTest
{
    class TreeTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            // Build three test cases with different numbers. First tree is the
            // seed data, second tree is the test data
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

                //////////////////////////////////////////////////////////////////

                Tree<string> fizzTree = new Tree<string>("1");

                Node<string> fizzLeft = fizzTree.Root.Left = new Node<string>("2");
                Node<string> fizzLeftLeft = fizzLeft.Left = new Node<string>("Fizz");
                Node<string> fizzLeftRight = fizzLeft.Right = new Node<string>("4");

                Node<string> fizzRight = fizzTree.Root.Right = new Node<string>("Buzz");
                Node<string> fizzRightLeft = fizzRight.Left = new Node<string>("Fizz");
                Node<string> fizzRightRight = fizzRight.Right = new Node<string>("7");

                Node<string> fizzLeftLeftLeft = fizzLeftLeft.Left = new Node<string>("8");
                Node<string> fizzLeftLeftRight = fizzLeftLeft.Right = new Node<string>("Fizz");

                yield return new object[] { tree, fizzTree };
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

                //////////////////////////////////////////////////////////////////

                Tree<string> fizzTree = new Tree<string>("Buzz");

                Node<string> fizzLeft = fizzTree.Root.Left = new Node<string>("7");
                Node<string> fizzLeftLeft = fizzLeft.Left = new Node<string>("Fizz");
                Node<string> fizzLeftRight = fizzLeft.Right = new Node<string>("11");

                Node<string> fizzRight = fizzTree.Root.Right = new Node<string>("14");
                Node<string> fizzRightLeft = fizzRight.Left = new Node<string>("17");
                Node<string> fizzRightRight = fizzRight.Right = new Node<string>("FizzBuzz");

                Node<string> fizzLeftLeftLeft = fizzLeftLeft.Left = new Node<string>("Fizz");
                Node<string> fizzLeftLeftRight = fizzLeftLeft.Right = new Node<string>("Fizz");

                yield return new object[] { tree, fizzTree };
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

                //////////////////////////////////////////////////////////////////

                Tree<string> fizzTree = new Tree<string>("Fizz");

                Node<string> fizzLeft = fizzTree.Root.Left = new Node<string>("Fizz");
                Node<string> fizzLeftLeft = fizzLeft.Left = new Node<string>("19");
                Node<string> fizzLeftRight = fizzLeft.Right = new Node<string>("Fizz");

                Node<string> fizzRight = fizzTree.Root.Right = new Node<string>("Fizz");
                Node<string> fizzRightLeft = fizzRight.Left = new Node<string>("Buzz");
                Node<string> fizzRightRight = fizzRight.Right = new Node<string>("13");

                Node<string> fizzLeftLeftLeft = fizzLeftLeft.Left = new Node<string>("FizzBuzz");
                Node<string> fizzLeftLeftRight = fizzLeftLeft.Right = new Node<string>("8");

                yield return new object[] { tree, fizzTree };
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
