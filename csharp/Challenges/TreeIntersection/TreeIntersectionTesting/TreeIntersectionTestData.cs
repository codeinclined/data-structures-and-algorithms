using BinaryTree;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TreeIntersectionTesting
{
    class TreeIntersectionTestData : IEnumerable<object[]>
    {
        /// <summary>
        /// Provides TreeIntersectionTest with three test cases
        /// </summary>
        /// <returns>An enumerator of objects containing two trees
        /// and an expected set intersection (in no defined order)</returns>
        public IEnumerator<object[]> GetEnumerator()
        {
            // First test case
            Tree<int> treeA = new Tree<int>(150);
            #region Populate first test example treeA
            {
                BinaryTree.Node<int> left = treeA.Root.Left = new BinaryTree.Node<int>(100);
                BinaryTree.Node<int> leftLeft = left.Left = new BinaryTree.Node<int>(75);
                BinaryTree.Node<int> leftRight = left.Right = new BinaryTree.Node<int>(160);
                BinaryTree.Node<int> leftRightLeft = leftRight.Left = new BinaryTree.Node<int>(125);
                BinaryTree.Node<int> leftRightRight = leftRight.Right = new BinaryTree.Node<int>(175);

                BinaryTree.Node<int> right = treeA.Root.Right = new BinaryTree.Node<int>(250);
                BinaryTree.Node<int> rightLeft = right.Left = new BinaryTree.Node<int>(200);
                BinaryTree.Node<int> rightRight = right.Right = new BinaryTree.Node<int>(350);
                BinaryTree.Node<int> rightRightLeft = rightRight.Left = new BinaryTree.Node<int>(300);
                BinaryTree.Node<int> rightRightRight = rightRight.Right = new BinaryTree.Node<int>(500);
            }
            #endregion

            Tree<int> treeB = new Tree<int>(42);
            #region Populate first test example treeB
            {
                BinaryTree.Node<int> left = treeB.Root.Left = new BinaryTree.Node<int>(100);
                BinaryTree.Node<int> leftLeft = left.Left = new BinaryTree.Node<int>(15);
                BinaryTree.Node<int> leftRight = left.Right = new BinaryTree.Node<int>(160);
                BinaryTree.Node<int> leftRightLeft = leftRight.Left = new BinaryTree.Node<int>(125);
                BinaryTree.Node<int> leftRightRight = leftRight.Right = new BinaryTree.Node<int>(175);

                BinaryTree.Node<int> right = treeB.Root.Right = new BinaryTree.Node<int>(600);
                BinaryTree.Node<int> rightLeft = right.Left = new BinaryTree.Node<int>(200);
                BinaryTree.Node<int> rightRight = right.Right = new BinaryTree.Node<int>(350);
                BinaryTree.Node<int> rightRightLeft = rightRight.Left = new BinaryTree.Node<int>(4);
                BinaryTree.Node<int> rightRightRight = rightRight.Right = new BinaryTree.Node<int>(500);
            }
            #endregion

            yield return new object[] {
                treeA,
                treeB,
                new List<int> { 100, 160, 125, 175, 200, 350, 500 }
            };

            // Second test case
            treeA = new Tree<int>(150);
            #region Populate second test example treeA
            {
                BinaryTree.Node<int> left = treeA.Root.Left = new BinaryTree.Node<int>(115);
                BinaryTree.Node<int> leftLeft = left.Left = new BinaryTree.Node<int>(75);
                BinaryTree.Node<int> leftRight = left.Right = new BinaryTree.Node<int>(160);
                BinaryTree.Node<int> leftRightLeft = leftRight.Left = new BinaryTree.Node<int>(197);
                BinaryTree.Node<int> leftRightRight = leftRight.Right = new BinaryTree.Node<int>(99);

                BinaryTree.Node<int> right = treeA.Root.Right = new BinaryTree.Node<int>(250);
                BinaryTree.Node<int> rightLeft = right.Left = new BinaryTree.Node<int>(200);
                BinaryTree.Node<int> rightRight = right.Right = new BinaryTree.Node<int>(350);
                BinaryTree.Node<int> rightRightLeft = rightRight.Left = new BinaryTree.Node<int>(300);
                BinaryTree.Node<int> rightRightRight = rightRight.Right = new BinaryTree.Node<int>(500);
            }
            #endregion

            treeB = new Tree<int>(150);
            #region Populate second test example treeB
            {
                BinaryTree.Node<int> left = treeB.Root.Left = new BinaryTree.Node<int>(100);
                BinaryTree.Node<int> leftLeft = left.Left = new BinaryTree.Node<int>(15);
                BinaryTree.Node<int> leftRight = left.Right = new BinaryTree.Node<int>(160);
                BinaryTree.Node<int> leftRightLeft = leftRight.Left = new BinaryTree.Node<int>(125);
                BinaryTree.Node<int> leftRightRight = leftRight.Right = new BinaryTree.Node<int>(175);

                BinaryTree.Node<int> right = treeB.Root.Right = new BinaryTree.Node<int>(600);
                BinaryTree.Node<int> rightLeft = right.Left = new BinaryTree.Node<int>(200);
                BinaryTree.Node<int> rightRight = right.Right = new BinaryTree.Node<int>(350);
                BinaryTree.Node<int> rightRightLeft = rightRight.Left = new BinaryTree.Node<int>(300);
                BinaryTree.Node<int> rightRightRight = rightRight.Right = new BinaryTree.Node<int>(700);
            }
            #endregion

            yield return new object[] {
                treeA,
                treeB,
                new List<int> {150, 160, 200, 350, 300 }
            };

            // Third test case
            treeA = new Tree<int>(43);
            #region Populate third test example treeA
            {
                BinaryTree.Node<int> left = treeA.Root.Left = new BinaryTree.Node<int>(-9);
                BinaryTree.Node<int> leftLeft = left.Left = new BinaryTree.Node<int>(15);
                BinaryTree.Node<int> leftRight = left.Right = new BinaryTree.Node<int>(-84);
                BinaryTree.Node<int> leftRightLeft = leftRight.Left = new BinaryTree.Node<int>(198);
                BinaryTree.Node<int> leftRightRight = leftRight.Right = new BinaryTree.Node<int>(9999);

                BinaryTree.Node<int> right = treeA.Root.Right = new BinaryTree.Node<int>(-9999);
                BinaryTree.Node<int> rightLeft = right.Left = new BinaryTree.Node<int>(38);
                BinaryTree.Node<int> rightRight = right.Right = new BinaryTree.Node<int>(-432);
                BinaryTree.Node<int> rightRightLeft = rightRight.Left = new BinaryTree.Node<int>(948);
                BinaryTree.Node<int> rightRightRight = rightRight.Right = new BinaryTree.Node<int>(483);
            }
            #endregion

            treeB = new Tree<int>(150);
            #region Populate third test example treeB
            {
                BinaryTree.Node<int> left = treeB.Root.Left = new BinaryTree.Node<int>(100);
                BinaryTree.Node<int> leftLeft = left.Left = new BinaryTree.Node<int>(15);
                BinaryTree.Node<int> leftRight = left.Right = new BinaryTree.Node<int>(160);
                BinaryTree.Node<int> leftRightLeft = leftRight.Left = new BinaryTree.Node<int>(125);
                BinaryTree.Node<int> leftRightRight = leftRight.Right = new BinaryTree.Node<int>(175);

                BinaryTree.Node<int> right = treeB.Root.Right = new BinaryTree.Node<int>(600);
                BinaryTree.Node<int> rightLeft = right.Left = new BinaryTree.Node<int>(200);
                BinaryTree.Node<int> rightRight = right.Right = new BinaryTree.Node<int>(350);
                BinaryTree.Node<int> rightRightLeft = rightRight.Left = new BinaryTree.Node<int>(300);
                BinaryTree.Node<int> rightRightRight = rightRight.Right = new BinaryTree.Node<int>(700);
            }
            #endregion

            yield return new object[] {
                treeA,
                treeB,
                new List<int> { 15 }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
